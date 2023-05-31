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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (txtoldpass.Text == "@uP")
            {
                //MySqlCommand command = new MySqlCommand("UPDATE `customer` SET `password`=@newpass WHERE `name`=@name", db.GetConnection());

            }
            MySqlCommand command = new MySqlCommand("UPDATE `customer` SET `password`=@newpass WHERE `name`=@name", db.GetConnection());
            command.Parameters.Add("@newpass", MySqlDbType.Int64).Value = txtnewpass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtLogin.Text;           
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заказ принят");
                this.Hide();
            }

            else
                MessageBox.Show("Произошла ошибка");
            db.closeConnection();


            //DB db = new DB();
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=pizza";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //MySqlCommand command = new MySqlCommand("UPDATE `customer` SET `password`=@uL AND `password`=@uP", db.GetConnection());
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 0)
            {
                MessageBox.Show("Пароль не изменен, так как введен неверный старый пароль.");
            }
            else
            {
                MessageBox.Show("Пароль успешно изменен.");
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
