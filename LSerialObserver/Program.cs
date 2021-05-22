using System;
using System.IO;
using System.Threading.Tasks;

namespace LSerialObserver
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // Путь к конфигурационному файлу
            const string configFile = "Data/Observer.json";

            // Если конфигурационный файл не существует
            if (File.Exists(configFile) is not true)
            {
                // Создать папку
                Directory.CreateDirectory("Data/");
                // Вывести ошибку и выйти из программы
                Console.Write(@$"""{configFile}"" not found. Exiting...");
                return;
            }

            // Чтение конфигурационного файла из создание объекта Наблюдателя
            var file = File.ReadAllText(configFile);
            var observer = Json.Deserialize<Observer>(file);

            // Запустить Наблюдателя в фоне
            Task.Run(observer.Start);

            // Создать HTTP сервер
            HttpServer server = new();

            // Отдача статического файла index.html
            server.Static("/", "text/html", "WebUI/index.html");
            // Отдача Наблюдателя в формате JSON по адресу /API/Observer
            server.Get("/API/Observer", (req, res) => { res.Json(observer); });
            // Запуск HTTP сервера
            await server.Listen(8080);
        }
    }
}
