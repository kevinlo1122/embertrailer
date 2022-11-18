using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Net.WebRequestMethods;

namespace embertrailer_app
{
    public partial class EmberTrailer : Form
    {
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

        public EmberTrailer()
        {
            //webView21.Source = ""
            InitializeComponent();
            //initMap();  
            InitializeComponent();
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

        //private async void initMap()
        //{
        //    //string url = "https://www.google.com/maps/";
        //    string url = "https://www.google.com/";

        //    await webView21.EnsureCoreWebView2Async();
        //    webView21.CoreWebView2.Navigate(url);
        //}
    }
}