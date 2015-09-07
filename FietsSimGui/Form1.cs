using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private delegate void SetReceiveBoxDelegate(string text);


        public Form1()
        {
            InitializeComponent();
            this.serialConnection = new SerialConnection(comPortBox, this);
        }

        public void SetReceiveBox(string s)
        {
            if (receiveBox.InvokeRequired)
                Invoke(new SetReceiveBoxDelegate(SetReceiveBox), new object[] { s });
            else
                receiveBox.Text += s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.serialConnection.setPort("COM1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comPortBox.GetItemText(comPortBox.SelectedItem);
            this.serialConnection.setPort(selected);
        }

        private void sendText_Click(object sender, EventArgs e)
        {
            this.serialConnection.writeToPort(textBox.Text);
        }
    }
}
