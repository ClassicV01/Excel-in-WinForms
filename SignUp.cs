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
    public partial class SignUp : System.Windows.Forms.Form
    {
        public SignUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxOpen.Visible = false;
            textBoxPassword.MaxLength = 50;
            textBoxLogin.MaxLength = 50;
        }

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Visible = true;
            pictureBoxOpen.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Visible = false;
            pictureBoxOpen.Visible = true;
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            var pass = password.ToCharArray();
            if (login.Length == 0)
            {
                MessageBox.Show("Введите логин!", "Отсутствует логин!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length >= 6)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(pass[i]))
                    {
                        isDigit = true;
                    }
                    if (Char.IsLetter(pass[i]))
                    {
                        isLetter = true;
                    }
                }

                if (isDigit && isLetter)
                {
                    if (!db.AddUser(login, password))
                    {
                        MessageBox.Show("Логин не уникален, введите другой!", "Логин уже существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isDigit = false;
                        isLetter = false;
                        return;
                    }

                    MessageBox.Show("Пользователь успешно добавлен!", "Пользователь зарегестрирован!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LogIn logIn = new LogIn();
                    logIn.Show();


                }
                else
                {
                    MessageBox.Show("Пароль должен содержать хотя бы 1 цифру и 1 букву!", "Неверный формат пароля!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isDigit = false;
                    isLetter = false;
                }
            }
            else
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов!", "Короткий пароль!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private DataBase db = new DataBase();
        private bool isLetter = false;
        private bool isDigit = false;

    }
}
