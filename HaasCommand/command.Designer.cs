namespace HaasCommand
{
    partial class command
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
            this.components = new System.ComponentModel.Container();
            this.toolDataview = new System.Windows.Forms.DataGridView();
            this.toolNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coolantPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serial_number_tb = new System.Windows.Forms.TextBox();
            this.model_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.software_version_tb = new System.Windows.Forms.TextBox();
            this.get_toolOffsets_btn = new System.Windows.Forms.Button();
            this.toolOffset_progbar = new System.Windows.Forms.ProgressBar();
            this.toolOffset_save_btn = new System.Windows.Forms.Button();
            this.optionStop_cbtn = new System.Windows.Forms.CheckBox();
            this.getUpdates = new System.Windows.Forms.Timer(this.components);
            this.offsetDGV = new System.Windows.Forms.DataGridView();
            this.getWorkOffsets_btn = new System.Windows.Forms.Button();
            this.offsetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineInfo_pnl = new System.Windows.Forms.Panel();
            this.machineStats_pnl = new System.Windows.Forms.Panel();
            this.static_lable_toolChanges = new System.Windows.Forms.Label();
            this.static_label_powerOnTimer = new System.Windows.Forms.Label();
            this.toolChanges_tb = new System.Windows.Forms.TextBox();
            this.powerOnTimer_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetDGV)).BeginInit();
            this.machineInfo_pnl.SuspendLayout();
            this.machineStats_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolDataview
            // 
            this.toolDataview.AllowUserToAddRows = false;
            this.toolDataview.AllowUserToDeleteRows = false;
            this.toolDataview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolDataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolDataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolDataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toolNumber,
            this.toolLength,
            this.toolDiameter,
            this.coolantPosition});
            this.toolDataview.Location = new System.Drawing.Point(631, 58);
            this.toolDataview.Name = "toolDataview";
            this.toolDataview.RowHeadersVisible = false;
            this.toolDataview.Size = new System.Drawing.Size(471, 240);
            this.toolDataview.TabIndex = 0;
            this.toolDataview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.toolDataview_CellValueChanged);
            // 
            // toolNumber
            // 
            this.toolNumber.DataPropertyName = "toolNumber";
            this.toolNumber.HeaderText = "Tool";
            this.toolNumber.Name = "toolNumber";
            this.toolNumber.ReadOnly = true;
            // 
            // toolLength
            // 
            this.toolLength.DataPropertyName = "toolLength";
            this.toolLength.HeaderText = "Tool Length";
            this.toolLength.Name = "toolLength";
            this.toolLength.Width = 125;
            // 
            // toolDiameter
            // 
            this.toolDiameter.DataPropertyName = "toolDiameter";
            this.toolDiameter.HeaderText = "Tool Diameter";
            this.toolDiameter.Name = "toolDiameter";
            this.toolDiameter.Width = 125;
            // 
            // coolantPosition
            // 
            this.coolantPosition.DataPropertyName = "coolantPosition";
            this.coolantPosition.HeaderText = "Pcool Position";
            this.coolantPosition.Name = "coolantPosition";
            // 
            // toolDataBindingSource
            // 
            this.toolDataBindingSource.DataMember = "toolData";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // serial_number_tb
            // 
            this.serial_number_tb.Location = new System.Drawing.Point(104, 14);
            this.serial_number_tb.Name = "serial_number_tb";
            this.serial_number_tb.ReadOnly = true;
            this.serial_number_tb.Size = new System.Drawing.Size(100, 20);
            this.serial_number_tb.TabIndex = 3;
            // 
            // model_tb
            // 
            this.model_tb.Location = new System.Drawing.Point(104, 40);
            this.model_tb.Name = "model_tb";
            this.model_tb.ReadOnly = true;
            this.model_tb.Size = new System.Drawing.Size(100, 20);
            this.model_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Software Version";
            // 
            // software_version_tb
            // 
            this.software_version_tb.Location = new System.Drawing.Point(104, 66);
            this.software_version_tb.Name = "software_version_tb";
            this.software_version_tb.ReadOnly = true;
            this.software_version_tb.Size = new System.Drawing.Size(100, 20);
            this.software_version_tb.TabIndex = 6;
            // 
            // get_toolOffsets_btn
            // 
            this.get_toolOffsets_btn.Location = new System.Drawing.Point(461, 61);
            this.get_toolOffsets_btn.Name = "get_toolOffsets_btn";
            this.get_toolOffsets_btn.Size = new System.Drawing.Size(164, 42);
            this.get_toolOffsets_btn.TabIndex = 7;
            this.get_toolOffsets_btn.Text = "Get Tool Offsets";
            this.get_toolOffsets_btn.UseVisualStyleBackColor = true;
            this.get_toolOffsets_btn.Click += new System.EventHandler(this.get_toolOffsets_btn_Click);
            // 
            // toolOffset_progbar
            // 
            this.toolOffset_progbar.Location = new System.Drawing.Point(317, 7);
            this.toolOffset_progbar.Maximum = 25;
            this.toolOffset_progbar.Name = "toolOffset_progbar";
            this.toolOffset_progbar.Size = new System.Drawing.Size(471, 42);
            this.toolOffset_progbar.TabIndex = 8;
            // 
            // toolOffset_save_btn
            // 
            this.toolOffset_save_btn.Location = new System.Drawing.Point(461, 109);
            this.toolOffset_save_btn.Name = "toolOffset_save_btn";
            this.toolOffset_save_btn.Size = new System.Drawing.Size(164, 42);
            this.toolOffset_save_btn.TabIndex = 9;
            this.toolOffset_save_btn.Text = "Save Changes";
            this.toolOffset_save_btn.UseVisualStyleBackColor = true;
            this.toolOffset_save_btn.Click += new System.EventHandler(this.toolOffset_save_btn_Click);
            // 
            // optionStop_cbtn
            // 
            this.optionStop_cbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionStop_cbtn.AutoSize = true;
            this.optionStop_cbtn.BackColor = System.Drawing.Color.LightPink;
            this.optionStop_cbtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.optionStop_cbtn.Location = new System.Drawing.Point(44, 399);
            this.optionStop_cbtn.Name = "optionStop_cbtn";
            this.optionStop_cbtn.Size = new System.Drawing.Size(73, 23);
            this.optionStop_cbtn.TabIndex = 10;
            this.optionStop_cbtn.Text = "Option Stop";
            this.optionStop_cbtn.UseVisualStyleBackColor = false;
            this.optionStop_cbtn.CheckedChanged += new System.EventHandler(this.optionStop_cbtn_CheckedChanged);
            // 
            // getUpdates
            // 
            this.getUpdates.Interval = 2000;
            this.getUpdates.Tick += new System.EventHandler(this.getUpdates_Tick);
            // 
            // offsetDGV
            // 
            this.offsetDGV.AllowUserToAddRows = false;
            this.offsetDGV.AllowUserToDeleteRows = false;
            this.offsetDGV.AllowUserToResizeColumns = false;
            this.offsetDGV.AllowUserToResizeRows = false;
            this.offsetDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.offsetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offsetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.offsetNumber,
            this.x,
            this.y,
            this.z,
            this.a,
            this.b,
            this.c});
            this.offsetDGV.Location = new System.Drawing.Point(398, 304);
            this.offsetDGV.Name = "offsetDGV";
            this.offsetDGV.RowHeadersVisible = false;
            this.offsetDGV.Size = new System.Drawing.Size(704, 242);
            this.offsetDGV.TabIndex = 11;
            this.offsetDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.offsetDGV_CellValueChanged);
            // 
            // getWorkOffsets_btn
            // 
            this.getWorkOffsets_btn.Location = new System.Drawing.Point(228, 304);
            this.getWorkOffsets_btn.Name = "getWorkOffsets_btn";
            this.getWorkOffsets_btn.Size = new System.Drawing.Size(164, 42);
            this.getWorkOffsets_btn.TabIndex = 12;
            this.getWorkOffsets_btn.Text = "Get Work Offsets";
            this.getWorkOffsets_btn.UseVisualStyleBackColor = true;
            this.getWorkOffsets_btn.Click += new System.EventHandler(this.getWorkOffsets_btn_Click);
            // 
            // offsetNumber
            // 
            this.offsetNumber.DataPropertyName = "offsetNumber";
            this.offsetNumber.HeaderText = "Offset";
            this.offsetNumber.Name = "offsetNumber";
            this.offsetNumber.ReadOnly = true;
            this.offsetNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // x
            // 
            this.x.DataPropertyName = "x";
            this.x.HeaderText = "X";
            this.x.Name = "x";
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // y
            // 
            this.y.DataPropertyName = "y";
            this.y.HeaderText = "Y";
            this.y.Name = "y";
            this.y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // z
            // 
            this.z.DataPropertyName = "z";
            this.z.HeaderText = "Z";
            this.z.Name = "z";
            this.z.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // a
            // 
            this.a.DataPropertyName = "a";
            this.a.HeaderText = "A";
            this.a.Name = "a";
            this.a.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // b
            // 
            this.b.DataPropertyName = "b";
            this.b.HeaderText = "B";
            this.b.Name = "b";
            this.b.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // c
            // 
            this.c.DataPropertyName = "c";
            this.c.HeaderText = "C";
            this.c.Name = "c";
            this.c.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // machineInfo_pnl
            // 
            this.machineInfo_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineInfo_pnl.Controls.Add(this.label1);
            this.machineInfo_pnl.Controls.Add(this.label2);
            this.machineInfo_pnl.Controls.Add(this.label3);
            this.machineInfo_pnl.Controls.Add(this.serial_number_tb);
            this.machineInfo_pnl.Controls.Add(this.model_tb);
            this.machineInfo_pnl.Controls.Add(this.software_version_tb);
            this.machineInfo_pnl.Location = new System.Drawing.Point(12, 12);
            this.machineInfo_pnl.Name = "machineInfo_pnl";
            this.machineInfo_pnl.Size = new System.Drawing.Size(228, 99);
            this.machineInfo_pnl.TabIndex = 13;
            // 
            // machineStats_pnl
            // 
            this.machineStats_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineStats_pnl.Controls.Add(this.powerOnTimer_tb);
            this.machineStats_pnl.Controls.Add(this.toolChanges_tb);
            this.machineStats_pnl.Controls.Add(this.static_label_powerOnTimer);
            this.machineStats_pnl.Controls.Add(this.static_lable_toolChanges);
            this.machineStats_pnl.Location = new System.Drawing.Point(12, 117);
            this.machineStats_pnl.Name = "machineStats_pnl";
            this.machineStats_pnl.Size = new System.Drawing.Size(228, 100);
            this.machineStats_pnl.TabIndex = 14;
            // 
            // static_lable_toolChanges
            // 
            this.static_lable_toolChanges.AutoSize = true;
            this.static_lable_toolChanges.Location = new System.Drawing.Point(3, 6);
            this.static_lable_toolChanges.Name = "static_lable_toolChanges";
            this.static_lable_toolChanges.Size = new System.Drawing.Size(76, 13);
            this.static_lable_toolChanges.TabIndex = 15;
            this.static_lable_toolChanges.Text = "Tool Changes:";
            // 
            // static_label_powerOnTimer
            // 
            this.static_label_powerOnTimer.AutoSize = true;
            this.static_label_powerOnTimer.Location = new System.Drawing.Point(3, 30);
            this.static_label_powerOnTimer.Name = "static_label_powerOnTimer";
            this.static_label_powerOnTimer.Size = new System.Drawing.Size(86, 13);
            this.static_label_powerOnTimer.TabIndex = 16;
            this.static_label_powerOnTimer.Text = "Power On Timer:";
            // 
            // toolChanges_tb
            // 
            this.toolChanges_tb.Location = new System.Drawing.Point(104, 3);
            this.toolChanges_tb.Name = "toolChanges_tb";
            this.toolChanges_tb.ReadOnly = true;
            this.toolChanges_tb.Size = new System.Drawing.Size(100, 20);
            this.toolChanges_tb.TabIndex = 15;
            // 
            // powerOnTimer_tb
            // 
            this.powerOnTimer_tb.Location = new System.Drawing.Point(104, 30);
            this.powerOnTimer_tb.Name = "powerOnTimer_tb";
            this.powerOnTimer_tb.ReadOnly = true;
            this.powerOnTimer_tb.Size = new System.Drawing.Size(100, 20);
            this.powerOnTimer_tb.TabIndex = 16;
            // 
            // command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 585);
            this.Controls.Add(this.machineStats_pnl);
            this.Controls.Add(this.machineInfo_pnl);
            this.Controls.Add(this.getWorkOffsets_btn);
            this.Controls.Add(this.offsetDGV);
            this.Controls.Add(this.optionStop_cbtn);
            this.Controls.Add(this.toolOffset_save_btn);
            this.Controls.Add(this.toolOffset_progbar);
            this.Controls.Add(this.get_toolOffsets_btn);
            this.Controls.Add(this.toolDataview);
            this.Name = "command";
            this.Text = "Haas Command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.command_FormClosing);
            this.Load += new System.EventHandler(this.command_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolDataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetDGV)).EndInit();
            this.machineInfo_pnl.ResumeLayout(false);
            this.machineInfo_pnl.PerformLayout();
            this.machineStats_pnl.ResumeLayout(false);
            this.machineStats_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toolDataview;
        private System.Windows.Forms.BindingSource toolDataBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serial_number_tb;
        private System.Windows.Forms.TextBox model_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox software_version_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolDiameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coolantPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button get_toolOffsets_btn;
        private System.Windows.Forms.ProgressBar toolOffset_progbar;
        private System.Windows.Forms.Button toolOffset_save_btn;
        private System.Windows.Forms.CheckBox optionStop_cbtn;
        private System.Windows.Forms.Timer getUpdates;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coolantPosition;
        private System.Windows.Forms.DataGridView offsetDGV;
        private System.Windows.Forms.Button getWorkOffsets_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offsetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.Panel machineInfo_pnl;
        private System.Windows.Forms.Panel machineStats_pnl;
        private System.Windows.Forms.TextBox powerOnTimer_tb;
        private System.Windows.Forms.TextBox toolChanges_tb;
        private System.Windows.Forms.Label static_label_powerOnTimer;
        private System.Windows.Forms.Label static_lable_toolChanges;
    }
}