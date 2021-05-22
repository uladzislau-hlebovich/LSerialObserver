using System.Threading.Tasks;

namespace LSerialObserver
{
    // Наблюдатель
    public class Observer
    {
        // Подключение к последовательному порту
        public SerialPortConnection SerialPort { get; set; } = new();

        // Структура данных
        public StructParser Struct { get; set; } = new();

        // Последний полученный пакет
        public Package LastPackage { get; set; } = new();

        // Запустить
        public async Task Start()
        {
            // Запустить последовательный порт и подписать парсер на получение данных
            SerialPort.Start();
            SerialPort.DataReceived += Struct.HandleDataReceived;

            while (true)
                // Разобрать и сохранить следующий пакет
                LastPackage = await Struct.ParseNext();
        }
    }
}
