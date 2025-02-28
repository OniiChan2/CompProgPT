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
        private string paymentDetails;

        public Form6()
        {
            InitializeComponent();
        }

        public void Form6_Load(object sender, EventArgs e)
        {
            string username = Form1.username;
            this.profileName.Text = $"{username}'s Profile";
            string mysqlconn = "server=sql12.freesqldatabase.com; user=sql12765120; database=sql12765120; password=JgWhquluQA";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usersinfo WHERE username = ?username;" +
                    "SELECT * FROM balance WHERE username= ?username", mySqlConnection);

                cmd.Parameters.Add("?username", MySqlDbType.Text).Value = username;
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    this.userName.Text = $"{myReader["username"].ToString()}";
                    this.label4.Text = $"{myReader["Email"].ToString()}";
                    this.label3.Text = $"{myReader["Phone_Number"].ToString()}";
                    this.label5.Text = $"{myReader["Payment_Details"].ToString()}";
                    paymentDetails = $"{myReader["Payment_Details"].ToString()}";


                }

                if (myReader.NextResult())
                {
                    while (myReader.Read())
                    {
                        this.label6.Text = $"{myReader["Account_Balance"].ToString()}₱";
                        this.label7.Text = $"{myReader["Redeem_Points"].ToString()}";
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 orders = new Form3();
            this.Hide();
            orders.Show();
        }
   
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paymentDetails))
            {
                MessageBox.Show("Cannot Cash In! Payment details are blank or are Invalid.", "Payment Details Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form7 cashin = new Form7();
                cashin.Show();
            }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btn_paymentdetails_Click(object sender, EventArgs e)
        {
            Form8 details = new Form8();
            details.Show();
            this.Hide();
        }
    }
}
