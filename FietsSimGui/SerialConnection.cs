using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FietsSimGui
{
    class SerialConnection
    {
        private SerialPort port { get; set; }
        private ComboBox portBox { get; set; }
        
        private Form1 form;

        public SerialConnection(ComboBox box, Form1 form) {
            this.portBox = box;
            this.form = form;
            //print ports
            string[] names = SerialPort.GetPortNames();
            Console.WriteLine("Serial ports:");
            foreach (string name in names)
            {
                this.portBox.Items.Add(name);
                Console.WriteLine(name);
            }
            Console.Write("Choose one:");
        }

        public void setPort(String portName)
        {
            this.port = new SerialPort(portName);
            //open the port
            this.port.Open();

            this.port.Write("test");

            this.port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
            //receiveBox.Text += indata;
            form.SetReceiveBox(indata);
            
        }

        public void writeToPort(String text)
        {
            this.port.Write(text);
        }
    }
}
