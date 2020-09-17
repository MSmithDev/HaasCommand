using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaasCommand
{
    public partial class command : Form
    {

        static TcpClient tcpClient;
        private ConnectF connectF;
        static StreamWriter writer;
        static StreamReader reader;
        public command(ConnectF form)
        {
            InitializeComponent();
            this.connectF = form;
        }

        public class machineData
        {
            public int serialNumber { get; set; }
            public string modelNumber { get; set; }
            public string softwareVersion { get; set; }
            public int toolChanges { get; set; }
            public string powerTime { get; set; }
            public string motionTime { get; set; }
            public string ipAddress { get; set; }
            public int mdcPort { get; set; }
        }

        public class toolData
        {
            public int toolNumber { get; set; }
            public double toolLength { get; set; }
            public double toolDiameter { get; set; }
            public int coolantPosition { get; set; }
        }

        T[] InitializeArray<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }

            return array;
        }

        private void command_Load(object sender, EventArgs e)
        {

            Console.WriteLine("Init TCP Connection");
            Console.WriteLine("Ip: " + connectF.ipAddr);
            Console.WriteLine("Port: " + connectF.port);
            Console.WriteLine("Attempting Connection");
            tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect(connectF.ipAddr, int.Parse(connectF.port));

            }
            catch (Exception)
            {

                Console.WriteLine("Connection Failed");
            }

            writer = new StreamWriter(tcpClient.GetStream());
            reader = new StreamReader(tcpClient.GetStream());

          


            Console.WriteLine("Connected");
            //Console.WriteLine(reader.ReadLine());

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HCDataset.mdf;Integrated Security=True;Connect Timeout=30");


            String sn = "228";

            conn.Open();

            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from toolData where serialNumber = " + sn;
            //cmd.CommandText = "INSERT INTO toolData (serialNumber, toolNumber, toolLength, toolDiameter, coolantPosition) values('"+228+"','"+1+"','"+3+"','"+0.5+"','"+21+"')";
            //cmd.ExecuteNonQuery();


            qParse qP = new qParse();
            machineData md = new machineData();
            Thread.Sleep(1000);
            //Send query for serial number
            writer.WriteLine("?Q100");
            writer.Flush();
            md.serialNumber = int.Parse(qP.parse(reader.ReadLine()));
            Thread.Sleep(1000);
            writer.WriteLine("?Q102");
            writer.Flush();
            md.modelNumber = qP.parse(reader.ReadLine());
            Thread.Sleep(1000);
            writer.WriteLine("?Q101");
            writer.Flush();
            md.softwareVersion = qP.parse(reader.ReadLine());
            Thread.Sleep(1000);
            serial_number_tb.Text = md.serialNumber.ToString();
            model_tb.Text = md.modelNumber;
            software_version_tb.Text = md.softwareVersion;
            Thread.Sleep(1000);

            toolData[] td = InitializeArray<toolData>(25);

           for (int i = 0; i < td.Length; i++)
            {
                //Get Tool[i] Length Offset
                writer.WriteLine("?Q600 " + (qP.m_toolLengthStart + i));
                writer.Flush();
                td[i].toolLength = double.Parse(qP.parse(reader.ReadLine()));
                Thread.Sleep(500);

                //Get Tool[i] Diameter Offset
                writer.WriteLine("?Q600 " + (qP.m_toolDiameterStart + i));
                writer.Flush();
                td[i].toolDiameter = double.Parse(qP.parse(reader.ReadLine()));
                Thread.Sleep(500);

                //Get Tool[i] Pcool Offset
                writer.WriteLine("?Q600 " + (qP.m_toolCoolantStart + i));
                writer.Flush();
                td[i].coolantPosition = int.Parse(qP.parse(reader.ReadLine()));
                



                td[i].toolNumber = i + 1;
                Thread.Sleep(1000);

            }

            toolDataview.DataSource = td;
           
                
                }


        private void command_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing Window and connection");
            tcpClient.Close();
        }
    }
}
