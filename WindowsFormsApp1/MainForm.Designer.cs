
namespace MIDMaker
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_FormName = new System.Windows.Forms.Label();
            this.label_Save = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_KDMID = new System.Windows.Forms.TextBox();
            this.label_BusyPackets = new System.Windows.Forms.Label();
            this.textBox_PacketCount = new System.Windows.Forms.TextBox();
            this.label_TotalPackages = new System.Windows.Forms.Label();
            this.label_BIOS = new System.Windows.Forms.Label();
            this.button_OpenBIOS = new System.Windows.Forms.Button();
            this.textBox_BIOS = new System.Windows.Forms.TextBox();
            this.label_BVR = new System.Windows.Forms.Label();
            this.button_OpenBVR = new System.Windows.Forms.Button();
            this.textBox_BVR = new System.Windows.Forms.TextBox();
            this.textBox_MFR = new System.Windows.Forms.TextBox();
            this.button_OpenMFR = new System.Windows.Forms.Button();
            this.label_MFR = new System.Windows.Forms.Label();
            this.checkBox_BIOS = new System.Windows.Forms.CheckBox();
            this.checkBox_BVR = new System.Windows.Forms.CheckBox();
            this.checkBox_MFR = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EmptyPackets = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_FormName
            // 
            this.label_FormName.AutoSize = true;
            this.label_FormName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FormName.Location = new System.Drawing.Point(345, 11);
            this.label_FormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FormName.Name = "label_FormName";
            this.label_FormName.Size = new System.Drawing.Size(65, 22);
            this.label_FormName.TabIndex = 0;
            this.label_FormName.Text = "КДМИД";
            // 
            // label_Save
            // 
            this.label_Save.AutoSize = true;
            this.label_Save.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Save.Location = new System.Drawing.Point(16, 40);
            this.label_Save.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Save.Name = "label_Save";
            this.label_Save.Size = new System.Drawing.Size(108, 18);
            this.label_Save.TabIndex = 1;
            this.label_Save.Text = "Файл КДМИД";
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(190, 38);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(120, 30);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_KDMID
            // 
            this.textBox_KDMID.Location = new System.Drawing.Point(318, 41);
            this.textBox_KDMID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KDMID.Name = "textBox_KDMID";
            this.textBox_KDMID.ReadOnly = true;
            this.textBox_KDMID.Size = new System.Drawing.Size(235, 22);
            this.textBox_KDMID.TabIndex = 3;
            // 
            // label_BusyPackets
            // 
            this.label_BusyPackets.AutoSize = true;
            this.label_BusyPackets.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BusyPackets.Location = new System.Drawing.Point(16, 82);
            this.label_BusyPackets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BusyPackets.Name = "label_BusyPackets";
            this.label_BusyPackets.Size = new System.Drawing.Size(148, 18);
            this.label_BusyPackets.TabIndex = 4;
            this.label_BusyPackets.Text = "Занято пакетов";
            // 
            // textBox_PacketCount
            // 
            this.textBox_PacketCount.Location = new System.Drawing.Point(193, 80);
            this.textBox_PacketCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PacketCount.Name = "textBox_PacketCount";
            this.textBox_PacketCount.ReadOnly = true;
            this.textBox_PacketCount.Size = new System.Drawing.Size(28, 22);
            this.textBox_PacketCount.TabIndex = 5;
            this.textBox_PacketCount.Text = "0";
            this.textBox_PacketCount.TextChanged += new System.EventHandler(this.textBox_PacketCount_TextChanged);
            // 
            // label_TotalPackages
            // 
            this.label_TotalPackages.AutoSize = true;
            this.label_TotalPackages.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalPackages.Location = new System.Drawing.Point(223, 82);
            this.label_TotalPackages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalPackages.Name = "label_TotalPackages";
            this.label_TotalPackages.Size = new System.Drawing.Size(138, 18);
            this.label_TotalPackages.TabIndex = 6;
            this.label_TotalPackages.Text = "из 16 пакетов";
            // 
            // label_BIOS
            // 
            this.label_BIOS.AutoSize = true;
            this.label_BIOS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BIOS.Location = new System.Drawing.Point(16, 124);
            this.label_BIOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BIOS.Name = "label_BIOS";
            this.label_BIOS.Size = new System.Drawing.Size(138, 18);
            this.label_BIOS.TabIndex = 7;
            this.label_BIOS.Text = "Файл МИД БИОС";
            // 
            // button_OpenBIOS
            // 
            this.button_OpenBIOS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OpenBIOS.Location = new System.Drawing.Point(190, 119);
            this.button_OpenBIOS.Margin = new System.Windows.Forms.Padding(4);
            this.button_OpenBIOS.Name = "button_OpenBIOS";
            this.button_OpenBIOS.Size = new System.Drawing.Size(120, 30);
            this.button_OpenBIOS.TabIndex = 8;
            this.button_OpenBIOS.Text = "Открыть";
            this.button_OpenBIOS.UseVisualStyleBackColor = true;
            this.button_OpenBIOS.Click += new System.EventHandler(this.button_OpenBIOS_Click);
            // 
            // textBox_BIOS
            // 
            this.textBox_BIOS.Location = new System.Drawing.Point(319, 122);
            this.textBox_BIOS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BIOS.Name = "textBox_BIOS";
            this.textBox_BIOS.ReadOnly = true;
            this.textBox_BIOS.Size = new System.Drawing.Size(234, 22);
            this.textBox_BIOS.TabIndex = 9;
            this.textBox_BIOS.TextChanged += new System.EventHandler(this.textBox_BIOS_TextChanged);
            // 
            // label_BVR
            // 
            this.label_BVR.AutoSize = true;
            this.label_BVR.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BVR.Location = new System.Drawing.Point(16, 162);
            this.label_BVR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BVR.Name = "label_BVR";
            this.label_BVR.Size = new System.Drawing.Size(128, 18);
            this.label_BVR.TabIndex = 10;
            this.label_BVR.Text = "Файл МИД БВР";
            // 
            // button_OpenBVR
            // 
            this.button_OpenBVR.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OpenBVR.Location = new System.Drawing.Point(190, 157);
            this.button_OpenBVR.Margin = new System.Windows.Forms.Padding(4);
            this.button_OpenBVR.Name = "button_OpenBVR";
            this.button_OpenBVR.Size = new System.Drawing.Size(120, 30);
            this.button_OpenBVR.TabIndex = 11;
            this.button_OpenBVR.Text = "Открыть";
            this.button_OpenBVR.UseVisualStyleBackColor = true;
            this.button_OpenBVR.Click += new System.EventHandler(this.button_OpenBVR_Click);
            // 
            // textBox_BVR
            // 
            this.textBox_BVR.Location = new System.Drawing.Point(319, 160);
            this.textBox_BVR.Name = "textBox_BVR";
            this.textBox_BVR.ReadOnly = true;
            this.textBox_BVR.Size = new System.Drawing.Size(234, 22);
            this.textBox_BVR.TabIndex = 12;
            this.textBox_BVR.TextChanged += new System.EventHandler(this.textBox_BVR_TextChanged);
            // 
            // textBox_MFR
            // 
            this.textBox_MFR.Location = new System.Drawing.Point(319, 198);
            this.textBox_MFR.Name = "textBox_MFR";
            this.textBox_MFR.ReadOnly = true;
            this.textBox_MFR.Size = new System.Drawing.Size(234, 22);
            this.textBox_MFR.TabIndex = 13;
            this.textBox_MFR.TextChanged += new System.EventHandler(this.textBox_MFR_TextChanged);
            // 
            // button_OpenMFR
            // 
            this.button_OpenMFR.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OpenMFR.Location = new System.Drawing.Point(190, 195);
            this.button_OpenMFR.Margin = new System.Windows.Forms.Padding(4);
            this.button_OpenMFR.Name = "button_OpenMFR";
            this.button_OpenMFR.Size = new System.Drawing.Size(120, 30);
            this.button_OpenMFR.TabIndex = 14;
            this.button_OpenMFR.Text = "Открыть";
            this.button_OpenMFR.UseVisualStyleBackColor = true;
            this.button_OpenMFR.Click += new System.EventHandler(this.button_OpenMFR_Click);
            // 
            // label_MFR
            // 
            this.label_MFR.AutoSize = true;
            this.label_MFR.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MFR.Location = new System.Drawing.Point(16, 200);
            this.label_MFR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MFR.Name = "label_MFR";
            this.label_MFR.Size = new System.Drawing.Size(128, 18);
            this.label_MFR.TabIndex = 15;
            this.label_MFR.Text = "Файл МИД МФР";
            // 
            // checkBox_BIOS
            // 
            this.checkBox_BIOS.AutoSize = true;
            this.checkBox_BIOS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_BIOS.Enabled = false;
            this.checkBox_BIOS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_BIOS.Location = new System.Drawing.Point(560, 122);
            this.checkBox_BIOS.Name = "checkBox_BIOS";
            this.checkBox_BIOS.Size = new System.Drawing.Size(167, 22);
            this.checkBox_BIOS.TabIndex = 19;
            this.checkBox_BIOS.Text = "Включить в МИД";
            this.checkBox_BIOS.UseVisualStyleBackColor = true;
            this.checkBox_BIOS.CheckedChanged += new System.EventHandler(this.checkBox_BIOS_CheckedChanged);
            // 
            // checkBox_BVR
            // 
            this.checkBox_BVR.AutoSize = true;
            this.checkBox_BVR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_BVR.Enabled = false;
            this.checkBox_BVR.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_BVR.Location = new System.Drawing.Point(560, 160);
            this.checkBox_BVR.Name = "checkBox_BVR";
            this.checkBox_BVR.Size = new System.Drawing.Size(167, 22);
            this.checkBox_BVR.TabIndex = 20;
            this.checkBox_BVR.Text = "Включить в МИД";
            this.checkBox_BVR.UseVisualStyleBackColor = true;
            this.checkBox_BVR.CheckedChanged += new System.EventHandler(this.checkBox_BVR_CheckedChanged);
            // 
            // checkBox_MFR
            // 
            this.checkBox_MFR.AutoSize = true;
            this.checkBox_MFR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_MFR.Enabled = false;
            this.checkBox_MFR.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_MFR.Location = new System.Drawing.Point(560, 198);
            this.checkBox_MFR.Name = "checkBox_MFR";
            this.checkBox_MFR.Size = new System.Drawing.Size(167, 22);
            this.checkBox_MFR.TabIndex = 21;
            this.checkBox_MFR.Text = "Включить в МИД";
            this.checkBox_MFR.UseVisualStyleBackColor = true;
            this.checkBox_MFR.CheckedChanged += new System.EventHandler(this.checkBox_MFR_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пустых";
            // 
            // textBox_EmptyPackets
            // 
            this.textBox_EmptyPackets.Location = new System.Drawing.Point(465, 80);
            this.textBox_EmptyPackets.Name = "textBox_EmptyPackets";
            this.textBox_EmptyPackets.ReadOnly = true;
            this.textBox_EmptyPackets.Size = new System.Drawing.Size(28, 22);
            this.textBox_EmptyPackets.TabIndex = 23;
            this.textBox_EmptyPackets.Text = "0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 241);
            this.Controls.Add(this.textBox_EmptyPackets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_MFR);
            this.Controls.Add(this.checkBox_BVR);
            this.Controls.Add(this.checkBox_BIOS);
            this.Controls.Add(this.label_MFR);
            this.Controls.Add(this.button_OpenMFR);
            this.Controls.Add(this.textBox_MFR);
            this.Controls.Add(this.textBox_BVR);
            this.Controls.Add(this.button_OpenBVR);
            this.Controls.Add(this.label_BVR);
            this.Controls.Add(this.textBox_BIOS);
            this.Controls.Add(this.button_OpenBIOS);
            this.Controls.Add(this.label_BIOS);
            this.Controls.Add(this.label_TotalPackages);
            this.Controls.Add(this.textBox_PacketCount);
            this.Controls.Add(this.label_BusyPackets);
            this.Controls.Add(this.textBox_KDMID);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Save);
            this.Controls.Add(this.label_FormName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "КДМИД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FormName;
        private System.Windows.Forms.Label label_Save;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_KDMID;
        private System.Windows.Forms.Label label_BusyPackets;
        private System.Windows.Forms.TextBox textBox_PacketCount;
        private System.Windows.Forms.Label label_TotalPackages;
        private System.Windows.Forms.Label label_BIOS;
        private System.Windows.Forms.Button button_OpenBIOS;
        private System.Windows.Forms.TextBox textBox_BIOS;
        private System.Windows.Forms.Label label_BVR;
        private System.Windows.Forms.Button button_OpenBVR;
        private System.Windows.Forms.TextBox textBox_BVR;
        private System.Windows.Forms.TextBox textBox_MFR;
        private System.Windows.Forms.Button button_OpenMFR;
        private System.Windows.Forms.Label label_MFR;
        private System.Windows.Forms.CheckBox checkBox_BIOS;
        private System.Windows.Forms.CheckBox checkBox_BVR;
        private System.Windows.Forms.CheckBox checkBox_MFR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EmptyPackets;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

