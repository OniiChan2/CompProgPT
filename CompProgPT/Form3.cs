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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CompProgPT
{
    public partial class Form3 : Form
    {
        static void added(string text = "Item Added To Your Cart!") => MessageBox.Show(text);
        public static int price = 0;
        public static int points = 0;
        string accountPayment;
        Form7 topUp = new Form7();
        bool sideBarExpand;
        public static List<String> items = new List<string>();

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string username = Form1.username;
            string mysqlconn = "server=sql12.freesqldatabase.com; user=sql12765120; database=sql12765120; password=JgWhquluQA";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            if (string.IsNullOrEmpty(username))
            {
                this.AccBalance.Text = "Account Balance: 0₱";
            }
            else
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlconn))
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandText = "SELECT * FROM balance WHERE username=?username;";
                        cmd.Parameters.AddWithValue("?username", username);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.AccBalance.Text = $"Account Balance: {reader["Account_Balance"]}₱";

                                using (var conn2 = new MySqlConnection(mysqlconn))
                                using (var cmd2 = conn2.CreateCommand())
                                {
                                    conn2.Open();
                                    cmd2.CommandText = "SELECT * FROM usersinfo WHERE username=?username;";
                                    cmd2.Parameters.AddWithValue("?username", username);
                                    using (var reader2 = cmd2.ExecuteReader())
                                    {
                                        while (reader2.Read())
                                        {
                                            accountPayment = Convert.ToString(reader2["Payment_Details"]);
                                        }

                                    }
                                }
                            }

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



        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 Cart = new Form4();
            Cart.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 profileApp = new Form6();
            profileApp.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 LoginApp = new Form1();
            this.Hide();
            price = 0;
            items.Clear();
            LoginApp.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int item_price = 200;
            int item_points = 10;
            points += item_points;
            price += item_price;
            items.Add("MODULE ONE: IF STATEMENT IN C#");
            added();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int item_price = 200;
            int item_points = 10;
            points += item_points;
            price += item_price;
            items.Add("MODULE TWO: BASIC ARRAY IN C#");
            added();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int item_price = 200;
            int item_points = 10;
            points += item_points;
            price += item_price;
            items.Add("MODULE THREE: STRINGS IN C#");
            added();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            int item_price = 200;
            int item_points = 10;
            points += item_points;
            price += item_price;
            items.Add("MODULE FOUR: STRINGBUILDERS IN C#");
            added();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            int item_price = 200;
            int item_points = 10;
            points += item_points;
            price += item_price;
            items.Add("MODULE FIVE: DIFFERENT DATA TYPES IN C#");
            added();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int item_price = 200;
            int item_points = 10;
            points += item_points;
            price += item_price;
            items.Add("MODULE SIX: CONTROL STRUCTURES IN C#");
            added();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AnimTimer.Start();
        }
        private void CartAnim_Timer(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                CartSideBar.Width -= 10;
                if (CartSideBar.Width == CartSideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    AnimTimer.Stop();
                }
            }
            else
            {
                CartSideBar.Width += 10;
                if (CartSideBar.Width == CartSideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    AnimTimer.Stop();
                }
            }
        }
        private void CartCaption_Click(object sender, EventArgs e)
        {
            Form4 Cart = new Form4();
            Cart.Show();
        }
        private void ProfileCaption_Click(object sender, EventArgs e)
        {
            Form6 profileApp = new Form6();
            profileApp.Show();
            this.Hide();
        }
        private void ProfCaption_Click(object sender, EventArgs e)
        {

            Form1 LoginApp = new Form1();
            this.Hide();
            price = 0;
            items.Clear();
            LoginApp.Show();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountPayment))
            {
                MessageBox.Show("You seem have an invalid payment details please check your profile and add a payment detail",
                    "No Payment Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                topUp.Show();
            }
        }
        private void topUpCaption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountPayment))
            {
                MessageBox.Show("You seem have an invalid payment details please check your profile and add a payment detail",
                    "No Payment Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                topUp.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
