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
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
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

        private void ClearFields()
        {
            textBox_IdModes.Text = "";
            textBox_NameModes.Text = "";
            textBox_BotNumMdes.Text = "";
            textBox_UsTipModes.Text = "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
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
            ClearFields();
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[selectedRow];

                textBox_IdModes.Text = row.Cells[0].Value.ToString();
                textBox_NameModes.Text = row.Cells[1].Value.ToString();
                textBox_BotNumMdes.Text = row.Cells[2].Value.ToString();
                textBox_UsTipModes.Text = row.Cells[3].Value.ToString();

            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            db.Search(dataGridViewMain, textBox_Search.Text, comboBox.SelectedIndex);
        }

        private void DeleteRow()
        {
            int index = dataGridViewMain.CurrentCell.RowIndex;

            dataGridViewMain.Rows[index].Visible = false;
            //TODO Think about
            if (dataGridViewMain.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewMain.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dataGridViewMain.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void UpdateRec()
        {
            for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
            {
                var rowstate = (RowState)dataGridViewMain.Rows[i].Cells[4].Value;

                if(rowstate == RowState.Existed)
                {
                    continue;
                }

                if (rowstate == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[0].Value);

                    db.DeleteRecord(id, comboBox.SelectedIndex);
                }

                if(rowstate == RowState.Modified)
                {
                    var id = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[0].Value);
                    var name = dataGridViewMain.Rows[i].Cells[1].Value.ToString();
                    var bottle = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[2].Value);
                    var tips = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[3].Value);

                    db.UpdateRecords(id, name, bottle, tips);
                }
            }
        }

        private void button_NewRec_Click(object sender, EventArgs e)
        {
            RecModes recModes = new RecModes();
            recModes.Show();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            UpdateRec();
            ClearFields();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewMain.CurrentCell.RowIndex;

            var id = textBox_IdModes.Text;
            var name = textBox_NameModes.Text;
            var bottle = textBox_BotNumMdes.Text;
            var tips = textBox_UsTipModes.Text;
            int botM;
            int tipM;

            if (dataGridViewMain.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (!int.TryParse(bottle, out botM))
                {
                    MessageBox.Show("Неверный формат данных Max Bottle Number!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(tips, out tipM))
                {
                    MessageBox.Show("Неверный формат данных Max Bottle Number!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridViewMain.Rows[selectedRowIndex].SetValues(id, name, botM, tipM);
                dataGridViewMain.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
            }

        }
    }
}
