using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace CompProgPT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.Pw_Input.Text;
            string email = this.email.Text;
            string phone_num = this.phonenum.Text;
            string mysqlconn = "server=localhost; user=root; database=customers_database; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            MySqlCommand cmd = new MySqlCommand();

            if (String.IsNullOrEmpty(this.username.Text) && String.IsNullOrEmpty(this.Pw_Input.Text))
            {

                MessageBox.Show("Username or Password Cannot Be Er");
            }
            try
            {
                mySqlConnection.Open();
                cmd.Connection = mySqlConnection;
                cmd.CommandText = "INSERT INTO usersinfo(Username,Password,Email,Phone_Number) VALUES(?Username,?Password,?Email,?Phone_Number); INSERT INTO balance(Username) VALUES(?Username)";
                cmd.Parameters.Add("?Username", MySqlDbType.Text).Value = username;
                cmd.Parameters.Add("?Password", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("?Email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("?Phone_Number", MySqlDbType.Text).Value = phone_num;
                if (password == Pw_Input2.Text)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Signed up!!");
                    this.Hide();
                    Form1 LoginPage = new Form1();
                    LoginPage.Show();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password Are Not The Same!!");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 LoginForm = new Form1();
            LoginForm.Show();
        }

       
        private void PW_Show_Click(object sender, EventArgs e)
        {
            if (!Pw_Input.UseSystemPasswordChar && !Pw_Input2.UseSystemPasswordChar)
            {
                Pw_Input.UseSystemPasswordChar = true;
                Pw_Input2.UseSystemPasswordChar = true;
                this.PW_Show.SendToBack();
            }
        }

        private void PW_Hidden_Click(object sender, EventArgs e)
        {
            if (Pw_Input.UseSystemPasswordChar && Pw_Input2.UseSystemPasswordChar)
            {
                Pw_Input.UseSystemPasswordChar = false;
                Pw_Input2.UseSystemPasswordChar = false;
                this.PW_Hidden.SendToBack();
            }
        }
    }
}
