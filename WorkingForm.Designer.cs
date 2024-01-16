namespace dicom
{
    partial class WorkingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDicomFile = new System.Windows.Forms.DataGridView();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicomElementGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicomElementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicomElementVRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicomElementDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDicomFile = new System.Windows.Forms.BindingSource(this.components);
            this.pbDicomWindow = new System.Windows.Forms.PictureBox();
            this.panelpb = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDicomFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDicomFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDicomWindow)).BeginInit();
            this.panelpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDicomFile
            // 
            this.dgvDicomFile.AutoGenerateColumns = false;
            this.dgvDicomFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDicomFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDicomFile.ColumnHeadersHeight = 32;
            this.dgvDicomFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDicomFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lengthDataGridViewTextBoxColumn,
            this.dicomElementGroupIDDataGridViewTextBoxColumn,
            this.DicomElementID,
            this.DataStr,
            this.dicomElementVRDataGridViewTextBoxColumn,
            this.dicomElementDescrDataGridViewTextBoxColumn});
            this.dgvDicomFile.DataSource = this.bsDicomFile;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDicomFile.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDicomFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDicomFile.Location = new System.Drawing.Point(0, 0);
            this.dgvDicomFile.Name = "dgvDicomFile";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDicomFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDicomFile.RowHeadersWidth = 51;
            this.dgvDicomFile.RowTemplate.Height = 24;
            this.dgvDicomFile.Size = new System.Drawing.Size(933, 143);
            this.dgvDicomFile.TabIndex = 0;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "length";
            this.lengthDataGridViewTextBoxColumn.FillWeight = 61.48352F;
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dicomElementGroupIDDataGridViewTextBoxColumn
            // 
            this.dicomElementGroupIDDataGridViewTextBoxColumn.DataPropertyName = "DicomElementGroupID";
            this.dicomElementGroupIDDataGridViewTextBoxColumn.FillWeight = 53.47594F;
            this.dicomElementGroupIDDataGridViewTextBoxColumn.HeaderText = "Group ID";
            this.dicomElementGroupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dicomElementGroupIDDataGridViewTextBoxColumn.Name = "dicomElementGroupIDDataGridViewTextBoxColumn";
            this.dicomElementGroupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dicomElementGroupIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DicomElementID
            // 
            this.DicomElementID.DataPropertyName = "DicomElementID";
            this.DicomElementID.HeaderText = "Element ID";
            this.DicomElementID.MinimumWidth = 6;
            this.DicomElementID.Name = "DicomElementID";
            this.DicomElementID.ReadOnly = true;
            // 
            // DataStr
            // 
            this.DataStr.DataPropertyName = "DataStr";
            this.DataStr.HeaderText = "Value";
            this.DataStr.MinimumWidth = 6;
            this.DataStr.Name = "DataStr";
            this.DataStr.ReadOnly = true;
            // 
            // dicomElementVRDataGridViewTextBoxColumn
            // 
            this.dicomElementVRDataGridViewTextBoxColumn.DataPropertyName = "DicomElementVR";
            this.dicomElementVRDataGridViewTextBoxColumn.FillWeight = 128.3468F;
            this.dicomElementVRDataGridViewTextBoxColumn.HeaderText = "VR";
            this.dicomElementVRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dicomElementVRDataGridViewTextBoxColumn.Name = "dicomElementVRDataGridViewTextBoxColumn";
            this.dicomElementVRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dicomElementDescrDataGridViewTextBoxColumn
            // 
            this.dicomElementDescrDataGridViewTextBoxColumn.DataPropertyName = "DicomElementDescr";
            this.dicomElementDescrDataGridViewTextBoxColumn.FillWeight = 128.3468F;
            this.dicomElementDescrDataGridViewTextBoxColumn.HeaderText = "Description";
            this.dicomElementDescrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dicomElementDescrDataGridViewTextBoxColumn.Name = "dicomElementDescrDataGridViewTextBoxColumn";
            this.dicomElementDescrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDicomFile
            // 
            this.bsDicomFile.DataSource = typeof(dicom.DICOM);
            // 
            // pbDicomWindow
            // 
            this.pbDicomWindow.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbDicomWindow.Location = new System.Drawing.Point(0, -52);
            this.pbDicomWindow.Name = "pbDicomWindow";
            this.pbDicomWindow.Size = new System.Drawing.Size(891, 424);
            this.pbDicomWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDicomWindow.TabIndex = 1;
            this.pbDicomWindow.TabStop = false;
            // 
            // panelpb
            // 
            this.panelpb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpb.AutoScroll = true;
            this.panelpb.Controls.Add(this.pbDicomWindow);
            this.panelpb.Location = new System.Drawing.Point(0, 144);
            this.panelpb.Name = "panelpb";
            this.panelpb.Size = new System.Drawing.Size(921, 344);
            this.panelpb.TabIndex = 2;
            // 
            // WorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 535);
            this.Controls.Add(this.panelpb);
            this.Controls.Add(this.dgvDicomFile);
            this.Name = "WorkingForm";
            this.Text = "WorkingForm";
            this.Load += new System.EventHandler(this.WorkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDicomFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDicomFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDicomWindow)).EndInit();
            this.panelpb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDicomFile;
        private System.Windows.Forms.BindingSource bsDicomFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dicomElementGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DicomElementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dicomElementVRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dicomElementDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pbDicomWindow;
        private System.Windows.Forms.Panel panelpb;
    }
}