using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace CompProgPT
{
    public partial class Form7 : Form
    {
        int cashin = 0;
        Control ActiveControl;
        public Form7()
        {
            InitializeComponent();
            string username = Form1.username;
            string mysqlconn = "server=sql12.freesqldatabase.com; user=sql12765120; database=sql12765120; password=JgWhquluQA";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            if (string.IsNullOrEmpty(username))
            {
                this.userBalance_lbl.Text = "0.0₱";
                this.redeemPts_lbl.Text = "0 Points";
            }
            else
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlconn))
                    using (var cmd = conn.CreateCommand())
                    {
                        {
                            conn.Open();
                            cmd.CommandText = "SELECT * FROM balance WHERE username=?username;";
                            cmd.Parameters.AddWithValue("?username", username);
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    this.userBalance_lbl.Text = $" {reader["Account_Balance"]}₱";
                                    this.redeemPts_lbl.Text = $"{reader["Redeem_Points"]} Points";
                                    this.userName_lbl.Text = reader.GetString("username");
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
        
        private void Button_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }
        private void Enter_btn(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            Form3 mrktplc = new Form3();
            this.Hide();
            mrktplc.Show();
            this.cashValue.Text = "0";
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("this doesn't do shit yet", "PLACEHOLDER", MessageBoxButtons.OK);

            Form3 market = new Form3();
            cashin = Convert.ToInt32(this.cashValue.Text);
            string username = Form1.username;
            string mysqlconn = "server=sql12.freesqldatabase.com; user=sql12765120; database=sql12765120; password=JgWhquluQA";
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
                this.Hide();
                market.Show();

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

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            this.cashValue.Text = "0";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
