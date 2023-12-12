namespace dicom
{
    partial class XmlViewer
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
            this.DataGridXmlViewer = new System.Windows.Forms.DataGridView();
            this.GroupIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VRcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICOMelementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridXmlViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICOMelementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridXmlViewer
            // 
            this.DataGridXmlViewer.AutoGenerateColumns = false;
            this.DataGridXmlViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridXmlViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridXmlViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupIDcol,
            this.ElementIDcol,
            this.VRcol,
            this.DescriptionCol,
            this.groupIDDataGridViewTextBoxColumn,
            this.elementIDDataGridViewTextBoxColumn,
            this.vrDataGridViewTextBoxColumn,
            this.dataSetDescriptionDataGridViewTextBoxColumn});
            this.DataGridXmlViewer.DataSource = this.dICOMelementsBindingSource;
            this.DataGridXmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridXmlViewer.Location = new System.Drawing.Point(0, 0);
            this.DataGridXmlViewer.Name = "DataGridXmlViewer";
            this.DataGridXmlViewer.RowHeadersWidth = 51;
            this.DataGridXmlViewer.RowTemplate.Height = 24;
            this.DataGridXmlViewer.Size = new System.Drawing.Size(738, 450);
            this.DataGridXmlViewer.TabIndex = 0;
            // 
            // GroupIDcol
            // 
            this.GroupIDcol.DataPropertyName = "groupID";
            this.GroupIDcol.HeaderText = "Group ID";
            this.GroupIDcol.MinimumWidth = 6;
            this.GroupIDcol.Name = "GroupIDcol";
            // 
            // ElementIDcol
            // 
            this.ElementIDcol.DataPropertyName = "elementID";
            this.ElementIDcol.HeaderText = "Element ID";
            this.ElementIDcol.MinimumWidth = 6;
            this.ElementIDcol.Name = "ElementIDcol";
            // 
            // VRcol
            // 
            this.VRcol.DataPropertyName = "vr";
            this.VRcol.HeaderText = "VR";
            this.VRcol.MinimumWidth = 6;
            this.VRcol.Name = "VRcol";
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.DataPropertyName = "DataSet_Description";
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.MinimumWidth = 6;
            this.DescriptionCol.Name = "DescriptionCol";
            // 
            // dICOMelementsBindingSource
            // 
            this.dICOMelementsBindingSource.DataSource = typeof(dicom.DICOM_elements);
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "groupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "groupID";
            this.groupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            // 
            // elementIDDataGridViewTextBoxColumn
            // 
            this.elementIDDataGridViewTextBoxColumn.DataPropertyName = "elementID";
            this.elementIDDataGridViewTextBoxColumn.HeaderText = "elementID";
            this.elementIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementIDDataGridViewTextBoxColumn.Name = "elementIDDataGridViewTextBoxColumn";
            // 
            // vrDataGridViewTextBoxColumn
            // 
            this.vrDataGridViewTextBoxColumn.DataPropertyName = "vr";
            this.vrDataGridViewTextBoxColumn.HeaderText = "vr";
            this.vrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrDataGridViewTextBoxColumn.Name = "vrDataGridViewTextBoxColumn";
            // 
            // dataSetDescriptionDataGridViewTextBoxColumn
            // 
            this.dataSetDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DataSet_Description";
            this.dataSetDescriptionDataGridViewTextBoxColumn.HeaderText = "DataSet_Description";
            this.dataSetDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataSetDescriptionDataGridViewTextBoxColumn.Name = "dataSetDescriptionDataGridViewTextBoxColumn";
            // 
            // XmlViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.DataGridXmlViewer);
            this.Name = "XmlViewer";
            this.Text = "XmlViewer";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridXmlViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICOMelementsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridXmlViewer;
        private System.Windows.Forms.BindingSource dICOMelementsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VRcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSetDescriptionDataGridViewTextBoxColumn;
    }
}