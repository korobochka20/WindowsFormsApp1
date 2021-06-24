using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class database
    {
        MySqlConnection connection = new MySqlConnection("server=95.104.192.212;port=3306;username=Liorkin;password=lostdox561771;database=Liorkin");
        public void openc()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closec()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public int USER_ID(string login)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT id FROM Users WHERE login = '{login}'";
            object value = command.ExecuteScalar();
            int ID = Convert.ToInt32(value);
            return ID;
        }
    }
}
