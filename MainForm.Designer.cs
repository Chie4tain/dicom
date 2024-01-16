namespace dicom
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFDialog = new System.Windows.Forms.OpenFileDialog();
            this.ststrip = new System.Windows.Forms.StatusStrip();
            this.StLblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.StLblSizeImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.StLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.StLblPatientName = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveDXml = new System.Windows.Forms.SaveFileDialog();
            this.toolStripFastMenu = new System.Windows.Forms.ToolStrip();
            this.toolStrBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSaveXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSaveImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOrigImg = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnWinImg = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.saveFDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu.SuspendLayout();
            this.ststrip.SuspendLayout();
            this.toolStripFastMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Enabled = false;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Enabled = false;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // openFDialog
            // 
            this.openFDialog.FileName = "new_file";
            this.openFDialog.Filter = "DICOM files(*.dcm)|*.dcm|All files(*.*)|*.*";
            // 
            // ststrip
            // 
            this.ststrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ststrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblZoom,
            this.StLblSizeImg,
            this.StLblDateTime,
            this.StLblPatientName});
            this.ststrip.Location = new System.Drawing.Point(0, 428);
            this.ststrip.Name = "ststrip";
            this.ststrip.Size = new System.Drawing.Size(800, 22);
            this.ststrip.TabIndex = 1;
            this.ststrip.Text = "statusStrip1";
            // 
            // StLblZoom
            // 
            this.StLblZoom.Name = "StLblZoom";
            this.StLblZoom.Size = new System.Drawing.Size(0, 16);
            // 
            // StLblSizeImg
            // 
            this.StLblSizeImg.Name = "StLblSizeImg";
            this.StLblSizeImg.Size = new System.Drawing.Size(0, 16);
            // 
            // StLblDateTime
            // 
            this.StLblDateTime.Name = "StLblDateTime";
            this.StLblDateTime.Size = new System.Drawing.Size(0, 16);
            // 
            // StLblPatientName
            // 
            this.StLblPatientName.Name = "StLblPatientName";
            this.StLblPatientName.Size = new System.Drawing.Size(0, 16);
            // 
            // SaveDXml
            // 
            this.SaveDXml.DefaultExt = "xml";
            this.SaveDXml.Filter = "File-XML|*.xml";
            // 
            // toolStripFastMenu
            // 
            this.toolStripFastMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripFastMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrBtnOpenFile,
            this.toolStripBtnSaveXML,
            this.toolStripBtnSaveImage,
            this.toolStripBtnHelp,
            this.toolStripBtnOrigImg,
            this.toolStripBtnWinImg,
            this.toolStripBtnZoomIn,
            this.toolStripBtnZoomOut});
            this.toolStripFastMenu.Location = new System.Drawing.Point(0, 28);
            this.toolStripFastMenu.Name = "toolStripFastMenu";
            this.toolStripFastMenu.Size = new System.Drawing.Size(800, 27);
            this.toolStripFastMenu.TabIndex = 3;
            this.toolStripFastMenu.Text = "toolStrip1";
            // 
            // toolStrBtnOpenFile
            // 
            this.toolStrBtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStrBtnOpenFile.Image")));
            this.toolStrBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrBtnOpenFile.Name = "toolStrBtnOpenFile";
            this.toolStrBtnOpenFile.Size = new System.Drawing.Size(69, 24);
            this.toolStrBtnOpenFile.Text = "Open";
            this.toolStrBtnOpenFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripBtnSaveXML
            // 
            this.toolStripBtnSaveXML.Enabled = false;
            this.toolStripBtnSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSaveXML.Image")));
            this.toolStripBtnSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveXML.Name = "toolStripBtnSaveXML";
            this.toolStripBtnSaveXML.Size = new System.Drawing.Size(94, 28);
            this.toolStripBtnSaveXML.Text = "Save Xml";
            this.toolStripBtnSaveXML.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripBtnSaveImage
            // 
            this.toolStripBtnSaveImage.Enabled = false;
            this.toolStripBtnSaveImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSaveImage.Image")));
            this.toolStripBtnSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveImage.Name = "toolStripBtnSaveImage";
            this.toolStripBtnSaveImage.Size = new System.Drawing.Size(110, 24);
            this.toolStripBtnSaveImage.Text = "Save Image";
            this.toolStripBtnSaveImage.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // toolStripBtnHelp
            // 
            this.toolStripBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.Image")));
            this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHelp.Name = "toolStripBtnHelp";
            this.toolStripBtnHelp.Size = new System.Drawing.Size(65, 28);
            this.toolStripBtnHelp.Text = "Help";
            this.toolStripBtnHelp.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripBtnOrigImg
            // 
            this.toolStripBtnOrigImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOrigImg.Enabled = false;
            this.toolStripBtnOrigImg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOrigImg.Image")));
            this.toolStripBtnOrigImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOrigImg.Name = "toolStripBtnOrigImg";
            this.toolStripBtnOrigImg.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnOrigImg.Text = "toolStripButton1";
            this.toolStripBtnOrigImg.Click += new System.EventHandler(this.toolStripBtnOrigImg_Click);
            // 
            // toolStripBtnWinImg
            // 
            this.toolStripBtnWinImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnWinImg.Enabled = false;
            this.toolStripBtnWinImg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnWinImg.Image")));
            this.toolStripBtnWinImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnWinImg.Name = "toolStripBtnWinImg";
            this.toolStripBtnWinImg.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnWinImg.Text = "toolStripButton2";
            this.toolStripBtnWinImg.Click += new System.EventHandler(this.toolStripBtnWinImg_Click);
            // 
            // toolStripBtnZoomIn
            // 
            this.toolStripBtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnZoomIn.Enabled = false;
            this.toolStripBtnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnZoomIn.Image")));
            this.toolStripBtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnZoomIn.Name = "toolStripBtnZoomIn";
            this.toolStripBtnZoomIn.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnZoomIn.Text = "toolStripButton3";
            this.toolStripBtnZoomIn.Click += new System.EventHandler(this.toolStripBtnZoomIn_Click);
            // 
            // toolStripBtnZoomOut
            // 
            this.toolStripBtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnZoomOut.Enabled = false;
            this.toolStripBtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnZoomOut.Image")));
            this.toolStripBtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnZoomOut.Name = "toolStripBtnZoomOut";
            this.toolStripBtnZoomOut.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnZoomOut.Text = "toolStripButton4";
            this.toolStripBtnZoomOut.Click += new System.EventHandler(this.toolStripBtnZoomOut_Click);
            // 
            // saveFDialogImage
            // 
            this.saveFDialogImage.DefaultExt = "png";
            this.saveFDialogImage.FileName = "New Image";
            this.saveFDialogImage.Filter = "Image|*.png;*.jpeg;*.bmp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripFastMenu);
            this.Controls.Add(this.ststrip);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.Main_MdiChildActivate);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ststrip.ResumeLayout(false);
            this.ststrip.PerformLayout();
            this.toolStripFastMenu.ResumeLayout(false);
            this.toolStripFastMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFDialog;
        private System.Windows.Forms.StatusStrip ststrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveDXml;
        private System.Windows.Forms.ToolStrip toolStripFastMenu;
        private System.Windows.Forms.ToolStripButton toolStrBtnOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveXML;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnOrigImg;
        private System.Windows.Forms.ToolStripButton toolStripBtnWinImg;
        private System.Windows.Forms.ToolStripButton toolStripBtnZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripBtnZoomOut;
        private System.Windows.Forms.ToolStripStatusLabel StLblZoom;
        private System.Windows.Forms.ToolStripStatusLabel StLblSizeImg;
        private System.Windows.Forms.ToolStripStatusLabel StLblDateTime;
        private System.Windows.Forms.ToolStripStatusLabel StLblPatientName;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFDialogImage;
    }
}

