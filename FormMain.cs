using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;

namespace TestTask
{
    public partial class FormMain : System.Windows.Forms.Form
    {

        private DataBase db = new DataBase();
        private int selectedRow;
        string filename;
        enum RowState
        {
            Deleted,
            Modified,
            ModifiedNew
        }

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
            dataGridViewMain.Columns[4].Visible = false;
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
            dataGridViewMain.Columns[7].Visible = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dataGridViewMain.Columns.Clear();
            CreateColumsForModes();
            db.RefreshDataGridView(dataGridViewMain, 0);
            comboBox.Items.Insert(0, "Modes");
            comboBox.Items.Insert(1, "Steps");
            comboBox.SelectedIndex = 0;
            panel_Steps.Visible = false;
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    dataGridViewMain.Columns.Clear();
                    CreateColumsForModes();
                    panel_Modes.Visible = true;
                    panel_Steps.Visible = false;
                    break;

                case 1:
                    dataGridViewMain.Columns.Clear();
                    CreateColumsForSteps();
                    panel_Modes.Visible = false;
                    panel_Steps.Visible = true;
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
            textBox_IdSteps.Text = "";
            textBox_ModeId.Text = "";
            textBox_Timer.Text = "";
            textBox_Dest.Text = "";
            textBox_Speed.Text = "";
            textBox_Type.Text = "";
            textBox_Vol.Text = "";
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
                switch(comboBox.SelectedIndex)
                {
                    case 0:
                        {
                            DataGridViewRow row = dataGridViewMain.Rows[selectedRow];
                            textBox_IdModes.Text = row.Cells[0].Value.ToString();
                            textBox_NameModes.Text = row.Cells[1].Value.ToString();
                            textBox_BotNumMdes.Text = row.Cells[2].Value.ToString();
                            textBox_UsTipModes.Text = row.Cells[3].Value.ToString();
                        }
                        break;

                    case 1:
                        {
                            DataGridViewRow row = dataGridViewMain.Rows[selectedRow];
                            textBox_IdSteps.Text = row.Cells[0].Value.ToString();
                            textBox_ModeId.Text = row.Cells[1].Value.ToString();
                            textBox_Timer.Text = row.Cells[2].Value.ToString();
                            textBox_Dest.Text = row.Cells[3].Value.ToString();
                            textBox_Speed.Text = row.Cells[4].Value.ToString();
                            textBox_Type.Text = row.Cells[5].Value.ToString();
                            textBox_Vol.Text = row.Cells[6].Value.ToString();
                        }
                        break;
                }

                

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

            switch(comboBox.SelectedIndex)
            {
                case 0:
                    if (dataGridViewMain.Rows[index].Cells[0].Value.ToString() == string.Empty)
                    {
                        dataGridViewMain.Rows[index].Cells[4].Value = RowState.Deleted;
                        return;
                    }

                    dataGridViewMain.Rows[index].Cells[4].Value = RowState.Deleted;
                    break;

                case 1:
                    if (dataGridViewMain.Rows[index].Cells[0].Value.ToString() == string.Empty)
                    {
                        dataGridViewMain.Rows[index].Cells[7].Value = RowState.Deleted;
                        return;
                    }

                    dataGridViewMain.Rows[index].Cells[7].Value = RowState.Deleted;
                    break;
            }            
        }

        private void UpdateRec()
        {
            for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
            {
                switch(comboBox.SelectedIndex)
                {
                    case 0:
                        {
                            var rowstate = (RowState)dataGridViewMain.Rows[i].Cells[4].Value;

                            if (rowstate == RowState.Deleted)
                            {
                                var id = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[0].Value);

                                db.DeleteRecord(id, comboBox.SelectedIndex);
                            }

                            if (rowstate == RowState.Modified)
                            {
                                var id = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[0].Value);
                                var name = dataGridViewMain.Rows[i].Cells[1].Value.ToString();
                                var bottle = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[2].Value);
                                var tips = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[3].Value);

                                db.UpdateRecordsModes(id, name, bottle, tips);
                            }
                        }
                        break;

                    case 1:
                        {
                            var rowstate = (RowState)dataGridViewMain.Rows[i].Cells[7].Value;

                            if (rowstate == RowState.Deleted)
                            {
                                var id = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[0].Value);

                                db.DeleteRecord(id, comboBox.SelectedIndex);
                            }

                            if (rowstate == RowState.Modified)
                            {
                                var id = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[0].Value);
                                var modeId = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[1].Value);
                                var timer = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[2].Value);
                                var dest = dataGridViewMain.Rows[i].Cells[3].Value.ToString();
                                var speed = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[4].Value);
                                var type = dataGridViewMain.Rows[i].Cells[5].Value.ToString();
                                var vol = Convert.ToInt32(dataGridViewMain.Rows[i].Cells[6].Value);

                                db.UpdateRecordsSteps(id, modeId, timer, dest, speed, type, vol);
                            }
                        }
                        break;
                }

                
            }
        }

        private void button_NewRec_Click(object sender, EventArgs e)
        {
            switch(comboBox.SelectedIndex)
            {
                case 0:
                    RecModes recModes = new RecModes();
                    recModes.Show();
                    break;

                case 1:
                    RecSteps recSteps = new RecSteps();
                    recSteps.Show();
                    break;
            }
            
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

            switch(comboBox.SelectedIndex)
            {
                case 0:
                    {
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
                                MessageBox.Show("Неверный формат данных Max Used Tips!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if(name == string.Empty)
                            {
                                MessageBox.Show("Неверный формат данных Name!", "Неверный формат!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }    

                            dataGridViewMain.Rows[selectedRowIndex].SetValues(id, name, botM, tipM);
                            dataGridViewMain.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                        }
                    }
                    break;

                case 1:
                    {
                        var id = textBox_IdSteps.Text;
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
                        dataGridViewMain.Rows[selectedRowIndex].SetValues(id, modeIdN, timerN, dest, speedN, type, volN);
                        dataGridViewMain.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                    }
                    break;
            }

            

        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog_Excel.ShowDialog();

                if(res == DialogResult.OK)
                {
                    filename = openFileDialog_Excel.FileName;

                    Workbook wb = new Workbook(filename);
                    foreach(var ws in wb.Worksheets)
                    {
                        int rows = ws.Cells.MaxDataRow + 1;
                        int columns = ws.Cells.MaxDataColumn + 1;

                        if (!db.AddDataFromExcel(rows, columns, ws))
                        {
                            throw new Exception("Неверный формат файла Excel!");
                        }
                    }
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
