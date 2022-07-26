using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;

namespace embertrailer_app
{
    internal class Serial
    {
        SerialPort port = new SerialPort();
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
    }
}
