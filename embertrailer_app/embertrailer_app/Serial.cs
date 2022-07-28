using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Collections.Concurrent;

namespace embertrailer_app
{
    internal class Serial
    {
        public static BlockingCollection<string> messages = new BlockingCollection<string>();   // Thread-safe collection
        SerialPort port;

        public Serial()
        {
            port = new SerialPort();
        }
         
        public void Connect()
        {
            port.PortName = "COM6";
            port.BaudRate = 9600;
            port.Open();
            port.ReadExisting();
        }

        public void ReadData()
        {   
            try
            {
                string data = port.ReadLine();
                MessageBox.Show(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Adds a message to the queue every 1 second
        public void ThreadTest()
        {
            int i = 0;
            while (true)
            {
                messages.Add("test " + i.ToString());
                i = (i == 0) ? 1 : 0;
                Thread.Sleep(1000);
            }
        }
    }
}
