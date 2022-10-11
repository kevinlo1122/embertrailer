namespace embertrailer_app
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.logo = new System.Windows.Forms.PictureBox();
            this.signInArea = new System.Windows.Forms.Panel();
            this.lklblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.btnShowPwd = new System.Windows.Forms.Button();
            this.btnHidePwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.signInArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(360, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // signInArea
            // 
            this.signInArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(127)))));
            this.signInArea.Controls.Add(this.btnHidePwd);
            this.signInArea.Controls.Add(this.btnShowPwd);
            this.signInArea.Controls.Add(this.lklblCreateAccount);
            this.signInArea.Controls.Add(this.lblCreateAccount);
            this.signInArea.Controls.Add(this.btnExit);
            this.signInArea.Controls.Add(this.btnLogin);
            this.signInArea.Controls.Add(this.boxPassword);
            this.signInArea.Controls.Add(this.password);
            this.signInArea.Controls.Add(this.boxUsername);
            this.signInArea.Controls.Add(this.username);
            this.signInArea.Location = new System.Drawing.Point(131, 107);
            this.signInArea.Name = "signInArea";
            this.signInArea.Size = new System.Drawing.Size(608, 368);
            this.signInArea.TabIndex = 1;
            this.signInArea.Paint += new System.Windows.Forms.PaintEventHandler(this.signInArea_Paint);
            // 
            // lklblCreateAccount
            // 
            this.lklblCreateAccount.AutoSize = true;
            this.lklblCreateAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklblCreateAccount.Location = new System.Drawing.Point(248, 285);
            this.lklblCreateAccount.Name = "lklblCreateAccount";
            this.lklblCreateAccount.Size = new System.Drawing.Size(133, 30);
            this.lklblCreateAccount.TabIndex = 7;
            this.lklblCreateAccount.TabStop = true;
            this.lklblCreateAccount.Text = "CREATE ONE";
            this.lklblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblCreateAccount_LinkClicked);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateAccount.Location = new System.Drawing.Point(61, 285);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(181, 30);
            this.lblCreateAccount.TabIndex = 6;
            this.lblCreateAccount.Text = "Need an account?";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(309, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(238, 80);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(61, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(238, 80);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // boxPassword
            // 
            this.boxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.boxPassword.Location = new System.Drawing.Point(61, 122);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(486, 23);
            this.boxPassword.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(61, 89);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(105, 30);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxUsername
            // 
            this.boxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.boxUsername.Location = new System.Drawing.Point(61, 63);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(486, 23);
            this.boxUsername.TabIndex = 1;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(61, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(110, 30);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShowPwd
            // 
            this.btnShowPwd.Image = global::embertrailer_app.Properties.Resources.visible;
            this.btnShowPwd.Location = new System.Drawing.Point(524, 122);
            this.btnShowPwd.Name = "btnShowPwd";
            this.btnShowPwd.Size = new System.Drawing.Size(23, 23);
            this.btnShowPwd.TabIndex = 2;
            this.btnShowPwd.UseVisualStyleBackColor = true;
            this.btnShowPwd.Click += new System.EventHandler(this.btnShowPwd_Click);
            // 
            // btnHidePwd
            // 
            this.btnHidePwd.Image = global::embertrailer_app.Properties.Resources.hide;
            this.btnHidePwd.Location = new System.Drawing.Point(524, 122);
            this.btnHidePwd.Name = "btnHidePwd";
            this.btnHidePwd.Size = new System.Drawing.Size(23, 23);
            this.btnHidePwd.TabIndex = 8;
            this.btnHidePwd.UseVisualStyleBackColor = true;
            this.btnHidePwd.Click += new System.EventHandler(this.btnHidePwd_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(85)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(853, 487);
            this.Controls.Add(this.signInArea);
            this.Controls.Add(this.logo);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.signInArea.ResumeLayout(false);
            this.signInArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox logo;
        private Panel signInArea;
        private Label username;
        private Label password;
        private TextBox boxUsername;
        private Button btnExit;
        private Button btnLogin;
        private TextBox boxPassword;
        private LinkLabel lklblCreateAccount;
        private Label lblCreateAccount;
        private Button btnHidePwd;
        private Button btnShowPwd;
    }
}