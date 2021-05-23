using System;
using System.ComponentModel;
using System.Windows.Forms;
using LSerialObserver;

namespace Configurator
{
    public partial class StructControl : UserControl
    {
        // Список строк редактора
        public BindingList<Row> Rows = new BindingList<Row>();

        public StructControl()
        {
            InitializeComponent();

            // Инициализация параметров для последовательности байт
            comboBoxEndianness.DataSource = Enum.GetValues(typeof(EndiannessType));

            // Отключить автогенерацию колонок редактора
            dataGridView.AutoGenerateColumns = false;

            // Связывание данных 
            dataGridView.DataSource = Rows;

            // Колонка имени поля
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                Name = "Name"
            });

            // Колонка типа поля
            dataGridView.Columns.Add(new DataGridViewComboBoxColumn
            {
                DataSource = Enum.GetValues(typeof(FieldType)),
                DataPropertyName = "Type",
                Name = "Type"
            });

            // Колонка количества элементов в массиве
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Count",
                Name = "Count"
            });
        }

        // Вернуть параметры структуры из формы
        public StructParser GetStruct()
        {
            var s = new StructParser();

            s.Endianness = (EndiannessType) comboBoxEndianness.SelectedItem;

            foreach (var row in Rows) s.Fields.Add(row.Name, new StructField {Type = row.Type, Count = row.Count});

            return s;
        }

        // Установить параметры структуры в форму
        public void SetStruct(StructParser s)
        {
            comboBoxEndianness.SelectedItem = s.Endianness;

            Rows.Clear();
            foreach (var (name, field) in s.Fields) Rows.Add(new Row {Name = name, Type = field.Type, Count = 1});
        }

        // Объект строки редактора
        public class Row : StructField
        {
            public string Name { get; set; }
        }
    }
}
