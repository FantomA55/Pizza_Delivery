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

namespace Pizza_delivery
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
            loginField.Text = "Введите имя:";
            loginField.ForeColor = Color.Gray;

        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text =="Введите имя:")
            {
                loginField.Text = ""; 
                loginField.ForeColor = Color.Black;
            }
            
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите имя:";
                loginField.ForeColor = Color.Gray;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isUserExists())
                return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customer` (`name`, `password`) VALUES (@name, @password)", db.GetConnection());


            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт успешно создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `name`=@uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
