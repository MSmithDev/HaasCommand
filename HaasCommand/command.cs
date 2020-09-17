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
        private toolData[] td, tdInit;
        private qParse qP = new qParse();
        machineData md = new machineData();

        List<change> changes = new List<change>();
        
            public class change
        {
            public int toolNumber;
            public int offsetType;
            public double value;
        }

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
            public bool OptionStop { get; set; }
        }

        public class toolData
        {
            public int toolNumber { get; set; }
            public double toolLength { get; set; }
            public double toolDiameter { get; set; }
            public double coolantPosition { get; set; }
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
            toolOffset_progbar.Visible = false;
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

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HCDataset.mdf;Integrated Security=True;Connect Timeout=30");


            //String sn = "228";

            //conn.Open();

            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from toolData where serialNumber = " + sn;
            //cmd.CommandText = "INSERT INTO toolData (serialNumber, toolNumber, toolLength, toolDiameter, coolantPosition) values('"+228+"','"+1+"','"+3+"','"+0.5+"','"+21+"')";
            //cmd.ExecuteNonQuery();


            
            
            Thread.Sleep(100);
            reader.DiscardBufferedData();
            //Send query for serial number
            writer.WriteLine("?Q100");
            writer.Flush();
            md.serialNumber = int.Parse(qP.parse(reader.ReadLine()));
            Thread.Sleep(100);
            writer.WriteLine("?Q102");
            writer.Flush();
            md.modelNumber = qP.parse(reader.ReadLine());
            Thread.Sleep(100);
            writer.WriteLine("?Q101");
            writer.Flush();
            md.softwareVersion = qP.parse(reader.ReadLine());
            Thread.Sleep(100);
            writer.WriteLine("?Q600 3033");
            writer.Flush();
            md.OptionStop = qP.toBool(qP.parse(reader.ReadLine()));



            serial_number_tb.Text = md.serialNumber.ToString();
            model_tb.Text = md.modelNumber;
            software_version_tb.Text = md.softwareVersion;
            Thread.Sleep(100);


            td = InitializeArray<toolData>(25);


            getUpdates.Start();

        }


        private void command_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing Window and connection");
            tcpClient.Close();
        }

        private void get_toolOffsets_btn_Click(object sender, EventArgs e)
        {
            toolDataview.DataSource = null;
            toolDataview.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            
            toolOffset_progbar.Visible = true;
            
            for (int i = 0; i < td.Length; i++)
            { 
                //Get Tool[i] Length Offset
                writer.WriteLine("?Q600 " + (qP.m_toolLengthStart + i));
                writer.Flush();
                td[i].toolLength = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get Tool[i] Diameter Offset
                writer.WriteLine("?Q600 " + (qP.m_toolDiameterStart + i));
                writer.Flush();
                td[i].toolDiameter = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get Tool[i] Pcool Offset
                writer.WriteLine("?Q600 " + (qP.m_toolCoolantStart + i));
                writer.Flush();
                td[i].coolantPosition = double.Parse(qP.parse(reader.ReadLine()));

                td[i].toolNumber = i + 1;
                Thread.Sleep(50);
                toolOffset_progbar.Value = i + 1;

            }
            toolOffset_progbar.Visible = false;
            tdInit = td;
            toolDataview.DataSource = td;
        }

        private void toolOffset_save_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in toolDataview.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(cell.Style.BackColor == Color.LightPink)
                    {

                        switch(cell.ColumnIndex)
                        {
                            case 2:
                                //Length
                                changes.Add(new change()
                                {
                                    toolNumber = cell.RowIndex + 1,
                                    offsetType = 1,
                                    value = (double)cell.Value
                                });
                                    
                                Console.WriteLine("Length Change: Tool # " + (cell.RowIndex + 1));
                                break;

                            case 3:
                                //Diameter
                                changes.Add(new change()
                                {
                                    toolNumber = cell.RowIndex + 1,
                                    offsetType = 2,
                                    value = (double)cell.Value
                                });
                                Console.WriteLine("Diameter Change: Tool # " + (cell.RowIndex + 1));
                                break;

                            case 4:
                                //Pcool
                                changes.Add(new change()
                                {
                                    toolNumber = cell.RowIndex + 1,
                                    offsetType = 3,
                                    value = (double)cell.Value
                                });
                                Console.WriteLine("Pcool Change: Tool # " + (cell.RowIndex + 1));
                                break;
                        }

                        
                    }
                }
            }
            string diag = "";
            foreach(change test in changes)
            {
                diag += "C: T=" + test.toolNumber + " TY=" + test.offsetType +" V="+test.value + "\n";
            }
            DialogResult res = MessageBox.Show("Are you sure you want to make these changes: \n" + diag, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Console.WriteLine("Writing not yet supported");
            }
            else
            {
                Console.WriteLine("Save Aborted");
            }
        }

        private void optionStop_cbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (optionStop_cbtn.Checked)
            {
                optionStop_cbtn.BackColor = Color.LightGreen;
                writer.WriteLine("?E3033 1.0");
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
            } else
            {
                optionStop_cbtn.BackColor = Color.LightPink;
                writer.WriteLine("?E3033 0.0");
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
            }
        }

        private void getUpdates_Tick(object sender, EventArgs e)
        {
            writer.WriteLine("?Q600 3033");
            writer.Flush();
            md.OptionStop = qP.toBool(qP.parse(reader.ReadLine()));
            Console.WriteLine("IsOpStop: " + md.OptionStop);
            Console.WriteLine("IsChecked: " + optionStop_cbtn.Checked);
            optionStop_cbtn.Checked = md.OptionStop ? true : false;
            optionStop_cbtn.Refresh();
        }

        private void toolDataview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(toolDataview.CurrentCell);
            if (toolDataview.CurrentCell != null) {
                toolDataview.CurrentCell.Style.BackColor = Color.LightPink;

            }

            }

       
    }
}
