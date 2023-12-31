﻿using System;
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
    public partial class XmlViewer : Form
    {
        public XmlViewer(DICOM_elements elements)
        {
            InitializeComponent();

            dICOMelementsBindingSource.DataSource = elements;

            DataGridXmlViewer.Refresh();
        }
    }
}
