using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicom
{
    public enum ZoomVariants { Original, Window, In, Out };

    public partial class Main : Form
    {
        public DICOM_elements p_DICOM_elements;
        WorkingForm ActiveWForm;

        public Main()
        {
            InitializeComponent();

            p_DICOM_elements = new DICOM_elements("dicom-elements.xml");
            ActiveWForm = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DICOM dcm = new DICOM(openFDialog.FileName, p_DICOM_elements);

                    WorkingForm newForm = new WorkingForm(dcm);
                    newForm.MdiParent = this;
                    newForm.Show();
                }
                catch (FormatException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlViewer newViewerForm = new XmlViewer(p_DICOM_elements);
                newViewerForm.MdiParent = this;
                newViewerForm.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miSaveToXml();
        }

        private void Main_MdiChildActivate(object sender, EventArgs e)
        {
            ActiveWForm = ActiveMdiChild as WorkingForm;
            if (ActiveWForm == null)
            {
                toolStripBtnOrigImg.Enabled = false;
                toolStripBtnWinImg.Enabled = false;
                toolStripBtnZoomIn.Enabled = false;
                toolStripBtnZoomOut.Enabled = false;
                toolStripBtnSaveXML.Enabled = false;
                toolStripBtnSaveImage.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                xMLToolStripMenuItem.Enabled = false;
                imageToolStripMenuItem.Enabled = false;
            }
            else
            {
                StLblPatientName.Text = ActiveWForm.GetPName();
                StLblDateTime.Text = ActiveWForm.GetDateTime();
                StLblZoom.Text = "100%";
                StLblSizeImg.Text = ActiveWForm.GetSize();
                toolStripBtnOrigImg.Enabled = true;
                toolStripBtnWinImg.Enabled = true;
                toolStripBtnZoomIn.Enabled = true;
                toolStripBtnZoomOut.Enabled = true;
                toolStripBtnSaveXML.Enabled = true;
                toolStripBtnSaveImage.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                xMLToolStripMenuItem.Enabled = true;
                imageToolStripMenuItem.Enabled = true;
            }
        }

        private void miSaveToXml()
        {
            if (SaveDXml.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ActiveWForm.SaveToXml(SaveDXml.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripBtnOrigImg_Click(object sender, EventArgs e)
        {
            StLblZoom.Text = ActiveWForm.Zoom(ZoomVariants.Original).ToString() + "%";
        }

        private void toolStripBtnWinImg_Click(object sender, EventArgs e)
        {
            StLblZoom.Text = ActiveWForm.Zoom(ZoomVariants.Window).ToString() + "%";
        }

        private void toolStripBtnZoomIn_Click(object sender, EventArgs e)
        {
            StLblZoom.Text = StLblZoom.Text = ActiveWForm.Zoom(ZoomVariants.In).ToString() + "%";
        }

        private void toolStripBtnZoomOut_Click(object sender, EventArgs e)
        {
            StLblZoom.Text = ActiveWForm.Zoom(ZoomVariants.Out).ToString() + "%";
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFDialogImage.ShowDialog() == DialogResult.OK)
            {
                ActiveWForm.dICOM_file.Bmp.Save(saveFDialogImage.FileName);
            }
        }
    }
}