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

namespace CompProgPT
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public void Form6_Load(object sender, EventArgs e)
        {
            string username = Form1.username;
            this.label1.Text = username + "'s Profile";
            string mysqlconn = "server=localhost; user=root; database=customers_database; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usersinfo WHERE username ='" + username + "';" + "SELECT * FROM balance WHERE username='" + username + "'", mySqlConnection);
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    this.label2.Text = myReader["username"].ToString() + "'s Profile Picture";
                    this.label3.Text = "Name: " + myReader["username"].ToString();
                    this.label4.Text = "Email: " + myReader["Email"].ToString();
                    this.label5.Text = "Phone Number: " + myReader["Phone_Number"].ToString();
                    this.label5.Text = "Payment Details: " + myReader["Payment_Details"].ToString();
                }

                if (myReader.NextResult())
                {
                    while (myReader.Read())
                    {
                        this.label6.Text = "Account Balance: " + myReader["Account_Balance"].ToString() + "$";
                        this.label7.Text = "Available Points: " + myReader["Redeem_Points"].ToString();
                    }
                }
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 orders = new Form3();
            this.Hide();
            orders.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 cashin = new Form7();
            cashin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 details = new Form8();
            details.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 orders = new Form3();
            this.Hide();
            orders.Show();
        }
    }
}
