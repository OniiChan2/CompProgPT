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
        public static List<String> items = new List<string>();

        public Form3()
        {
            InitializeComponent();
            this.pictureBox2.Parent = this.pictureBox1;
            this.pictureBox3.Parent = this.pictureBox1;
            this.pictureBox4.Parent = this.pictureBox1;
            this.pictureBox5.Parent = this.pictureBox1;
            this.pictureBox6 = this.pictureBox7;
            this.label1.Parent = this.pictureBox1;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

        public void button5_Click(object sender, EventArgs e)
        {
            price = 0;
            items.Clear();
        }
        private void button8_Click(object sender, EventArgs e)
        {

            Form1 LoginPage = new Form1();
            string username = Form1.username;
            string mysqlconn = "server=localhost; user=root; database=customers_database; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            int current_balance = 0;
            int new_balance = 0;
            int new_points = 0;
            int current_points = 0;


            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM balance WHERE username='" + username + "'", mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                current_balance = Convert.ToInt32(reader["Account_Balance"]);
                current_points = Convert.ToInt32(reader["Redeem_Points"]);
                reader.Close();

                if (price > current_balance)
                {
                    MessageBox.Show("BALANCE ERROR", $"Your Balance:{current_balance}$ is lower than {price}$", MessageBoxButtons.OK,MessageBoxIcon.Error);

                }

                if (price <= current_balance)
                {
                    string items1 = String.Join(" ,\n", items);
                    MessageBox.Show("Order Confirmed!","Thank you for Shopping! Orders have been successfully placed!");
                    MessageBox.Show("Your Orders: " + items1);
                    MessageBox.Show("You will now be brought back to the Login Page");
                    new_balance = current_balance - price;
                    new_points = current_points + points;
                    cmd.CommandText = "UPDATE balance SET Account_Balance=?new_balance, Redeem_Points=?points WHERE username=?username";
                    cmd.Parameters.AddWithValue("?new_balance", new_balance);
                    cmd.Parameters.AddWithValue("?username", username);
                    cmd.Parameters.AddWithValue("?points", points);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Balance is now " + new_balance + "$, " + points + " New Added Points");

                    //Flushes and resets the values 
                    items.Clear();
                    price = 0;
                    points = 0;
                    this.Hide();
                    LoginPage.Show();
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
    }
}
