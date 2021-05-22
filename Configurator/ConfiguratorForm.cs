using LSerialObserver;

namespace Configurator
{
    public partial class ConfiguratorForm : Form
    {
        public ConfiguratorForm()
        {
            InitializeComponent();

            toolStripMenuItemOpen.Click += toolStripMenuItemOpen_Click;
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
        }

        // Выбор пункта меню File -> Open
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            // Если файл был выбран
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Прочитать параметры наблюдателя из файла и установить их в контролах

                string filename = openFileDialog.FileName;
                string text = File.ReadAllText(filename);

                var observer = Json.Deserialize<Observer>(text);
                serialPortControl1.SetConnection(observer.SerialPort);
                structControl1.SetStruct(observer.Struct);
            }
        }

        // Выбор пункта меню File -> Save
        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            // Если место для сохранения было выбрано
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получить параметры из контролов и сохранить их в файл

                string filename = saveFileDialog.FileName;
                string text = Json.Serialize(new Observer
                {
                    SerialPort = serialPortControl1.GetConnection(),
                    Struct = structControl1.GetStruct()
                });

                File.WriteAllText(filename, text);
            }
        }
    }
}
