using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaasCommand
{
    public partial class ConnectF : Form
    {

        public string ipAddr { get { return ipAddr_tb.Text; } }
        public string port { get { return port_tb.Text; } }


        public ConnectF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ipAddr_tb.Text != "")
            {
                ipAddr_tb.BackColor = Color.White;
                if (port_tb.Text != "")
                {
                    command cmd = new command(this);
                    cmd.Show();

                    if (connection_debugCB.Checked)
                    {
                        debug dbug = new debug();
                        dbug.Show();
                    }
                }
                port_tb.BackColor = Color.Red;
            }else
            {
                ipAddr_tb.BackColor = Color.Red;
            }
            
           
           
        }
    }
}
