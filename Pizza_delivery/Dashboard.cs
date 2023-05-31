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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (AddNewUser adu = new AddNewUser())
            {
                adu.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (ChangePassword ch = new ChangePassword())
            {
                ch.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label3.Text;
            myOrder.passPrise1 = label4.Text;
            myOrder.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label6.Text;
            myOrder.passPrise1 = label5.Text;
            myOrder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label9.Text;
            myOrder.passPrise1 = label8.Text;
            myOrder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label12.Text;
            myOrder.passPrise1 = label11.Text;
            myOrder.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label15.Text;
            myOrder.passPrise1 = label14.Text;
            myOrder.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label30.Text;
            myOrder.passPrise1 = label29.Text;
            myOrder.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label27.Text;
            myOrder.passPrise1 = label26.Text;
            myOrder.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label24.Text;
            myOrder.passPrise1 = label23.Text;
            myOrder.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label21.Text;
            myOrder.passPrise1 = label20.Text;
            myOrder.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();
            myOrder.pizzaName = label18.Text;
            myOrder.passPrise1 = label17.Text;
            myOrder.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
