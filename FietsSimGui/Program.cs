using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FietsSimGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            SerialPort port = new SerialPort("COM1");
            port.Open();

            //string txt = portWrite();
            //port.WriteLine(txt);

            //receive handler
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            while (true)
            {
                
            }

            //port.Close();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.Write("Data Received: " + indata);
            string enter = "\u0013";
            bool a = (indata == "ST\n");

            if (a)
            {
                Console.WriteLine("indata is ST just received this");
                sp.WriteLine(portWrite());
            }

        }


        private static string portWrite()
        {
            String totalString = "";

            //0       0       0       4       400     57      01:05   0
            //pulse - rpm - speed - distance - requestpower - energy - tijd - actual power

            string pulse = "300";
            string rpm = "150";
            string speed = "20";
            string distance = "5";
            string requestpower = "500";
            string energy = "57";
            string time = "01:05";
            string actualpower = "201";

            totalString += pulse + '\t';
            totalString += rpm + '\t';
            totalString += speed + '\t';
            totalString += distance + '\t';
            totalString += requestpower + '\t';
            totalString += energy + '\t';
            totalString += time + '\t';
            totalString += actualpower + '\t';

            return totalString;
        }
    }
}
