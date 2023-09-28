using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class LogIn : System.Windows.Forms.Form
    {

        public LogIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Visible = false;
            pictureBoxOpen.Visible = true;
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Visible = true;
            pictureBoxOpen.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxOpen.Visible = false;
            textBoxPassword.MaxLength = 50;
            textBoxLogin.MaxLength = 50;
            db.CreateOpenDB();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if(db.CheckUser(login, password))
            {
                Form form = new Form();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя не найдено!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private DataBase db = new DataBase();

    }
}
