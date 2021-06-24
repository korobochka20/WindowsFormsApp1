using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            name1.Text="Имя";
            name2.Text = "Фамилия";
            log1.Text = "Логин";
            passw1.Text = "Пароль";
            passw2.Text = "Подтверждение пароля";

            name1.ForeColor = Color.LightGray;
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void name1_Enter(object sender, EventArgs e)
        {
            if(name1.Text == "Имя")
            name1.Text = "";

            name1.ForeColor = Color.Black;
        }

        private void name1_Leave(object sender, EventArgs e)
        {
            if (name1.Text == "")
                name1.Text = "Имя";

                name1.ForeColor = Color.LightGray ;
        }

        private void name2_Enter(object sender, EventArgs e)
        {
            if (name2.Text == "Фамилия")
                name2.Text = "";

            name2.ForeColor = Color.Black;
        }

        private void name2_Leave(object sender, EventArgs e)
        {
            if (name2.Text == "")
                name2.Text = "Фамилия";

            name2.ForeColor = Color.LightGray;
        }

        private void log1_Enter(object sender, EventArgs e)
        {
            if (log1.Text == "Логин")
                log1.Text = "";

            log1.ForeColor = Color.Black;
        }

        private void log1_Leave(object sender, EventArgs e)
        {
            if (log1.Text == "")
                log1.Text = "Логин";

            log1.ForeColor = Color.LightGray;
        }

        private void passw1_Enter(object sender, EventArgs e)
        {
            if (passw1.Text == "Пароль")
                passw1.Text = "";

            passw1.ForeColor = Color.Black;
        }

        private void passw1_Leave(object sender, EventArgs e)
        {
            if (passw1.Text == "")
                passw1.Text = "Пароль";

            passw1.ForeColor = Color.LightGray;
        }

        private void passw2_Enter(object sender, EventArgs e)
        {
            if (passw2.Text == "Подтверждение пароля")
                passw2.Text = "";

            passw2.ForeColor = Color.Black;
        }

        private void passw2_Leave(object sender, EventArgs e)
        {
            if (passw2.Text == "")
                passw2.Text = "Подтверждение пароля";

            passw2.ForeColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((name1.Text == "Имя") || (name2.Text == "Фамилия") || (log1.Text == "Логин") || (passw1.Text == "Пароль") || (passw2.Text == "Подтверждение пароля"))
            {
                return;
            }
            if (check())
                return;

            database db = new database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Users` (`Name`, `Surname`, `login`, `password`, `flag`) VALUES (@name_value, @surname_value, @login_value, @password_value, @flag_value)", db.GetConnection());
            if (passw1.Text == passw2.Text)
            {
                command.Parameters.Add("@name_value", MySqlDbType.VarChar).Value = name1.Text;
                command.Parameters.Add("@surname_value", MySqlDbType.VarChar).Value = name2.Text;
                command.Parameters.Add("@login_value", MySqlDbType.VarChar).Value = log1.Text;
                command.Parameters.Add("@password_value", MySqlDbType.VarChar).Value = passw2.Text;
                command.Parameters.Add("@flag_value", MySqlDbType.VarChar).Value = 1;

                db.openc();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!");

                    database db1 = new database();
                    MessageBox.Show(log1.Text);
                    int IDoo = db.USER_ID(log1.Text);
                    MySqlCommand command1 = new MySqlCommand("INSERT INTO `Users_Info` (`Users_id`, `secname`, `age`, `about_me`, `gender`,`city`) VALUES (@Users_id_value, @secname_value, @age_value, @about_me_value, @gender_value, @city_value)", db1.GetConnection());

                    string empty = null;

                    command1.Parameters.Add("@Users_id_value", MySqlDbType.VarChar).Value = IDoo;
                    command1.Parameters.Add("@secname_value", MySqlDbType.VarChar).Value = empty;
                    command1.Parameters.Add("@age_value", MySqlDbType.VarChar).Value = empty;
                    command1.Parameters.Add("@about_me_value", MySqlDbType.VarChar).Value = empty;
                    command1.Parameters.Add("@gender_value", MySqlDbType.VarChar).Value = empty;
                    command1.Parameters.Add("@city_value", MySqlDbType.VarChar).Value = empty;


                    db1.openc();
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Атлишна");
                    }



                }

                else
                    MessageBox.Show("неа");

                db.closec();
            }
            else
                MessageBox.Show("Не совпали пароли, дура");
             
        }
        public Boolean check()
        {
            database db = new database();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login` = @LoginUserlock ", db.GetConnection());
            command.Parameters.Add("@LoginUserlock", MySqlDbType.VarChar).Value = name1.Text;

            db.openc();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин занят!");
                return true;
            }
            else
            {
                return false;
                MessageBox.Show("не заебумба");
            }
        }

    }
}
