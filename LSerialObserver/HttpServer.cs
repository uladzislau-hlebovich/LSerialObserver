using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LSerialObserver
{
    // Объект запроса HTTP сервера
    public class Request
    {
        public HttpListenerRequest _;
    }

    // Объект ответа HTTP сервера
    public class Response
    {
        public HttpListenerResponse _;

        // Составить ответ из JSON объекта
        public void Json(object obj)
        {
            _.ContentType = "application/json";
            Text(LSerialObserver.Json.Serialize(obj));
        }

        // Составить ответ из текста
        public void Text(string str)
        {
            var buffer = Encoding.UTF8.GetBytes(str);
            _.ContentEncoding = Encoding.UTF8;
            _.ContentType ??= "text/plain";
            _.ContentLength64 = buffer.Length;
            _.OutputStream.Write(buffer, 0, buffer.Length);
            _.Close();
        }
    }

    // Делегат обработчика HTTP запросов
    public delegate void RequestHandler(Request req, Response res);

    // HTTP сервер
    public class HttpServer
    {
        // Общий обработчик для отправки ответа 404
        private static readonly RequestHandler HandleNotFound = (req, res) =>
        {
            res._.StatusCode = 404;
            res.Text($@"Handler with path ""{req._.Url?.AbsolutePath}"" is not found");
        };

        // Список обработчиков запросов
        private readonly List<(string path, string method, RequestHandler handler)> _handlers = new();

        // Слушатель HTTP запросов
        private HttpListener _httpListener;

        // Добавить обработчик для отдачи статического файла
        public void Static(string path, string mimeType, string localFile)
        {
            var bytes = File.ReadAllBytes(localFile);
            _handlers.Add((path, "GET", HandleBytes(bytes, mimeType)));
        }

        // Добавить обработчик для GET запроса
        public void Get(string path, RequestHandler handler)
        {
            _handlers.Add((path, "GET", handler));
        }

        // Запуск HTTP сервера
        public async Task Listen(int port)
        {
            // Конфигурация HTTP слушателя
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add($"http://localhost:{port}/");
            _httpListener.Start();

            while (true)
            {
                // Дождаться получения запроса
                var ctx = await _httpListener.GetContextAsync();
                var ctxRequest = ctx.Request;
                var ctxResponse = ctx.Response;

                var responded = false; // Был ли дан ответ на этот запрос?

                var req = new Request {_ = ctxRequest};
                var res = new Response {_ = ctxResponse};

                // Цикл по всем обработчикам с конца, для того чтобы обработчики,
                // добавленные позднее, имели более высокий приоритет
                foreach (var (path, method, handler) in _handlers.AsEnumerable().Reverse())
                    // Параметры обработчика совпадают с запросом?
                    if (HandlerMatching(path, method, ctxRequest))
                    {
                        // Обработать запрос и выйти из цикла
                        handler.Invoke(req, res);
                        responded = true;
                        break;
                    }

                // Если ответ не был отправлен, то вызвать общий обработчик для 404
                if (!responded) HandleNotFound(req, res);
            }
        }

        // Параметры обработчика совпадают с запросом?
        private bool HandlerMatching(string path, string method, HttpListenerRequest request)
        {
            // Совпадает HTTP метод?
            if (method.Equals(request.HttpMethod, StringComparison.OrdinalIgnoreCase))
                // Совпадает путь?
                if (path.Equals(request.Url?.AbsolutePath, StringComparison.OrdinalIgnoreCase))
                    return true;

            return false;
        }

        // Общий обработчик для отправки бинарных данных
        private static RequestHandler HandleBytes(byte[] bytes, string mimeType)
        {
            return (req, res) =>
            {
                res._.ContentType = mimeType;
                res._.OutputStream.Write(bytes, 0, bytes.Length);
                res._.Close();
            };
        }
    }
}
