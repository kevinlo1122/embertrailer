using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace embertrailer_app
{
    public partial class Login : Form
    {
        private object sqlConnection;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection usersDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProgrammingScripts\GitRepository\NatureCooler\embertrailer\embertrailer_app\embertrailer_app\UsersInfo.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM USERS WHERE USERNAME='" + boxUsername.Text + "' AND PASSWORD = '" + boxPassword.Text + "'", usersDB);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            if (table.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                EmberTrailer controlPanel = new EmberTrailer();
                controlPanel.Show();
            }
            else
            {
                MessageBox.Show("Please check your username or password");
            }

        }

        private void signInArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
