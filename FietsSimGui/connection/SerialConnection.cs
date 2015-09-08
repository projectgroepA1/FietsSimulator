using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace FietsSimGui
{
    class SerialConnection
    {
        private SerialPort port { get; set; }

        public SerialConnection() {
            //print ports
            string[] names = SerialPort.GetPortNames();
            Console.WriteLine("Serial ports:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.Write("Choose one:");
        }

        //return the available port names
        public string[] GetAvailableCOMPorts()
        {
            return SerialPort.GetPortNames(); ;
        }

        //return a Port with the name of portName, which is opened.
        public SerialPort setPort(String portName)
        {
            this.port = new SerialPort(portName);
            //open the port
            this.port.Open();

            //this.port.Write("test");
            return this.port;
        }
    }
}
