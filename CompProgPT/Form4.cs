using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;


namespace CompProgPT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.label3.Text = $"{Form3.price.ToString()}₱";
            listBox1.DataSource = Form3.items;
            this.label1.Text = $"{Form1.username}'s Cart";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1 LoginPage = new Form1();
            Form3 Orders = new Form3(); 
            string username = Form1.username;
            string mysqlconn = "server=localhost; user=root; database=customers_database; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            int current_balance = 0;
            int new_balance = 0;
            int new_points = 0;
            int current_points = 0;
            int price = Form3.price;
            int points = Form3.points;
            List<String> items = Form3.items;
            

            if (!items.Any())
            {
                MessageBox.Show("Your Cart Is Currently Empty.", "Invalid Function!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                try
                {
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM balance WHERE username='{username}'", mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    current_balance = Convert.ToInt32(reader["Account_Balance"]);
                    current_points = Convert.ToInt32(reader["Redeem_Points"]);
                    reader.Close();

                    if (price > current_balance)
                    {
                        MessageBox.Show($"Your Balance: {current_balance} ₱ is lower than {price} ₱");
                    }

                    if (price <= current_balance)
                    {
                        string items1 = String.Join(" ,", items);
                        MessageBox.Show("Thank you for Shopping! Orders have been successfully placed!");
                        MessageBox.Show($"Your Orders: {items1}");
                        MessageBox.Show("You will now be brought back to the Orders Page");
                        new_balance = current_balance - price;
                        new_points = current_points + points;
                        cmd.CommandText = "UPDATE balance SET Account_Balance=?new_balance, Redeem_Points=?points WHERE username=?username";
                        cmd.Parameters.AddWithValue("?new_balance", new_balance);
                        cmd.Parameters.AddWithValue("?username", username);
                        cmd.Parameters.AddWithValue("?points", points);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"New Balance is now {new_balance}₱, {points} New Add Points");
                        items.Clear();
                        price = 0;
                        points = 0;
                        this.Hide();
                        
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.price = 0;
            Form3.items.Clear();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            this.label3.Text = Form3.price.ToString() + "₱";
            MessageBox.Show("Your Cart Has Been Cleared");
            
        }
    }
}
