using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace embertrailer_app
{
    public partial class CreateAccount : Form
    {   
        // *** VERY IMPORTANT *** //
        // Connection string must be modified base on different file directory before each running of the program
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\songx\OneDrive\Documents\AccountInfo.mdf;Integrated Security=True;Connect Timeout=30;";

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            picAvailable.Hide();
            picNotAvailable.Hide();
            boxPassword.UseSystemPasswordChar = true;
            boxCheckPwd.UseSystemPasswordChar = true;
            btnShowPwd.BringToFront();
        }

        // Additional member functions

        // Precondition:
        // None
        // Postcondition:
        // Detect the username whether has been resgistered by another user
        // return TRUE for yes
        // otherwise FALSE
        private bool isAvailable()
        {
            // Variables, object declaration and initialization
            string checkDuplicate = "SELECT * FROM USERS WHERE USERNAME='" + boxUsername.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dtAtr = new SqlDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = checkDuplicate;
            cmd.Connection = conn;
            dtAtr.SelectCommand = cmd;
            dtAtr.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
                return true;
            else
                return false;

            // The code below this line should be NEVER executed!
            return false;
        }

        private void btnRgr_Click(object sender, EventArgs e)
        {
            if (boxUsername.Text == "" || boxPassword.Text == "")
                MessageBox.Show("Username and password must be both filled");
            else if (boxPassword.Text != boxCheckPwd.Text)
                MessageBox.Show("Password does not match");
            else
            {
                if (isAvailable())
                {
                    using (SqlConnection toUSERS = new SqlConnection(connString))
                    {
                        toUSERS.Open();
                        SqlCommand cmd = new SqlCommand("ADDUSER", toUSERS);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("USERNAME", boxUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("PASSWORD", boxPassword.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registeration is successful");
                        boxUsername.Text = boxPassword.Text = boxCheckPwd.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Username already exist, please use a different name");
                }
                
            }
        }

        private void boxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lklblBack2Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();  
            loginPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables, object declaration and initialization
            string checkDuplicate = "SELECT * FROM USERS WHERE USERNAME='" + boxUsername.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dtAtr = new SqlDataAdapter();
            DataSet ds = new DataSet(); 

            cmd.CommandText = checkDuplicate;
            cmd.Connection = conn;
            dtAtr.SelectCommand = cmd;
            dtAtr.Fill(ds);

            if (isAvailable())
            {
                picNotAvailable.Hide();
                picAvailable.Show();              
            }
            else
            {
                picAvailable.Hide();
                picNotAvailable.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
