namespace TestTask
{
    partial class Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel_Modes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UsTipModes = new System.Windows.Forms.TextBox();
            this.textBox_NameModes = new System.Windows.Forms.TextBox();
            this.textBox_IdModes = new System.Windows.Forms.TextBox();
            this.textBox_BotNumMdes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panel_Modes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 67);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(800, 278);
            this.dataGridViewMain.TabIndex = 1;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            // 
            // button_Clear
            // 
            this.button_Clear.AutoSize = true;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(444, 21);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(81, 27);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.AutoSize = true;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Refresh.Location = new System.Drawing.Point(531, 21);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(82, 27);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Обновить";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(619, 21);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(169, 27);
            this.textBox_Search.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Запись:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(0, 27);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(140, 21);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // panel_Modes
            // 
            this.panel_Modes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Modes.Controls.Add(this.textBox_BotNumMdes);
            this.panel_Modes.Controls.Add(this.textBox_UsTipModes);
            this.panel_Modes.Controls.Add(this.textBox_NameModes);
            this.panel_Modes.Controls.Add(this.textBox_IdModes);
            this.panel_Modes.Controls.Add(this.label3);
            this.panel_Modes.Controls.Add(this.label4);
            this.panel_Modes.Controls.Add(this.label5);
            this.panel_Modes.Controls.Add(this.label1);
            this.panel_Modes.Controls.Add(this.label2);
            this.panel_Modes.Location = new System.Drawing.Point(12, 377);
            this.panel_Modes.Name = "panel_Modes";
            this.panel_Modes.Size = new System.Drawing.Size(474, 228);
            this.panel_Modes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Used Tips:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Bottle Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // textBox_UsTipModes
            // 
            this.textBox_UsTipModes.Location = new System.Drawing.Point(157, 127);
            this.textBox_UsTipModes.Name = "textBox_UsTipModes";
            this.textBox_UsTipModes.Size = new System.Drawing.Size(250, 20);
            this.textBox_UsTipModes.TabIndex = 9;
            // 
            // textBox_NameModes
            // 
            this.textBox_NameModes.Location = new System.Drawing.Point(157, 67);
            this.textBox_NameModes.Name = "textBox_NameModes";
            this.textBox_NameModes.Size = new System.Drawing.Size(250, 20);
            this.textBox_NameModes.TabIndex = 10;
            // 
            // textBox_IdModes
            // 
            this.textBox_IdModes.Location = new System.Drawing.Point(157, 38);
            this.textBox_IdModes.Name = "textBox_IdModes";
            this.textBox_IdModes.Size = new System.Drawing.Size(250, 20);
            this.textBox_IdModes.TabIndex = 11;
            // 
            // textBox_BotNumMdes
            // 
            this.textBox_BotNumMdes.Location = new System.Drawing.Point(157, 97);
            this.textBox_BotNumMdes.Name = "textBox_BotNumMdes";
            this.textBox_BotNumMdes.Size = new System.Drawing.Size(250, 20);
            this.textBox_BotNumMdes.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(531, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 228);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Управление записями:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(52, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Новая запись";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(52, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(52, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(52, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Modes);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "Работа с БД";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panel_Modes.ResumeLayout(false);
            this.panel_Modes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Panel panel_Modes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BotNumMdes;
        private System.Windows.Forms.TextBox textBox_UsTipModes;
        private System.Windows.Forms.TextBox textBox_NameModes;
        private System.Windows.Forms.TextBox textBox_IdModes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

