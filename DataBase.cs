using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TestTask
{
    public class DataBase
    {
        public void CreateOpenDB()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = @"CREATE TABLE IF NOT EXISTS Users (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
                                                        Login TEXT NOT NULL UNIQUE, Password TEXT NOT NULL)";
                command.ExecuteNonQuery();

                command.CommandText = @"CREATE TABLE IF NOT EXISTS Modes (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
                                                        Name TEXT NOT NULL, MaxBottleNumber INTEGER NOT NULL, MaxUsedTips INTEGER NOT NULL)";
                command.ExecuteNonQuery();

                command.CommandText = @"CREATE TABLE IF NOT EXISTS Steps (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
                                                        ModeId INTEGER NOT NULL, Timer INTEGER NOT NULL, Destination TEXT, Speed INTEGER NOT NULL,
                                                        Type TEXT NOT NULL, Volume INTEGER NOT NULL, 
                                                        CONSTRAINT steps_modeid_fk 
                                                        FOREIGN KEY (ModeId)  REFERENCES Modes (id))";
                command.ExecuteNonQuery();
            }
        }

        public bool AddUser(string login, string password)
        {
            using (var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO Users (Login, Password) VALUES ('{login}', '{password}')";
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool CheckUser(string login, string password)
        {
            using (var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT * FROM Users WHERE Login = '{login}' and Password = '{password}'";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void RefreshDataGridView(DataGridView dgv, int sheet)
        {
            dgv.Rows.Clear();

            using (var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                string modesQuerry = $"SELECT * FROM Modes";
                string stepsQuerry = $"SELECT * FROM Steps";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                switch (sheet)
                {
                    case 0:
                        command.CommandText = modesQuerry;
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FormMain form = new FormMain();
                                form.ReadSingleRowModes(dgv, reader);
                            }
                        }
                        break;

                    case 1:
                        command.CommandText = stepsQuerry;
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FormMain form = new FormMain();
                                form.ReadSingleRowSteps(dgv, reader);
                            }
                        }
                        break;
                }


            }
        }

        public void AddNewRecord(string name, int maxBottleNumber, int maxUsedTips)
        {
            using (var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO Modes (Name, MaxBottleNumber, MaxUsedTips) VALUES ('{name}', {maxBottleNumber}, {maxUsedTips})";
                command.ExecuteNonQuery();
            }
        }

        public void Search(DataGridView dgv, string text, int sheet)
        {
            dgv.Rows.Clear();

            using(var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                string querryModes = $"SELECT * FROM Modes WHERE  (Id || Name || MaxBottleNumber || MaxUsedTips) LIKE '%" + text + "%'";
                string querrySteps = $"SELECT * FROM Steps WHERE  (Id || ModeId || Timer || Destination || Speed || Type || Volume) LIKE '%" + text + "%'";
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                switch (sheet)
                {
                    case 0:
                        command.CommandText = querryModes;
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FormMain formMain = new FormMain();
                                formMain.ReadSingleRowModes(dgv, reader);
                            }
                        }
                        break;

                     case 1:
                        command.CommandText = querrySteps;
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FormMain formMain = new FormMain();
                                formMain.ReadSingleRowSteps(dgv, reader);
                            }
                        }
                        break;
                }
            }

        }

        public void DeleteRecord(int id, int sheet)
        {
            using (var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                string querryModes = $"DELETE FROM Modes WHERE Id = {id}";
                string querrySteps = $"DELETE FROM Steps WHERE Id = {id}";
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                switch (sheet)
                {
                    case 0:
                        command.CommandText = querryModes;
                        command.ExecuteNonQuery();
                        break;

                    case 1:
                        command.CommandText = querrySteps;
                        command.ExecuteNonQuery();
                        break;
                }
            }
        }

        public void UpdateRecords(int id, string name, int bottle, int tips)
        {
            using (var connection = new SQLiteConnection("Data Source=mainDB.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"UPDATE Modes SET Name = '{name}', MaxBottleNumber = {bottle}, MaxUsedTips = {tips} WHERE Id = {id} ";
                command.ExecuteNonQuery();
            }
        }

    }
}
