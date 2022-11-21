using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace embertrailer_app
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            logLoading();
        }

        void logLoading()
        {
            string logDir = Application.StartupPath + "\\LogRecords\\";
            string[] logFiles = Directory.GetFiles(logDir);
            foreach (string logRec in logFiles)
                //listLogFile.Items.Add(Path.GetFileName(logRec));
                listLogFile.Items.Add(Path.GetFileName(logRec));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmberTrailer controlPanel = new EmberTrailer();
            controlPanel.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (listLogFile.SelectedIndex >= 0)        
            {
                string path = Application.StartupPath + "\\LogRecords\\" + listLogFile.SelectedItem.ToString();
                Process logReader = new Process();
                logReader.StartInfo.FileName = "notepad.exe";
                logReader.StartInfo.Arguments = path;
                logReader.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                logReader.Start();
                logReader.WaitForExit();
               
                //System.Diagnostics.Process.Start(path);
                //StreamReader logContents = new StreamReader(path);
                //string dataStream = "";
                //while ((dataStream = logContents.ReadLine()) != null)
                //    Console.WriteLine(dataStream);  
                //Console.Read(); 
            }
            else
            {
                MessageBox.Show("Please select a file first");
            }
            //else
            //{
            //    MessageBox.Show("Please select only one file");
            //}
        }
    }
}
