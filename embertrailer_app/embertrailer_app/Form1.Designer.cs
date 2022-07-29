namespace embertrailer_app
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.water = new System.Windows.Forms.Button();
            this.drill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(791, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 649);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Connectivity";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Battery Level";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Internal Temperature";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.history.Location = new System.Drawing.Point(45, 408);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(94, 29);
            this.history.TabIndex = 1;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // help
            // 
            this.help.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.help.Location = new System.Drawing.Point(45, 523);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(94, 29);
            this.help.TabIndex = 0;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "PROBE";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(357, 395);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(54, 20);
            this.labelTest.TabIndex = 4;
            this.labelTest.Text = "testing";
            // 
            // water
            // 
            this.water.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.water.Location = new System.Drawing.Point(444, 485);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(94, 29);
            this.water.TabIndex = 5;
            this.water.Text = "Water";
            this.water.UseVisualStyleBackColor = true;
            this.water.Click += new System.EventHandler(this.water_Click);
            // 
            // drill
            // 
            this.drill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drill.Location = new System.Drawing.Point(616, 486);
            this.drill.Name = "drill";
            this.drill.Size = new System.Drawing.Size(94, 29);
            this.drill.TabIndex = 6;
            this.drill.Text = "Drill";
            this.drill.UseVisualStyleBackColor = true;
            this.drill.Click += new System.EventHandler(this.drill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(975, 649);
            this.Controls.Add(this.drill);
            this.Controls.Add(this.water);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button help;
        private Button history;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelTest;
        private Button water;
        private Button drill;
    }
}