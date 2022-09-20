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
        // Thread-safe collections (queues by default)
        public static BlockingCollection<string> msgFromArduino = new BlockingCollection<string>();
        public static BlockingCollection<string> msgToArduino = new BlockingCollection<string>();
        
        SerialPort port;

        public Serial()
        {
            port = new SerialPort();
        }
         
        // Establish connection to specified port
        public void Connect()
        {
            port.PortName = "COM4"; 
            port.BaudRate = 9600;
            port.Open();
            port.ReadExisting();
        }

        // Reads data from the serial port (one line until the newline)
        public void ReadData()
        {
            while (true)
            {
                try
                {
                    string data = port.ReadLine();
                    msgFromArduino.Add(data);
                    //System.Console.WriteLine("RECEIVED: " + data);
                }
                catch (Exception ex)
                {
                    // ??
                }
            }
        }

        // Writes to serial port the command operator gives from the UI. If no command is given, the default newline is used
        public void WriteData()
        {
            foreach (var msg in Serial.msgToArduino.GetConsumingEnumerable())
            {
                try
                {
                    port.WriteLine(msg);
                }
                catch (Exception ex)
                {
                    // ??
                }
            }
        }
    }
}
