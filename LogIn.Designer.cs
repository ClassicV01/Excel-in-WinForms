namespace TestTask
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.linkLabel_SignUp = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(96, 68);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(203, 29);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(96, 103);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 29);
            this.textBoxPassword.TabIndex = 3;
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(147, 138);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 34);
            this.Enter.TabIndex = 4;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // linkLabel_SignUp
            // 
            this.linkLabel_SignUp.AutoSize = true;
            this.linkLabel_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_SignUp.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_SignUp.Location = new System.Drawing.Point(124, 175);
            this.linkLabel_SignUp.Name = "linkLabel_SignUp";
            this.linkLabel_SignUp.Size = new System.Drawing.Size(118, 17);
            this.linkLabel_SignUp.TabIndex = 8;
            this.linkLabel_SignUp.TabStop = true;
            this.linkLabel_SignUp.Text = "Создать аккаунт";
            this.linkLabel_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SignUp_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Авторизация";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = global::TestTask.Properties.Resources.Close;
            this.pictureBoxClose.InitialImage = null;
            this.pictureBoxClose.Location = new System.Drawing.Point(305, 102);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 7;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.WaitOnLoad = true;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOpen.Image = global::TestTask.Properties.Resources.Open;
            this.pictureBoxOpen.InitialImage = null;
            this.pictureBoxOpen.Location = new System.Drawing.Point(305, 102);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpen.TabIndex = 6;
            this.pictureBoxOpen.TabStop = false;
            this.pictureBoxOpen.WaitOnLoad = true;
            this.pictureBoxOpen.Click += new System.EventHandler(this.pictureBoxOpen_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(305, 23);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 27);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel_SignUp);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.LinkLabel linkLabel_SignUp;
        private System.Windows.Forms.Label label3;
    }
}