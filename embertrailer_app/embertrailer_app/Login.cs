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
        // *** Cautious ***//
        // Please read ALL instructions below before running the program

        // Create a connection between the backend program and the database 
        // The connection path must be modified for every time of program running

        // Ctrl + Alt + S to open the Server Explorer
        // Right click the .mdf file
        // Select Properties
        // Copy Connection String to acquire the accessibility of the database
        // Paste the Connection String to new SqlConnection as shown as below
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProgrammingScripts\GitRepository\NatureCooler3\embertrailer\embertrailer_app\embertrailer_app\UsersInfo.mdf;Integrated Security=True;Connect Timeout=30;";
        private object sqlConnection;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            boxPassword.UseSystemPasswordChar = true;
            btnShowPwd.BringToFront();
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
            SqlConnection usersDB = new SqlConnection(connStr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM USERS WHERE USERNAME='" + boxUsername.Text + "' COLLATE SQL_Latin1_general_CP1_CS_AS AND PASSWORD = '" + boxPassword.Text + "'" + "COLLATE SQL_Latin1_general_CP1_CS_AS", usersDB);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM USERS WHERE USERNAME LIKE '" + boxUsername.Text + "' AND PASSWORD LIKE '" + boxPassword.Text + "'", usersDB);
            //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USERS WHERE USERNAME='" + boxUsername.Text + "' AND PASSWORD = '" + boxPassword.Text + "'" + "COLLATE latin1_bin", usersDB);
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

        private void lklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount createAccPage = new CreateAccount();  
            createAccPage.Show();
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            boxPassword.UseSystemPasswordChar = false;
            btnHidePwd.BringToFront();
        }

        private void btnHidePwd_Click(object sender, EventArgs e)
        {
            boxPassword.UseSystemPasswordChar = true;
            btnShowPwd.BringToFront();
        }
    }
}
