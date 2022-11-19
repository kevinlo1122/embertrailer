using System.Windows.Forms;
using System.IO;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Net.WebRequestMethods;

namespace embertrailer_app
{
    public partial class EmberTrailer : Form
    {
        int serialNum = 1;
        Serial serialPort;
        Thread receiveThread;
        Thread sendThread;
        Thread labelThread;

        // 0: Latitude
        // 1: Longitude
        // 2: Ambient/internal temp.
        // 3: Humidity
        // 4: Air Quality
        // 5: Hottest pixel detected by thermal camera
        string[] dataArray = new string[6];

        StreamWriter log = new StreamWriter(Application.StartupPath + "\\LogRecords\\" +
              DateTime.Now.ToString("ddMMyyyyhhmmss") + ".txt");

        void dataLogging(int serialNum)
        {
            double itnlTemp, lon, lat;

            // Internal temperature, longitude and latitude simulation,
            // this section of instructions must be changed when synthesizing with the practical sensors
            var rand = new Random();
            int min = -10, max = 90;
            itnlTemp = rand.Next(min, max);
            lon = -120.33;
            lat = 49.66;

            string timeStamp = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            log.WriteLine(serialNum.ToString() + ": Internal Temperature: " + itnlTemp.ToString() + ", Latitude: " + lat.ToString() +
                ", Longitude: " + lon.ToString() + ", Date Time: " + timeStamp); ;
        }

        private string ToString(double itnlTemp)
        {
            throw new NotImplementedException();
        }

        public EmberTrailer()
        {
            //webView21.Source = ""
            InitializeComponent();
            //initMap();  
            InitializeComponent();
            logTimer.Enabled = true;
            logTimer.Start();
            serialPort = new Serial();
            serialPort.Connect();

            receiveThread = new Thread(serialPort.ReadData);
            sendThread = new Thread(serialPort.WriteData);
            //labelThread = new Thread(LabelUpdateThread);
            receiveThread.Start();
            sendThread.Start();
            //labelThread.Start();

        }

        // Take messages from the queue, will block if empty
        private void LabelUpdateThread()
        {
            //foreach (var msg in Serial.msgFromArduino.GetConsumingEnumerable())
            //{
            //    dataArray = msg.Split('/');

            //    string tempLat = dataArray[0];
            //    string tempLon = dataArray[1];
            //    if (tempLat == "None")
            //        LabelUpdate(labelLat, "n/a");
            //    else
            //        LabelUpdate(labelLat, tempLat);

            //    if (tempLon == "None")
            //        LabelUpdate(labelLon, "n/a");
            //    else
            //        LabelUpdate(labelLon, tempLon);

            //    if (dataArray[2] == "None")
            //        LabelUpdate(labelTempValue, "n/a");
            //    else
            //        LabelUpdate(labelTempValue, dataArray[2]);

            //    if (dataArray[3] == "None")
            //        LabelUpdate(labelHumidityValue, "n/a");
            //    else
            //        LabelUpdate(labelHumidityValue, dataArray[3]);

            //    if (dataArray[4] == "None")
            //        LabelUpdate(labelAirQualityValue, "n/a");
            //    else
            //        LabelUpdate(labelAirQualityValue, dataArray[4]);

            //    // check if hotspot value is >=40
            //    double hotspotTemp = Convert.ToDouble(dataArray[5]);
            //    if (hotspotTemp >= 40)
            //        LabelUpdate(labelStatusValue, "WARNING");
            //    else
            //        LabelUpdate(labelStatusValue, "OK");

            //    Serial.msgToArduino.Add("REPLY");
            //}
        }

        // Update the text shown by the label; use this code pattern since accessing the Control from a different thread
        private void LabelUpdate(Label lb, string msg)
        {
            if (lb.InvokeRequired)
            {
                lb.BeginInvoke(new Action(() => { LabelUpdate(lb, msg); }));
            }
            else
            {
                lb.Text = msg;
            }
        }

        private void help_Click(object sender, EventArgs e)
        {

        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private void EmberTrailer_FormClosing(object sender, EventArgs e)
        {
            //
        }

        private void EmberTrailer_Load(object sender, EventArgs e)
        {

        }

        private void labelStatusValue_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            logTimer.Enabled = false;
            logTimer.Stop();
            log.Close();
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }

        private void logTimer_Tick(object sender, EventArgs e)
        {
            dataLogging(serialNum);
            serialNum++;       
        }

        //private async void initMap()
        //{
        //    //string url = "https://www.google.com/maps/";
        //    string url = "https://www.google.com/";

        //    await webView21.EnsureCoreWebView2Async();
        //    webView21.CoreWebView2.Navigate(url);
        //}
    }
}