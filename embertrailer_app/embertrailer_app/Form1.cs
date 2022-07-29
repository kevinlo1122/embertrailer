namespace embertrailer_app
{
    public partial class Form1 : Form
    {
        Serial serialPort;
        Thread serialThread;
        Thread labelThread;
        string command = "/n";

        bool IsWaterButtonClicked = false;
        bool IsDrillButtonClicked = false;

        public Form1()
        {
            InitializeComponent();

            serialPort = new Serial();
            //serialPort.Connect();

            serialThread = new Thread(serialPort.ThreadTest);
            labelThread = new Thread(LabelUpdateThread);
            serialThread.Start();
            labelThread.Start();

            // Read in data from serial port
            //serialPort.ReadData();

            // Write commands to serial port
            //serialPort.WriteData(command);
        }

        // Take messages from the queue, will block if empty
        private void LabelUpdateThread()
        {
            foreach (var msg in Serial.messages.GetConsumingEnumerable())
            {
                LabelUpdate(msg);
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
                labelTest.Text = msg;
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