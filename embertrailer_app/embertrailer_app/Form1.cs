namespace embertrailer_app
{
    public partial class Form1 : Form
    {
        Serial serialPort;
        Thread serialThread;
        Thread labelThread;
        
        public Form1()
        {
            InitializeComponent();

            serialPort = new Serial();
            //serialPort.Connect();

            serialThread = new Thread(serialPort.ThreadTest);
            labelThread = new Thread(LabelUpdateThread);
            serialThread.Start();
            labelThread.Start();
            //serialPort.ReadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}