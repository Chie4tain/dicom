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
    public partial class Main : Form
    {
        public DICOM_datasets DICOM_elements;
        public Main()
        {
            InitializeComponent();

            DICOM_elements = new DICOM_datasets("dicom_elements.xml");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DICOM dcm = new DICOM(openFDialog.FileName, DICOM_elements);
                    WorkingForm newForm = new WorkingForm();
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
    }
}
