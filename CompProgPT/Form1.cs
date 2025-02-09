using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MySql.Data.MySqlClient;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;
namespace CompProgPT
{

    public partial class Form1 : Form
    {
        public static string username;
        public static string password;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 SignupForm = new Form2();
            SignupForm.Show();

        }
        public void button2_Click(object sender, EventArgs e)
        {
            username = this.textBox1.Text;
            password = this.textBox2.Text;

            try
            {
                string mysqlconn = "server=localhost; user=root; database=customers_database; password=";
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT COUNT(*) FROM usersinfo WHERE Username='" + username + "' AND Password='" + password + "'", mySqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form3 OrderApp = new Form3();
                    OrderApp.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR SOMETHING WHENT WRONG! Please contact a dev~ UwU");
                MessageBox.Show(ex.Message);
            }

        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = checkBox1.Checked ? false : true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Are you want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

