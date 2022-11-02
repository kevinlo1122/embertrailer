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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelConnectivity = new System.Windows.Forms.Label();
            this.labelBattery = new System.Windows.Forms.Label();
            this.labelInternalTemp = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelHumidityValue = new System.Windows.Forms.Label();
            this.labelAirQuality = new System.Windows.Forms.Label();
            this.labelAirQualityValue = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTempValue);
            this.panel1.Controls.Add(this.labelLon);
            this.panel1.Controls.Add(this.labelLat);
            this.panel1.Controls.Add(this.labelConnectivity);
            this.panel1.Controls.Add(this.labelBattery);
            this.panel1.Controls.Add(this.labelInternalTemp);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(975, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 609);
            this.panel1.TabIndex = 2;
            // 
            // labelTempValue
            // 
            this.labelTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Location = new System.Drawing.Point(31, 176);
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
            this.labelLon.Location = new System.Drawing.Point(31, 262);
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
            this.labelLat.Location = new System.Drawing.Point(31, 241);
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
            this.labelConnectivity.Location = new System.Drawing.Point(40, 37);
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
            this.labelBattery.Location = new System.Drawing.Point(39, 92);
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
            this.labelInternalTemp.Location = new System.Drawing.Point(17, 156);
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
            this.labelLocation.Location = new System.Drawing.Point(24, 218);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(107, 15);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location (Lat/Lon)";
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.history.Location = new System.Drawing.Point(39, 364);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(82, 22);
            this.history.TabIndex = 1;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // help
            // 
            this.help.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.help.Location = new System.Drawing.Point(39, 405);
            this.help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(82, 22);
            this.help.TabIndex = 0;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHumidity.Location = new System.Drawing.Point(50, 50);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(58, 15);
            this.labelHumidity.TabIndex = 15;
            this.labelHumidity.Text = "Humidity";
            // 
            // labelHumidityValue
            // 
            this.labelHumidityValue.AutoSize = true;
            this.labelHumidityValue.Location = new System.Drawing.Point(187, 50);
            this.labelHumidityValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHumidityValue.Name = "labelHumidityValue";
            this.labelHumidityValue.Size = new System.Drawing.Size(25, 15);
            this.labelHumidityValue.TabIndex = 16;
            this.labelHumidityValue.Text = "n/a";
            // 
            // labelAirQuality
            // 
            this.labelAirQuality.AutoSize = true;
            this.labelAirQuality.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAirQuality.Location = new System.Drawing.Point(50, 92);
            this.labelAirQuality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAirQuality.Name = "labelAirQuality";
            this.labelAirQuality.Size = new System.Drawing.Size(65, 15);
            this.labelAirQuality.TabIndex = 17;
            this.labelAirQuality.Text = "Air Quality";
            // 
            // labelAirQualityValue
            // 
            this.labelAirQualityValue.AutoSize = true;
            this.labelAirQualityValue.Location = new System.Drawing.Point(187, 92);
            this.labelAirQualityValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAirQualityValue.Name = "labelAirQualityValue";
            this.labelAirQualityValue.Size = new System.Drawing.Size(25, 15);
            this.labelAirQualityValue.TabIndex = 18;
            this.labelAirQualityValue.Text = "n/a";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(50, 148);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 25);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "STATUS";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatusValue.Location = new System.Drawing.Point(187, 148);
            this.labelStatusValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(42, 25);
            this.labelStatusValue.TabIndex = 20;
            this.labelStatusValue.Text = "n/a";
            this.labelStatusValue.Click += new System.EventHandler(this.labelStatusValue_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(346, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(609, 609);
            this.webView21.Source = new System.Uri("https://www.google.com/maps/place/49%C2%B016\'38.0%22N+120%C2%B054\'24.2%22W/@49.27" +
        "79851,-120.889943,11.38z/data=!4m5!3m4!1s0x0:0xbcc58d1cd248c613!8m2!3d49.2772257" +
        "!4d-120.9067165", System.UriKind.Absolute);
            this.webView21.TabIndex = 21;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // EmberTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.labelStatusValue);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelAirQualityValue);
            this.Controls.Add(this.labelAirQuality);
            this.Controls.Add(this.labelHumidityValue);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.panel1);
            this.Name = "EmberTrailer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmberTrailer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button help;
        private Button history;
        private Label labelLocation;
        private Label labelInternalTemp;
        private Label labelBattery;
        private Label labelConnectivity;
        private Label labelLon;
        private Label labelLat;
        private Label labelTempValue;
        private Label labelHumidity;
        private Label labelHumidityValue;
        private Label labelAirQuality;
        private Label labelAirQualityValue;
        private Label labelStatus;
        private Label labelStatusValue;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}