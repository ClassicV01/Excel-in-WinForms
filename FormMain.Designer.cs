namespace TestTask
{
    partial class FormMain
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
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel_Modes = new System.Windows.Forms.Panel();
            this.textBox_BotNumMdes = new System.Windows.Forms.TextBox();
            this.textBox_UsTipModes = new System.Windows.Forms.TextBox();
            this.textBox_NameModes = new System.Windows.Forms.TextBox();
            this.textBox_IdModes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_NewRec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog_Excel = new System.Windows.Forms.OpenFileDialog();
            this.panel_Steps = new System.Windows.Forms.Panel();
            this.textBox_Timer = new System.Windows.Forms.TextBox();
            this.textBox_Dest = new System.Windows.Forms.TextBox();
            this.textBox_ModeId = new System.Windows.Forms.TextBox();
            this.textBox_IdSteps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Vol = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panel_Modes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Steps.SuspendLayout();
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
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 67);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
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
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
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
            // textBox_BotNumMdes
            // 
            this.textBox_BotNumMdes.Location = new System.Drawing.Point(157, 97);
            this.textBox_BotNumMdes.Name = "textBox_BotNumMdes";
            this.textBox_BotNumMdes.Size = new System.Drawing.Size(250, 20);
            this.textBox_BotNumMdes.TabIndex = 8;
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
            this.textBox_IdModes.ReadOnly = true;
            this.textBox_IdModes.Size = new System.Drawing.Size(250, 20);
            this.textBox_IdModes.TabIndex = 11;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Change);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_NewRec);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(531, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 228);
            this.panel1.TabIndex = 8;
            // 
            // button_Save
            // 
            this.button_Save.AutoSize = true;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(52, 163);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(123, 30);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Change
            // 
            this.button_Change.AutoSize = true;
            this.button_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Change.Location = new System.Drawing.Point(52, 127);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(123, 30);
            this.button_Change.TabIndex = 3;
            this.button_Change.Text = "Изменить";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.AutoSize = true;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.Location = new System.Drawing.Point(52, 91);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(123, 30);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_NewRec
            // 
            this.button_NewRec.AutoSize = true;
            this.button_NewRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NewRec.Location = new System.Drawing.Point(52, 52);
            this.button_NewRec.Name = "button_NewRec";
            this.button_NewRec.Size = new System.Drawing.Size(123, 33);
            this.button_NewRec.TabIndex = 1;
            this.button_NewRec.Text = "Новая запись";
            this.button_NewRec.UseVisualStyleBackColor = true;
            this.button_NewRec.Click += new System.EventHandler(this.button_NewRec_Click);
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
            // openFileDialog_Excel
            // 
            this.openFileDialog_Excel.FileName = "openFileDialog1";
            this.openFileDialog_Excel.Filter = "Excel|*.xlsx";
            // 
            // panel_Steps
            // 
            this.panel_Steps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Steps.Controls.Add(this.textBox_Vol);
            this.panel_Steps.Controls.Add(this.label14);
            this.panel_Steps.Controls.Add(this.textBox_Type);
            this.panel_Steps.Controls.Add(this.label13);
            this.panel_Steps.Controls.Add(this.textBox_Speed);
            this.panel_Steps.Controls.Add(this.label12);
            this.panel_Steps.Controls.Add(this.textBox_Timer);
            this.panel_Steps.Controls.Add(this.textBox_Dest);
            this.panel_Steps.Controls.Add(this.textBox_ModeId);
            this.panel_Steps.Controls.Add(this.textBox_IdSteps);
            this.panel_Steps.Controls.Add(this.label7);
            this.panel_Steps.Controls.Add(this.label8);
            this.panel_Steps.Controls.Add(this.label9);
            this.panel_Steps.Controls.Add(this.label10);
            this.panel_Steps.Controls.Add(this.label11);
            this.panel_Steps.Location = new System.Drawing.Point(12, 377);
            this.panel_Steps.Name = "panel_Steps";
            this.panel_Steps.Size = new System.Drawing.Size(474, 228);
            this.panel_Steps.TabIndex = 9;
            // 
            // textBox_Timer
            // 
            this.textBox_Timer.Location = new System.Drawing.Point(157, 97);
            this.textBox_Timer.Name = "textBox_Timer";
            this.textBox_Timer.Size = new System.Drawing.Size(250, 20);
            this.textBox_Timer.TabIndex = 8;
            // 
            // textBox_Dest
            // 
            this.textBox_Dest.Location = new System.Drawing.Point(157, 127);
            this.textBox_Dest.Name = "textBox_Dest";
            this.textBox_Dest.Size = new System.Drawing.Size(250, 20);
            this.textBox_Dest.TabIndex = 9;
            // 
            // textBox_ModeId
            // 
            this.textBox_ModeId.Location = new System.Drawing.Point(157, 67);
            this.textBox_ModeId.Name = "textBox_ModeId";
            this.textBox_ModeId.Size = new System.Drawing.Size(250, 20);
            this.textBox_ModeId.TabIndex = 10;
            // 
            // textBox_IdSteps
            // 
            this.textBox_IdSteps.Location = new System.Drawing.Point(157, 38);
            this.textBox_IdSteps.Name = "textBox_IdSteps";
            this.textBox_IdSteps.ReadOnly = true;
            this.textBox_IdSteps.Size = new System.Drawing.Size(250, 20);
            this.textBox_IdSteps.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(57, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destination:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(99, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Timer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(80, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mode Id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Запись:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(124, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Id:";
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.Location = new System.Drawing.Point(157, 153);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(250, 20);
            this.textBox_Speed.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(91, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Speed:";
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(157, 179);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(250, 20);
            this.textBox_Type.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(104, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Type:";
            // 
            // textBox_Vol
            // 
            this.textBox_Vol.Location = new System.Drawing.Point(157, 203);
            this.textBox_Vol.Name = "textBox_Vol";
            this.textBox_Vol.Size = new System.Drawing.Size(250, 20);
            this.textBox_Vol.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(84, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Volume:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.panel_Steps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Modes);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Работа с БД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panel_Modes.ResumeLayout(false);
            this.panel_Modes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Steps.ResumeLayout(false);
            this.panel_Steps.PerformLayout();
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
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_NewRec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Excel;
        private System.Windows.Forms.Panel panel_Steps;
        private System.Windows.Forms.TextBox textBox_Vol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Timer;
        private System.Windows.Forms.TextBox textBox_Dest;
        private System.Windows.Forms.TextBox textBox_ModeId;
        private System.Windows.Forms.TextBox textBox_IdSteps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

