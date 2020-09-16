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
        static NetworkStream networkStream;
        private ConnectF connectF;
        static StreamWriter writer;
        static StreamReader reader;
        public command(ConnectF form)
        {
            InitializeComponent();
            this.connectF = form;
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




            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT OVERWRITE toolData (serialNumber, toolNumber, toolLength, toolDiameter, coolantPosition) values('"+228+"','"+1+"','"+3+"','"+0.5+"','"+21+"')";
            cmd.ExecuteNonQuery();


                
                
                }


        private void command_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing Window and connection");
            tcpClient.Close();
        }
    }
}
