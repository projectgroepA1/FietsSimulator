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
    public partial class Form1 : Form
    {
        //Port connection
        private SerialConnection serialConnection;

        public Form1()
        {
            InitializeComponent();
            this.serialConnection = new SerialConnection();

            foreach(string portName in this.serialConnection.GetAvailableCOMPorts())
            {
                this.comPortBox.Items.Add(portName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the selected port name
            string selected = comPortBox.GetItemText(comPortBox.SelectedItem);

            //connect to the port
            SerialPort port = this.serialConnection.setPort(selected);
            //change screen
            SimulatorViewForm simulatorView = new SimulatorViewForm(port);
            simulatorView.Show();
            this.Hide();
        }
    }
}
