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
    public partial class RecModes : System.Windows.Forms.Form
    {
        DataBase db = new DataBase();
        public RecModes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            var name = textBox_Name.Text;
            var bot = textBox_Bottle.Text;
            var tip = textBox_Tips.Text;
            int botN;
            int tipN;
            if(!int.TryParse(bot, out botN))
            {
                MessageBox.Show("Неверный формат данных Max Bottle Number!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tip, out tipN))
            {
                MessageBox.Show("Неверный формат данных Max Used Tips!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(name == string.Empty)
            {
                MessageBox.Show("Неверный формат данных Name!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.AddNewRecordModes(name, botN, tipN);

            MessageBox.Show("Запись успешно добавлена!", "Запись добавлена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
    }
}
