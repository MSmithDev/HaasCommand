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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new HaasCommand.DataSet1();
            this.toolDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coolantPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumberDataGridViewTextBoxColumn,
            this.toolNumberDataGridViewTextBoxColumn,
            this.toolLengthDataGridViewTextBoxColumn,
            this.toolDiameterDataGridViewTextBoxColumn,
            this.coolantPositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toolDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(385, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(403, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolDataBindingSource
            // 
            this.toolDataBindingSource.DataMember = "toolData";
            this.toolDataBindingSource.DataSource = this.dataSet1;
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
            // 
            // toolLengthDataGridViewTextBoxColumn
            // 
            this.toolLengthDataGridViewTextBoxColumn.DataPropertyName = "toolLength";
            this.toolLengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.toolLengthDataGridViewTextBoxColumn.Name = "toolLengthDataGridViewTextBoxColumn";
            // 
            // toolDiameterDataGridViewTextBoxColumn
            // 
            this.toolDiameterDataGridViewTextBoxColumn.DataPropertyName = "toolDiameter";
            this.toolDiameterDataGridViewTextBoxColumn.HeaderText = "Diameter";
            this.toolDiameterDataGridViewTextBoxColumn.Name = "toolDiameterDataGridViewTextBoxColumn";
            // 
            // coolantPositionDataGridViewTextBoxColumn
            // 
            this.coolantPositionDataGridViewTextBoxColumn.DataPropertyName = "coolantPosition";
            this.coolantPositionDataGridViewTextBoxColumn.HeaderText = "Pcool Position";
            this.coolantPositionDataGridViewTextBoxColumn.Name = "coolantPositionDataGridViewTextBoxColumn";
            // 
            // command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "command";
            this.Text = "Haas Command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.command_FormClosing);
            this.Load += new System.EventHandler(this.command_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolDiameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coolantPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toolDataBindingSource;
        private DataSet1 dataSet1;
    }
}