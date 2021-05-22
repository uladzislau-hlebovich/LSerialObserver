
namespace Configurator
{
    partial class SerialPortControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelDevicePath = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxDevicePath = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelStopBits, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelDevicePath, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelBaudRate, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelDataBits, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelParity, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxDevicePath, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.comboBoxBaudRate, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.comboBoxDataBits, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxParity, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxStopBits, 1, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.MaximumSize = new System.Drawing.Size(350, 200);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(350, 200);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelStopBits
            // 
            this.labelStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStopBits.Location = new System.Drawing.Point(3, 160);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(169, 40);
            this.labelStopBits.TabIndex = 4;
            this.labelStopBits.Text = "Stop Bits";
            this.labelStopBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDevicePath
            // 
            this.labelDevicePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDevicePath.AutoSize = true;
            this.labelDevicePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDevicePath.Location = new System.Drawing.Point(3, 0);
            this.labelDevicePath.Name = "labelDevicePath";
            this.labelDevicePath.Size = new System.Drawing.Size(169, 40);
            this.labelDevicePath.TabIndex = 0;
            this.labelDevicePath.Text = "Device Path";
            this.labelDevicePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBaudRate.Location = new System.Drawing.Point(3, 40);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(169, 40);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baud Rate";
            this.labelBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDataBits
            // 
            this.labelDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataBits.Location = new System.Drawing.Point(3, 80);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(169, 40);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits";
            this.labelDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelParity
            // 
            this.labelParity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParity.AutoSize = true;
            this.labelParity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParity.Location = new System.Drawing.Point(3, 120);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(169, 40);
            this.labelParity.TabIndex = 3;
            this.labelParity.Text = "Parity";
            this.labelParity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxDevicePath
            // 
            this.comboBoxDevicePath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxDevicePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDevicePath.FormattingEnabled = true;
            this.comboBoxDevicePath.Location = new System.Drawing.Point(178, 8);
            this.comboBoxDevicePath.Name = "comboBoxDevicePath";
            this.comboBoxDevicePath.Size = new System.Drawing.Size(169, 29);
            this.comboBoxDevicePath.TabIndex = 5;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(178, 48);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(169, 29);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(178, 88);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(169, 29);
            this.comboBoxDataBits.TabIndex = 7;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(178, 128);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(169, 29);
            this.comboBoxParity.TabIndex = 8;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(178, 168);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(169, 29);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // SerialPortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SerialPortControl";
            this.Size = new System.Drawing.Size(350, 200);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelDevicePath;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxDevicePath;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
    }
}
