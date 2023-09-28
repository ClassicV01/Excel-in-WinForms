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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void CreateColumsForModes()
        {
            dataGridViewMain.Columns.Add("Id", "Id");
            dataGridViewMain.Columns.Add("Name", "Name");
            dataGridViewMain.Columns.Add("MaxBottleNumber", "Max Bottle Number");
            dataGridViewMain.Columns.Add("MaxUsedTips", "Max Used Tips");
            dataGridViewMain.Columns.Add("IsNew", string.Empty);
        }

        public void CreateColumsForSteps()
        {
            dataGridViewMain.Columns.Add("Id", "Id");
            dataGridViewMain.Columns.Add("ModeId", "Mode Id");
            dataGridViewMain.Columns.Add("Timer", "Timer");
            dataGridViewMain.Columns.Add("Destination", "Destination");
            dataGridViewMain.Columns.Add("Speed", "Speed");
            dataGridViewMain.Columns.Add("Type", "Type");
            dataGridViewMain.Columns.Add("Volume", "Volume");
            dataGridViewMain.Columns.Add("IsNew", string.Empty);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dataGridViewMain.Columns.Clear();
            CreateColumsForModes();
            db.RefreshDataGridView(dataGridViewMain, 0);
            comboBox.Items.Insert(0, "Modes");
            comboBox.Items.Insert(1, "Steps");
            comboBox.SelectedIndex = 0;
        }

        public void ReadSingleRowModes(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);
        }

        public void ReadSingleRowSteps(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), (record.GetValue(3) == DBNull.Value) ? string.Empty : record.GetString(3),
                record.GetInt32(4), record.GetString(5), record.GetInt32(6), RowState.ModifiedNew);
        }

        private DataBase db = new DataBase();
        private int selectedRow;
        enum RowState
        {
            Existed,
            New,
            Deleted,
            Modified,
            ModifiedNew
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox.SelectedIndex)
            {
                case 0:
                    dataGridViewMain.Columns.Clear();
                    CreateColumsForModes();
                    break;

                case 1:
                    dataGridViewMain.Columns.Clear();
                    CreateColumsForSteps();
                    break;
            }    

            db.RefreshDataGridView(dataGridViewMain, comboBox.SelectedIndex);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            panel_Modes.Visible = false;

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    dataGridViewMain.Columns.Clear();
                    CreateColumsForModes();
                    break;

                case 1:
                    dataGridViewMain.Columns.Clear();
                    CreateColumsForSteps();
                    break;
            }

            db.RefreshDataGridView(dataGridViewMain, comboBox.SelectedIndex);
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(selectedRow >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[selectedRow];

                textBox_IdModes.Text = row.Cells[0].Value.ToString();
                textBox_NameModes.Text = row.Cells[1].Value.ToString();
                textBox_BotNumMdes.Text = row.Cells[2].Value.ToString();
                textBox_UsTipModes.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
