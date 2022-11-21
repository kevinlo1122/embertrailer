namespace embertrailer_app
{
    partial class History
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelLog = new System.Windows.Forms.SplitContainer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listLogFile = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.Panel1.SuspendLayout();
            this.panelLog.Panel2.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1041);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 1041);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // panelLog
            // 
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(6, 0);
            this.panelLog.Name = "panelLog";
            // 
            // panelLog.Panel1
            // 
            this.panelLog.Panel1.Controls.Add(this.btnOpen);
            this.panelLog.Panel1.Controls.Add(this.listLogFile);
            // 
            // panelLog.Panel2
            // 
            this.panelLog.Panel2.Controls.Add(this.btnExit);
            this.panelLog.Panel2.Controls.Add(this.btnMap);
            this.panelLog.Size = new System.Drawing.Size(1898, 1041);
            this.panelLog.SplitterDistance = 1479;
            this.panelLog.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(640, 791);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(200, 50);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listLogFile
            // 
            this.listLogFile.FormattingEnabled = true;
            this.listLogFile.ItemHeight = 15;
            this.listLogFile.Location = new System.Drawing.Point(400, 50);
            this.listLogFile.Name = "listLogFile";
            this.listLogFile.Size = new System.Drawing.Size(679, 364);
            this.listLogFile.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 22);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(171, 364);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(82, 22);
            this.btnMap.TabIndex = 0;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "History";
            this.Text = "History";
            this.panelLog.Panel1.ResumeLayout(false);
            this.panelLog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            this.panelLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Splitter splitter1;
        private Splitter splitter2;
        private SplitContainer panelLog;
        private Button btnExit;
        private Button btnMap;
        private ListBox listLogFile;
        private Button btnOpen;
    }
}