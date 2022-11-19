namespace embertrailer_app
{
    partial class EmberTrailer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelConnectivity = new System.Windows.Forms.Label();
            this.labelBattery = new System.Windows.Forms.Label();
            this.labelInternalTemp = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.logTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.labelTempValue);
            this.panel1.Controls.Add(this.labelLon);
            this.panel1.Controls.Add(this.labelLat);
            this.panel1.Controls.Add(this.labelConnectivity);
            this.panel1.Controls.Add(this.labelBattery);
            this.panel1.Controls.Add(this.labelInternalTemp);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1479, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 1041);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 22);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelTempValue
            // 
            this.labelTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Location = new System.Drawing.Point(163, 176);
            this.labelTempValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(25, 15);
            this.labelTempValue.TabIndex = 8;
            this.labelTempValue.Text = "n/a";
            // 
            // labelLon
            // 
            this.labelLon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLon.AutoSize = true;
            this.labelLon.Location = new System.Drawing.Point(163, 262);
            this.labelLon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(25, 15);
            this.labelLon.TabIndex = 7;
            this.labelLon.Text = "n/a";
            // 
            // labelLat
            // 
            this.labelLat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(163, 241);
            this.labelLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(25, 15);
            this.labelLat.TabIndex = 6;
            this.labelLat.Text = "n/a";
            // 
            // labelConnectivity
            // 
            this.labelConnectivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConnectivity.AutoSize = true;
            this.labelConnectivity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConnectivity.Location = new System.Drawing.Point(172, 37);
            this.labelConnectivity.Name = "labelConnectivity";
            this.labelConnectivity.Size = new System.Drawing.Size(77, 15);
            this.labelConnectivity.TabIndex = 5;
            this.labelConnectivity.Text = "Connectivity";
            // 
            // labelBattery
            // 
            this.labelBattery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBattery.AutoSize = true;
            this.labelBattery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBattery.Location = new System.Drawing.Point(171, 92);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(82, 15);
            this.labelBattery.TabIndex = 4;
            this.labelBattery.Text = "Battery Level";
            // 
            // labelInternalTemp
            // 
            this.labelInternalTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInternalTemp.AutoSize = true;
            this.labelInternalTemp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInternalTemp.Location = new System.Drawing.Point(149, 156);
            this.labelInternalTemp.Name = "labelInternalTemp";
            this.labelInternalTemp.Size = new System.Drawing.Size(127, 15);
            this.labelInternalTemp.TabIndex = 3;
            this.labelInternalTemp.Text = "Internal Temperature";
            // 
            // labelLocation
            // 
            this.labelLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocation.Location = new System.Drawing.Point(156, 218);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(107, 15);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location (Lat/Lon)";
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.history.Location = new System.Drawing.Point(171, 364);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(82, 22);
            this.history.TabIndex = 1;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHelp.Location = new System.Drawing.Point(171, 405);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(82, 22);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.help_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1480, 1041);
            this.webView21.Source = new System.Uri("https://www.google.com/maps/place/49%C2%B016\'38.0%22N+120%C2%B054\'24.2%22W/@49.27" +
        "79851,-120.889943,11.38z/data=!4m5!3m4!1s0x0:0xbcc58d1cd248c613!8m2!3d49.2772257" +
        "!4d-120.9067165", System.UriKind.Absolute);
            this.webView21.TabIndex = 21;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // logTimer
            // 
            this.logTimer.Interval = 10000;
            this.logTimer.Tick += new System.EventHandler(this.logTimer_Tick);
            // 
            // EmberTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.panel1);
            this.Name = "EmberTrailer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmberTrailer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button btnHelp;
        private Button history;
        private Label labelLocation;
        private Label labelInternalTemp;
        private Label labelBattery;
        private Label labelConnectivity;
        private Label labelLon;
        private Label labelLat;
        private Label labelTempValue;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnExit;
        private System.Windows.Forms.Timer logTimer;
    }
}