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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String LoginUser = textBox1.Text;
            String PasswordUser = textBox2.Text;

            database db = new database();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login` = @LoginUserlock AND `password` = @PasswordUserlock", db.GetConnection());
            command.Parameters.Add("@LoginUserlock", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@PasswordUserlock", MySqlDbType.VarChar).Value = PasswordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count>0)
            {
                MessageBox.Show("заебумба");
            }
            else
            {
                MessageBox.Show("не заебумба");
            }
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register registerform = new register();
            registerform.Show();
        }
    }
}
