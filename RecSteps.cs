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
    public partial class RecSteps : Form
    {
        DataBase db = new DataBase();

        public RecSteps()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            var modeId = textBox_ModeId.Text;
            var timer = textBox_Timer.Text;
            var dest = textBox_Dest.Text;
            var speed = textBox_Speed.Text;
            var type = textBox_Type.Text;
            var vol = textBox_Vol.Text;

            int timerN;
            int modeIdN;
            int speedN;
            int volN;
            if (!int.TryParse(modeId, out modeIdN))
            {
                MessageBox.Show("Неверный формат данных Mode Id!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(timer, out timerN))
            {
                MessageBox.Show("Неверный формат данных Timer!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(speed, out speedN))
            {
                MessageBox.Show("Неверный формат данных Speed!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(vol, out volN))
            {
                MessageBox.Show("Неверный формат данных Volume!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (type == string.Empty)
            {
                MessageBox.Show("Неверный формат данных Type!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.AddNewRecordSteps(modeIdN, timerN, dest, speedN, type, volN);

            MessageBox.Show("Запись успешно добавлена!", "Запись добавлена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
