using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //set the port
            this.port = port;
            InitializeComponent();

            //add a receivedEventHandler
            this.port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        public void SetReceiveBox(string s)
        {
            //write text to the receiveBod
            if (receiveBox.InvokeRequired)
                //invoke the SetReceiveBoxDelegate method with the currect method as a parameter and s parameter as a string
                Invoke(new SetReceiveBoxDelegate(SetReceiveBox), new object[] { s });
            else
                receiveBox.Text += s;
        }

        //string buffer
        private String buffer;

        //the data handler
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //Console.Write("Data Received:");
            Debug.Write("indate just received: " + indata);
            //receiveBox.Text += indata;

            string enter = "\u0013";

            bool a = (indata == "ST\n");

            if (a)
            {
               Debug.WriteLine("indata is ST");

                sp.WriteLine("");

            }

            //must be the enter
            if (indata.Equals(enter))
            {
                //flush
                Console.WriteLine("Flush: " + buffer);
                buffer = "";
            }
            else
            {
                buffer += indata;
            }

            //invoke the SetReceiveBox method, with the received text
            this.SetReceiveBox(indata);
        }

        //write text to the textBox
        private void sendText_Click_1(object sender, EventArgs e)
        {
            WriteToPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //speed
            this.port.WriteLine("write speed");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //rpm
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //time
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //power
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //energy
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //pulse
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //random button
        }

        private void WriteToPort()
        {
            String totalString = "";

            //0       0       0       4       400     57      01:05   0
            //pulse - rpm - speed - distance - requestpower - energy - tijd - actual power

            totalString += this.pulse.Text + '\t';
            totalString += this.rpmBox.Text + '\t';
            totalString += this.speedBox.Text + '\t';
            totalString += this.distance.Text + '\t';
            totalString += this.power.Text + '\t';
            totalString += this.energy.Text + '\t';
            totalString += this.time.Text + '\t';
            totalString += this.actualPower.Text + '\t';

            this.port.WriteLine(totalString);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //actual power
        }
    }
}
