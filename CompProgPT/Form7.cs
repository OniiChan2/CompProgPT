using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace CompProgPT
{
    public partial class Form7 : Form
    {
        public int cashin;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = cashin.ToString();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int value = 500;
            cashin += value;
            this.textBox1.Text = cashin.ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int value = 1000;
            cashin += value;
            this.textBox1.Text = cashin.ToString();

        }

        public void button3_Click(object sender, EventArgs e)
        {
            int value = 1500;
            cashin += value;
            this.textBox1.Text = cashin.ToString();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            int value = 2000;
            cashin += value;
            this.textBox1.Text = cashin.ToString();

        }

        public void button5_Click(object sender, EventArgs e)
        {
            int value = 2500;
            cashin += value;
            this.textBox1.Text = cashin.ToString();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            int value = 3000;
            cashin += value;
            this.textBox1.Text = cashin.ToString();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            int value = 3500;
            cashin += value;
            this.textBox1.Text = cashin.ToString();

        }

        public void button8_Click(object sender, EventArgs e)
        {
            int value = 4000;
            cashin += value;
            this.textBox1.Text = cashin.ToString();
        }

        public void button9_Click(object sender, EventArgs e)
        {
            int value = 4500;
            cashin += value;
            this.textBox1.Text = cashin.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cashin = 0;
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Hide();
            string username = Form1.username;
            string mysqlconn = "server=localhost; user=root; database=customers_database; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

                try
                {
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM balance WHERE username='" + username + "'", mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int current_balance = Convert.ToInt32(reader["Account_Balance"]);
                    int added_balance = current_balance + cashin;
                    reader.Close();
                    cmd.Connection = mySqlConnection;
                    cmd.CommandText = "UPDATE balance SET Account_Balance=?balance WHERE username=?username";
                    cmd.Parameters.Add("?username", MySqlDbType.Text).Value = username;
                    cmd.Parameters.Add("?balance", MySqlDbType.Int32).Value = added_balance;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(cashin + "$ Added to Balance");
                    Form6.label6.Text = current_balance.ToString();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR SOMETHING WHENT WRONG! Please contact a dev~ UwU");
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    mySqlConnection.Close();
                }
        }
        private void Cash_In_Click(object sender, EventArgs e)
        {

        }
    }
}
