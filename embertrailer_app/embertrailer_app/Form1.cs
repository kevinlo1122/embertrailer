namespace embertrailer_app
{
    public partial class Form1 : Form
    {
        Serial serialPort;
        Thread receiveThread;
        Thread sendThread;
        Thread labelThread;
        string command = "/n";

        string[] dataArray = new string[6];

        bool IsWaterButtonClicked = false;
        bool IsDrillButtonClicked = false;

        public Form1()
        {
            InitializeComponent();

            serialPort = new Serial();
            serialPort.Connect();

            receiveThread = new Thread(serialPort.ReadData);
            sendThread = new Thread(serialPort.WriteData);
            labelThread = new Thread(LabelUpdateThread);
            receiveThread.Start();
            sendThread.Start();
            labelThread.Start();

            // Read in data from serial port
            //serialPort.ReadData();

            // Write commands to serial port
            //serialPort.WriteData(command);
        }

        // Take messages from the queue, will block if empty
        private void LabelUpdateThread()
        {
            foreach (var msg in Serial.msgFromArduino.GetConsumingEnumerable())
            {
                LabelUpdate(msg);
                Serial.msgToArduino.Add("REPLY,TEST,");
            }
        }

        // Update the text shown by the label; use this code pattern since accessing the Control from a different thread
        private void LabelUpdate(string msg)
        {
            if (labelTest.InvokeRequired)
            {
                labelTest.BeginInvoke(new Action(() => { LabelUpdate(msg); }));
            }
            else
            {
                // Parsing done here (hardcode the labels we want to update)
                // ParseData(msg);
                labelTest.Text = msg;
            }
        }

        public void ParseData(string data)
        {
            int i = 0;
            int index = 0;
            
            while(i < dataArray.Length)
            {
                index = data.IndexOf(','); // finds the index of the first comma in the data string
                dataArray[i] = data.Substring(0, index); // stores the first data value into the dataArray
                data = data[(index + 1)..]; // range operator .. gets the string starting from index + 1 until the end
                i++; // repeat the process with the substring (minus the data retrieved)
            }
        }

        private void water_Click(object sender, EventArgs e)
        {
            IsWaterButtonClicked = !IsWaterButtonClicked;
            command = IsWaterButtonClicked ? "startWater" : "stopWater";
        }

        private void drill_Click(object sender, EventArgs e)
        {
            IsDrillButtonClicked = !IsDrillButtonClicked;
            command = IsDrillButtonClicked ? "startDrill" : "stopDrill"; // TODO: do we still want the drill to be cancellable?
        }

        private void help_Click(object sender, EventArgs e)
        {

        }

        private void history_Click(object sender, EventArgs e)
        {

        }
    }
}