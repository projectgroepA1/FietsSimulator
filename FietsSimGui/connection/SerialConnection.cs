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

        public string[] GetAvailableCOMPorts()
        {
            return SerialPort.GetPortNames(); ;
        }

        public SerialPort setPort(String portName)
        {
            this.port = new SerialPort(portName);
            //open the port
            this.port.Open();

            //this.port.Write("test");
            return this.port;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
            //receiveBox.Text += indata;

            //form.SetReceiveBox(indata);
        }


        public void writeToPort(String text)
        {
            this.port.Write(text);
        }
    }
}
