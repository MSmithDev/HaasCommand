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
        private qParse qP = new qParse();
        machineData md = new machineData();

        List<change> changes = new List<change>();
        
            public class change
        {
            public int toolNumber;
            public int offsetType;
            public double value;
        }


        BindingList<toolData> td = new BindingList<toolData>();

        BindingList<offsetData> od = new BindingList<offsetData>();

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

        public class offsetData
        {
            public int offsetNumber { get; set; }
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
            public double a { get; set; }
            public double b { get; set; }
            public double c { get; set; }
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

            getUpdates.Start();

        }


        private void command_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing Window and connection");
            tcpClient.Close();
        }

        private void get_toolOffsets_btn_Click(object sender, EventArgs e)
        {
            
            toolDataview.DefaultCellStyle.BackColor = Color.White;
            toolDataview.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            
            toolOffset_progbar.Visible = true;
            
            td.Clear();
            toolDataview.DataSource = td;
            for (int i = 0; i < 24; i++)
            {
                int tN;
                double tL, tD, tC;
                //Get Tool[i] Length Offset
                writer.WriteLine("?Q600 " + (qP.m_toolLengthStart + i));
                writer.Flush();
                tL = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get Tool[i] Diameter Offset
                writer.WriteLine("?Q600 " + (qP.m_toolDiameterStart + i));
                writer.Flush();
                tD = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get Tool[i] Pcool Offset
                writer.WriteLine("?Q600 " + (qP.m_toolCoolantStart + i));
                writer.Flush();
                tC = double.Parse(qP.parse(reader.ReadLine()));

                tN = i + 1;

                td.Add(new toolData { toolNumber = tN, toolDiameter = tD, toolLength = tL, coolantPosition = tC });

                Thread.Sleep(50);
                toolOffset_progbar.Value = i + 1;
                toolDataview.Refresh();

            }
            toolOffset_progbar.Visible = false;
           
            
            toolDataview.Refresh();

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
                            case 1:
                                //Length
                                changes.Add(new change()
                                {
                                    toolNumber = cell.RowIndex + 1,
                                    offsetType = 1,
                                    value = (double)cell.Value
                                });
                                    
                                Console.WriteLine("Length Change: Tool # " + (cell.RowIndex + 1));
                                break;

                            case 2:
                                //Diameter
                                changes.Add(new change()
                                {
                                    toolNumber = cell.RowIndex + 1,
                                    offsetType = 2,
                                    value = (double)cell.Value
                                });
                                Console.WriteLine("Diameter Change: Tool # " + (cell.RowIndex + 1));
                                break;

                            case 3:
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
            if (toolDataview.CurrentCell != null)
            {
                toolDataview.CurrentCell.Style.BackColor = Color.LightPink;
            }
        }

        private void getWorkOffsets_btn_Click(object sender, EventArgs e)
        {
            offsetDGV.DefaultCellStyle.BackColor = Color.White;
            offsetDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;


            od.Clear();
            offsetDGV.DataSource = od;
            for (int i = 0; i < 6; i++)
            {
                int offsetNumber;
                double x, y, z, a, b, c;

                //Get X offset value
                writer.WriteLine("?Q600 " + (qP.m_workOffsetStarts[i,1]));
                writer.Flush();
                x = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get Y offset value
                writer.WriteLine("?Q600 " + (qP.m_workOffsetStarts[i, 1]+1));
                writer.Flush();
                y = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get Z offset value
                writer.WriteLine("?Q600 " + (qP.m_workOffsetStarts[i, 1]+2));
                writer.Flush();
                z = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get A offset value
                writer.WriteLine("?Q600 " + (qP.m_workOffsetStarts[i, 1]+3));
                writer.Flush();
                a = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get B offset value
                writer.WriteLine("?Q600 " + (qP.m_workOffsetStarts[i, 1]+4));
                writer.Flush();
                b = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                //Get C offset value
                writer.WriteLine("?Q600 " + (qP.m_workOffsetStarts[i, 1]+5));
                writer.Flush();
                c = Math.Round(double.Parse(qP.parse(reader.ReadLine())), 4);
                Thread.Sleep(50);

                offsetNumber = 54 + i;

                od.Add(new offsetData {offsetNumber = offsetNumber,x = x, y = y, z = z, a = a, b = b, c = c});

                //Thread.Sleep(50);
                //toolOffset_progbar.Value = i + 1;
                offsetDGV.Refresh();

            }
        }

        private void offsetDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(offsetDGV.CurrentCell);
            if (offsetDGV.CurrentCell != null)
            {
                offsetDGV.CurrentCell.Style.BackColor = Color.LightPink;
            }
        }
    }
}
