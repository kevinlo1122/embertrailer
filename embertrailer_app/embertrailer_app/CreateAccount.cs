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
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnRgr_Click(object sender, EventArgs e)
        {
            if (boxUsername.Text == "" || boxPassword.Text == "")
                MessageBox.Show("Username and password must be both filled");
            else if (boxPassword.Text != boxCheckPwd.Text)
                MessageBox.Show("Password does not match");
            else
            {
                // *** VERY IMPORTANT *** //
                // Connection string must be modified base on different file directory before each running of the program
                string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\songx\OneDrive\Documents\AccountInfo.mdf;Integrated Security=True;Connect Timeout=30;";
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
    }
}
