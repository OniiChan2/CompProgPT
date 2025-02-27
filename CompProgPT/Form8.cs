using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompProgPT
{
    public partial class Form8 : Form
    {
        Form6 profile = new Form6();
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = Form1.username;
            string details = this.textBox1.Text;
            string mysqlconn = "server=sql12.freesqldatabase.com; user=sql12765120; database=sql12765120; password=JgWhquluQA";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            MySqlCommand cmd = new MySqlCommand();

            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Account number is blank or has whitespaces","Entry Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else { 

            try
            {
                mySqlConnection.Open();
                cmd.Connection = mySqlConnection;
                cmd.CommandText = "UPDATE usersinfo SET Payment_Details=?details WHERE username=?username";
                cmd.Parameters.AddWithValue("?details", details);
                cmd.Parameters.AddWithValue("?username", username);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Details Edited to " + details);
                this.Hide();
                profile.Show();
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

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
