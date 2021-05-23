
namespace Configurator
{
    partial class ConfiguratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSerialPort = new System.Windows.Forms.TabPage();
            this.tabPageStruct = new System.Windows.Forms.TabPage();
            this.serialPortControl1 = new Configurator.SerialPortControl();
            this.structControl1 = new Configurator.StructControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSerialPort.SuspendLayout();
            this.tabPageStruct.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Controls.Add(this.tabControl, 0, 1);
            this.tableLayout.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(384, 262);
            this.tableLayout.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSerialPort);
            this.tabControl.Controls.Add(this.tabPageStruct);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(378, 231);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageSerialPort
            // 
            this.tabPageSerialPort.Controls.Add(this.serialPortControl1);
            this.tabPageSerialPort.Location = new System.Drawing.Point(4, 24);
            this.tabPageSerialPort.Name = "tabPageSerialPort";
            this.tabPageSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialPort.Size = new System.Drawing.Size(370, 203);
            this.tabPageSerialPort.TabIndex = 0;
            this.tabPageSerialPort.Text = "SerialPort";
            this.tabPageSerialPort.UseVisualStyleBackColor = true;
            // 
            // tabPageStruct
            // 
            this.tabPageStruct.Controls.Add(this.structControl1);
            this.tabPageStruct.Location = new System.Drawing.Point(4, 24);
            this.tabPageStruct.Name = "tabPageStruct";
            this.tabPageStruct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStruct.Size = new System.Drawing.Size(370, 203);
            this.tabPageStruct.TabIndex = 1;
            this.tabPageStruct.Text = "Structure";
            this.tabPageStruct.UseVisualStyleBackColor = true;
            // 
            // structControl1
            // 
            this.structControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structControl1.Location = new System.Drawing.Point(3, 3);
            this.structControl1.Name = "structControl1";
            this.structControl1.Size = new System.Drawing.Size(364, 197);
            this.structControl1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(384, 25);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 21);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemSave.Text = "Save";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.FileName = "Observer.json";
            this.openFileDialog.Filter = "Observer.json|Observer.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.FileName = "Observer.json";
            this.saveFileDialog.Filter = "Observer.json|Observer.json";
            // 
            // serialPortControl1
            // 
            this.serialPortControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialPortControl1.Location = new System.Drawing.Point(3, 3);
            this.serialPortControl1.Name = "serialPortControl1";
            this.serialPortControl1.Size = new System.Drawing.Size(364, 197);
            this.serialPortControl1.TabIndex = 0;
            // 
            // ConfiguratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayout);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ConfiguratorForm";
            this.Text = "Form1";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageSerialPort.ResumeLayout(false);
            this.tabPageStruct.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSerialPort;
        private System.Windows.Forms.TabPage tabPageStruct;
        private StructControl structControl1;
        private SerialPortControl serialPortControl1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

