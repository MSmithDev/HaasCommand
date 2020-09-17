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
            this.toolDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new HaasCommand.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serial_number_tb = new System.Windows.Forms.TextBox();
            this.model_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.software_version_tb = new System.Windows.Forms.TextBox();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coolantPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolDataview
            // 
            this.toolDataview.AllowUserToAddRows = false;
            this.toolDataview.AllowUserToDeleteRows = false;
            this.toolDataview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolDataview.AutoGenerateColumns = false;
            this.toolDataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolDataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolDataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumberDataGridViewTextBoxColumn,
            this.toolNumberDataGridViewTextBoxColumn,
            this.toolLengthDataGridViewTextBoxColumn,
            this.toolDiameterDataGridViewTextBoxColumn,
            this.coolantPositionDataGridViewTextBoxColumn});
            this.toolDataview.DataSource = this.toolDataBindingSource;
            this.toolDataview.Location = new System.Drawing.Point(334, 61);
            this.toolDataview.Name = "toolDataview";
            this.toolDataview.RowHeadersVisible = false;
            this.toolDataview.Size = new System.Drawing.Size(454, 377);
            this.toolDataview.TabIndex = 0;
            // 
            // toolDataBindingSource
            // 
            this.toolDataBindingSource.DataMember = "toolData";
            this.toolDataBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // serial_number_tb
            // 
            this.serial_number_tb.Location = new System.Drawing.Point(106, 10);
            this.serial_number_tb.Name = "serial_number_tb";
            this.serial_number_tb.ReadOnly = true;
            this.serial_number_tb.Size = new System.Drawing.Size(100, 20);
            this.serial_number_tb.TabIndex = 3;
            // 
            // model_tb
            // 
            this.model_tb.Location = new System.Drawing.Point(106, 33);
            this.model_tb.Name = "model_tb";
            this.model_tb.ReadOnly = true;
            this.model_tb.Size = new System.Drawing.Size(100, 20);
            this.model_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Software Version";
            // 
            // software_version_tb
            // 
            this.software_version_tb.Location = new System.Drawing.Point(106, 58);
            this.software_version_tb.Name = "software_version_tb";
            this.software_version_tb.ReadOnly = true;
            this.software_version_tb.Size = new System.Drawing.Size(100, 20);
            this.software_version_tb.TabIndex = 6;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // toolNumberDataGridViewTextBoxColumn
            // 
            this.toolNumberDataGridViewTextBoxColumn.DataPropertyName = "toolNumber";
            this.toolNumberDataGridViewTextBoxColumn.HeaderText = "Tool Number";
            this.toolNumberDataGridViewTextBoxColumn.Name = "toolNumberDataGridViewTextBoxColumn";
            this.toolNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // toolLengthDataGridViewTextBoxColumn
            // 
            this.toolLengthDataGridViewTextBoxColumn.DataPropertyName = "toolLength";
            this.toolLengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.toolLengthDataGridViewTextBoxColumn.Name = "toolLengthDataGridViewTextBoxColumn";
            this.toolLengthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toolLengthDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolDiameterDataGridViewTextBoxColumn
            // 
            this.toolDiameterDataGridViewTextBoxColumn.DataPropertyName = "toolDiameter";
            this.toolDiameterDataGridViewTextBoxColumn.HeaderText = "Diameter";
            this.toolDiameterDataGridViewTextBoxColumn.Name = "toolDiameterDataGridViewTextBoxColumn";
            this.toolDiameterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toolDiameterDataGridViewTextBoxColumn.Width = 125;
            // 
            // coolantPositionDataGridViewTextBoxColumn
            // 
            this.coolantPositionDataGridViewTextBoxColumn.DataPropertyName = "coolantPosition";
            this.coolantPositionDataGridViewTextBoxColumn.HeaderText = "Pcool Position";
            this.coolantPositionDataGridViewTextBoxColumn.Name = "coolantPositionDataGridViewTextBoxColumn";
            this.coolantPositionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.software_version_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.model_tb);
            this.Controls.Add(this.serial_number_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolDataview);
            this.Name = "command";
            this.Text = "Haas Command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.command_FormClosing);
            this.Load += new System.EventHandler(this.command_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolDataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toolDataview;
        private System.Windows.Forms.BindingSource toolDataBindingSource;
        private DataSet1 dataSet1;
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
    }
}