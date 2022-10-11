namespace embertrailer_app
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.logo = new System.Windows.Forms.PictureBox();
            this.RegisterArea = new System.Windows.Forms.Panel();
            this.boxCheckPwd = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lklblBack2Login = new System.Windows.Forms.LinkLabel();
            this.btnRgr = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.RegisterArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(360, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // RegisterArea
            // 
            this.RegisterArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(127)))));
            this.RegisterArea.Controls.Add(this.boxCheckPwd);
            this.RegisterArea.Controls.Add(this.lblConfirm);
            this.RegisterArea.Controls.Add(this.lklblBack2Login);
            this.RegisterArea.Controls.Add(this.btnRgr);
            this.RegisterArea.Controls.Add(this.boxPassword);
            this.RegisterArea.Controls.Add(this.lblPassword);
            this.RegisterArea.Controls.Add(this.boxUsername);
            this.RegisterArea.Controls.Add(this.lblUsername);
            this.RegisterArea.Location = new System.Drawing.Point(131, 107);
            this.RegisterArea.Name = "RegisterArea";
            this.RegisterArea.Size = new System.Drawing.Size(608, 368);
            this.RegisterArea.TabIndex = 2;
            // 
            // boxCheckPwd
            // 
            this.boxCheckPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.boxCheckPwd.Location = new System.Drawing.Point(61, 181);
            this.boxCheckPwd.Name = "boxCheckPwd";
            this.boxCheckPwd.Size = new System.Drawing.Size(486, 23);
            this.boxCheckPwd.TabIndex = 9;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.Location = new System.Drawing.Point(61, 148);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(191, 30);
            this.lblConfirm.TabIndex = 8;
            this.lblConfirm.Text = "Confirm Password";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lklblBack2Login
            // 
            this.lklblBack2Login.AutoSize = true;
            this.lklblBack2Login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklblBack2Login.Location = new System.Drawing.Point(223, 293);
            this.lklblBack2Login.Name = "lklblBack2Login";
            this.lklblBack2Login.Size = new System.Drawing.Size(163, 30);
            this.lklblBack2Login.TabIndex = 7;
            this.lklblBack2Login.TabStop = true;
            this.lklblBack2Login.Text = "BACK TO LOGIN";
            this.lklblBack2Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblBack2Login_LinkClicked);
            // 
            // btnRgr
            // 
            this.btnRgr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnRgr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRgr.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRgr.ForeColor = System.Drawing.Color.White;
            this.btnRgr.Location = new System.Drawing.Point(61, 210);
            this.btnRgr.Name = "btnRgr";
            this.btnRgr.Size = new System.Drawing.Size(486, 80);
            this.btnRgr.TabIndex = 4;
            this.btnRgr.Text = "REGISTER";
            this.btnRgr.UseVisualStyleBackColor = false;
            this.btnRgr.Click += new System.EventHandler(this.btnRgr_Click);
            // 
            // boxPassword
            // 
            this.boxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.boxPassword.Location = new System.Drawing.Point(61, 122);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(486, 23);
            this.boxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(61, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 30);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boxUsername
            // 
            this.boxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.boxUsername.Location = new System.Drawing.Point(61, 63);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(486, 23);
            this.boxUsername.TabIndex = 1;
            this.boxUsername.TextChanged += new System.EventHandler(this.boxUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(61, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(85)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(853, 487);
            this.Controls.Add(this.RegisterArea);
            this.Controls.Add(this.logo);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.RegisterArea.ResumeLayout(false);
            this.RegisterArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox logo;
        private Panel RegisterArea;
        private LinkLabel lklblBack2Login;
        private Button btnRgr;
        private TextBox boxPassword;
        private Label lblPassword;
        private TextBox boxUsername;
        private Label lblUsername;
        private TextBox boxCheckPwd;
        private Label lblConfirm;
    }
}