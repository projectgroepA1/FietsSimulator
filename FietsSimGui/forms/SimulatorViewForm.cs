using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FietsSimGui
{
    public partial class SimulatorViewForm : Form
    {
        private SerialPort port;
        private delegate void SetReceiveBoxDelegate(string text);

        public SimulatorViewForm(SerialPort port) : base()
        {
            this.port = port;
            InitializeComponent();

            this.port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        public void SetReceiveBox(string s)
        {
            if (receiveBox.InvokeRequired)
                Invoke(new SetReceiveBoxDelegate(SetReceiveBox), new object[] { s });
            else
                receiveBox.Text += s;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
            //receiveBox.Text += indata;
            this.SetReceiveBox(indata);

        }

        private void sendText_Click_1(object sender, EventArgs e)
        {
            this.port.Write(this.textBox.Text);

        }
    }
}
