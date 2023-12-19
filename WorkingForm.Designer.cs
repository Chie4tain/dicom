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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDicomFile = new System.Windows.Forms.DataGridView();
            this.bsDicomFile = new System.Windows.Forms.BindingSource(this.components);
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicomElementGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicomElementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicomElementVRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicomElementDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDicomFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDicomFile)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDicomFile
            // 
            this.dgvDicomFile.AutoGenerateColumns = false;
            this.dgvDicomFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDicomFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDicomFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDicomFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDicomFile.Location = new System.Drawing.Point(0, 0);
            this.dgvDicomFile.Name = "dgvDicomFile";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDicomFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDicomFile.RowHeadersWidth = 51;
            this.dgvDicomFile.RowTemplate.Height = 24;
            this.dgvDicomFile.Size = new System.Drawing.Size(800, 450);
            this.dgvDicomFile.TabIndex = 0;
            // 
            // bsDicomFile
            // 
            this.bsDicomFile.DataSource = typeof(dicom.DICOM);
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
            // WorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDicomFile);
            this.Name = "WorkingForm";
            this.Text = "WorkingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDicomFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDicomFile)).EndInit();
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
    }
}