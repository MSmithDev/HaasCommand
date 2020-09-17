namespace HaasCommand
{
    partial class ConnectF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable_connection1 = new System.Windows.Forms.Label();
            this.ipAddr_tb = new System.Windows.Forms.TextBox();
            this.label_connection2 = new System.Windows.Forms.Label();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.label_connection3 = new System.Windows.Forms.Label();
            this.machineType = new System.Windows.Forms.ComboBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.connection_debugCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lable_connection1
            // 
            this.lable_connection1.AutoSize = true;
            this.lable_connection1.Location = new System.Drawing.Point(13, 13);
            this.lable_connection1.Name = "lable_connection1";
            this.lable_connection1.Size = new System.Drawing.Size(83, 13);
            this.lable_connection1.TabIndex = 0;
            this.lable_connection1.Text = "IP or Hostname:";
            // 
            // ipAddr_tb
            // 
            this.ipAddr_tb.Location = new System.Drawing.Point(102, 10);
            this.ipAddr_tb.Name = "ipAddr_tb";
            this.ipAddr_tb.Size = new System.Drawing.Size(153, 20);
            this.ipAddr_tb.TabIndex = 1;
            this.ipAddr_tb.Text = "HAASVF4SSTR210";
            // 
            // label_connection2
            // 
            this.label_connection2.AutoSize = true;
            this.label_connection2.Location = new System.Drawing.Point(276, 13);
            this.label_connection2.Name = "label_connection2";
            this.label_connection2.Size = new System.Drawing.Size(56, 13);
            this.label_connection2.TabIndex = 2;
            this.label_connection2.Text = "MDC Port:";
            // 
            // port_tb
            // 
            this.port_tb.Location = new System.Drawing.Point(335, 10);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(100, 20);
            this.port_tb.TabIndex = 3;
            this.port_tb.Text = "2282";
            // 
            // label_connection3
            // 
            this.label_connection3.AutoSize = true;
            this.label_connection3.Location = new System.Drawing.Point(13, 41);
            this.label_connection3.Name = "label_connection3";
            this.label_connection3.Size = new System.Drawing.Size(78, 13);
            this.label_connection3.TabIndex = 4;
            this.label_connection3.Text = "Machine Type:";
            // 
            // machineType
            // 
            this.machineType.FormattingEnabled = true;
            this.machineType.Items.AddRange(new object[] {
            "Mill",
            "Lathe"});
            this.machineType.Location = new System.Drawing.Point(102, 38);
            this.machineType.Name = "machineType";
            this.machineType.Size = new System.Drawing.Size(101, 21);
            this.machineType.TabIndex = 5;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(12, 92);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(438, 69);
            this.connect_btn.TabIndex = 7;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // connection_debugCB
            // 
            this.connection_debugCB.AutoSize = true;
            this.connection_debugCB.Location = new System.Drawing.Point(209, 41);
            this.connection_debugCB.Name = "connection_debugCB";
            this.connection_debugCB.Size = new System.Drawing.Size(88, 17);
            this.connection_debugCB.TabIndex = 8;
            this.connection_debugCB.Text = "Debug Mode";
            this.connection_debugCB.UseVisualStyleBackColor = true;
            // 
            // ConnectF
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 172);
            this.Controls.Add(this.connection_debugCB);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.machineType);
            this.Controls.Add(this.label_connection3);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.label_connection2);
            this.Controls.Add(this.ipAddr_tb);
            this.Controls.Add(this.lable_connection1);
            this.Name = "ConnectF";
            this.Text = "Haas Command Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_connection1;
        private System.Windows.Forms.TextBox ipAddr_tb;
        private System.Windows.Forms.Label label_connection2;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label label_connection3;
        private System.Windows.Forms.ComboBox machineType;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.CheckBox connection_debugCB;
    }
}

