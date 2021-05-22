using System;
using System.IO.Ports;

namespace LSerialObserver
{
    // Подключение к последовательному порту
    public class SerialPortConnection
    {
        private SerialPort _serialPort;

        // Путь к устройству
        public string DevicePath { get; set; }

        // Скорость передачи
        public int BaudRate { get; set; } = 9600;

        // Проверка чётности
        public Parity Parity { get; set; } = Parity.None;

        // Бит данных
        public int DataBits { get; set; } = 8;

        // Бит остановки
        public double StopBits { get; set; } = 1;

        // Событие получения данных
        public event Action<byte[]> DataReceived;

        // Запуск последовательного порта
        public void Start()
        {
            var stopBits = StopBits switch
            {
                1 => System.IO.Ports.StopBits.One,
                1.5 => System.IO.Ports.StopBits.OnePointFive,
                2 => System.IO.Ports.StopBits.Two,
                _ => throw new ArgumentOutOfRangeException()
            };

            _serialPort = new SerialPort(DevicePath, BaudRate, Parity, DataBits, stopBits);
            _serialPort.DataReceived += SerialPortOnDataReceived;
            _serialPort.Open();
        }

        // Остановка  последовательного порта
        public void Close()
        {
            _serialPort.DataReceived -= SerialPortOnDataReceived;
            _serialPort.Close();
        }

        // Обработчик получения данных с последовательного порта
        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var len = _serialPort.BytesToRead;
            var bytes = new byte[len];
            _serialPort.Read(bytes, 0, len);
            DataReceived?.Invoke(bytes);
        }
    }
}
