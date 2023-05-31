using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pizza_delivery
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        static SqlConnection conn = new SqlConnection("server=localhost,3306,root,root,pizza");
        public string price1;
        public string pizzan;
        public string pizzaName
        {
            get
            {
                return pizzan;
            }
            set
            {
                pizzan = value;
            }
        }
        public string passPrise1
        {
            get
            {
                return price1;
            }
            set
            {
                price1 = value;
            }
        }
        private void Order_Load(object sender, EventArgs e)
        {
            txtPrice.Text = price1;
            txtPizzaN.Text = pizzan;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!Permission())
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {
                
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `orderfood` (`name`, `f_name`, `mobile`, `address`,`price`,`pizzaname` ) VALUES (@name, @fname, @mobile, @address, @price, @pizzaname)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtNameOrd.Text;
                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = txtFNameOrd.Text;
                command.Parameters.Add("@mobile", MySqlDbType.Int64).Value = txtMobOrd.Text;
                command.Parameters.Add("@address", MySqlDbType.Text).Value = txtAddOrd.Text;
                command.Parameters.Add("@price", MySqlDbType.Int64).Value = txtPrice.Text;
                command.Parameters.Add("@pizzaname", MySqlDbType.Text).Value = txtPizzaN.Text;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Заказ принят");
                    this.Hide();
                }
                   
                else
                    MessageBox.Show("Произошла ошибка");
                db.closeConnection();  
                
            }
            catch(Exception)
            {
                MessageBox.Show("Connection problem");
            }
            bool Permission()
            {
                if(string.IsNullOrWhiteSpace(txtNameOrd.Text) || string.IsNullOrWhiteSpace(txtFNameOrd.Text) || string.IsNullOrWhiteSpace(txtMobOrd.Text) || string.IsNullOrWhiteSpace(txtAddOrd.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

