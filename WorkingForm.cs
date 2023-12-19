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
    public partial class WorkingForm : Form
    {
        DICOM dICOM_file;
        public WorkingForm(DICOM p_dICOM_file)
        {
            InitializeComponent();

            dICOM_file= p_dICOM_file;

            bsDicomFile.DataSource = dICOM_file;
        }
    }
}
