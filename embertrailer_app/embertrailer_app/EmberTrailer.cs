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
        // 6: Probe temperature
        string[] dataArray = new string[7];

        bool IsWaterButtonClicked = false;
        bool IsDrillButtonClicked = false;

        public EmberTrailer()
        {
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
            foreach (var msg in Serial.msgFromArduino.GetConsumingEnumerable())
            {
                dataArray = msg.Split('/');

                string tempLat = dataArray[0];
                string tempLon = dataArray[1];
                if (tempLat == "None")
                    LabelUpdate(labelLat, "n/a");
                else
                    LabelUpdate(labelLat, tempLat);

                if (tempLon == "None")
                    LabelUpdate(labelLon, "n/a");
                else
                    LabelUpdate(labelLon, tempLon);

                if (dataArray[2] == "None")
                    LabelUpdate(labelTempValue, "n/a");
                else
                    LabelUpdate(labelTempValue, dataArray[2]);

                if (dataArray[3] == "None")
                    LabelUpdate(labelHumidityValue, "n/a");
                else
                    LabelUpdate(labelHumidityValue, dataArray[3]);

                if (dataArray[4] == "None")
                    LabelUpdate(labelAirQualityValue, "n/a");
                else
                    LabelUpdate(labelAirQualityValue, dataArray[4]);

                // check if hotspot value is >=40
                double hotspotTemp = Convert.ToDouble(dataArray[5]);
                if (hotspotTemp >= 40)
                    LabelUpdate(labelStatusValue, "WARNING");
                else
                    LabelUpdate(labelStatusValue, "OK");

                if (dataArray[6] == "None")
                    LabelUpdate(labelProbeTempValue, "n/a");
                else
                    LabelUpdate(labelProbeTempValue, dataArray[6]);

                // activate the correct severity level
                /*switch(dataArray[#])
                {
                    case 5:
                        // severity level 5
                        // TODO: set inactiveSeverity5 (grey circle) invisible
                        break;
                    case 4:
                        // severity level 4
                        break;
                    case 3:
                        // severity level 3
                        break;
                    case 2:
                        // severity level 2
                        break;
                    case 1:
                        // severity level 1
                        break;
                }*/


                Serial.msgToArduino.Add("REPLY");
            }
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

        private void water_Click(object sender, EventArgs e)
        {
            IsWaterButtonClicked = !IsWaterButtonClicked;
            Serial.msgToArduino.Add("s");
        }

        private void buttonDrillUp_Click(object sender, EventArgs e)
        {
            Serial.msgToArduino.Add("lu");
        }

        private void buttonDrillDown_Click(object sender, EventArgs e)
        {
            Serial.msgToArduino.Add("ld");
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
    }
}