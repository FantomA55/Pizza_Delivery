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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text;
            String passUser = PassField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `name`=@uL AND `password`=@uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успешный вход");
                this.Hide();
                using (Dashboard dashb = new Dashboard())
                {
                    dashb.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser addnewuser = new AddNewUser();
            addnewuser.Show();
        }
    }
}
