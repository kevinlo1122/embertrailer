namespace embertrailer_app
{
    public partial class Form1 : Form
    {
        Serial serialPort = new Serial();
        public Form1()
        {
            InitializeComponent();
            serialPort.Connect();
            serialPort.ReadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}