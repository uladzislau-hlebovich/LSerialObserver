using LSerialObserver;

namespace Configurator
{
    public partial class SerialPortControl : UserControl
    {
        public SerialPortControl()
        {
            InitializeComponent();

            // Инициализация параметров для ...
            // списка устройств
            comboBoxDevicePath.DataSource = SerialPort.GetPortNames();

            // скорости передачи
            comboBoxBaudRate.DataSource = new[]
                {110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000};
            comboBoxBaudRate.SelectedItem = 9600;

            // проверки чётности
            comboBoxParity.DataSource = Enum.GetValues(typeof(Parity));

            // бит данных
            comboBoxDataBits.DataSource = new[] {5, 6, 7, 8};
            comboBoxDataBits.SelectedItem = 8;

            // бит остановки
            comboBoxStopBits.DataSource = new double[] {1, 1.5, 2};
        }

        // Вернуть параметры подключения из формы
        public SerialPortConnection GetConnection()
        {
            return new()
            {
                DevicePath = comboBoxDevicePath.Text,
                BaudRate = (int) comboBoxBaudRate.SelectedValue,
                //Parity = (Parity)comboBoxParity.SelectedValue,
                DataBits = (int) comboBoxDataBits.SelectedValue,
                StopBits = (double) comboBoxStopBits.SelectedValue
            };
        }

        // Установить параметры подключения в форму
        public void SetConnection(SerialPortConnection connection)
        {
            comboBoxDevicePath.Text = connection.DevicePath;
            comboBoxBaudRate.SelectedItem = connection.BaudRate;
            comboBoxParity.SelectedItem = connection.Parity;
            comboBoxDataBits.SelectedItem = connection.DataBits;
            comboBoxStopBits.SelectedItem = connection.StopBits;
        }
    }
}
