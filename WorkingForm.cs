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
        public DICOM dICOM_file;
        public float ZoomCoef = 100;
        public float maxZoom = 250;
        public float minZoom = 50;
        public double ZoomStep;
        public WorkingForm(DICOM p_dICOM_file)
        {
            InitializeComponent();

            dICOM_file= p_dICOM_file;

            bsDicomFile.DataSource = dICOM_file;
        }

        public string GetDateTime()
        {
            return dICOM_file.datetime.ToString();
        }
        public string GetPName()
        {
            return dICOM_file.PatientName;
        }
        public string GetSize()
        {
            return dICOM_file.BmpSize.ToString();
        }
        public void SaveToXml(string FileName)
        {
            dICOM_file.SaveXML(FileName);
        }

        private void WorkingForm_Load(object sender, EventArgs e)
        {
            this.Text = dICOM_file.filename;
            pbDicomWindow.Size = dICOM_file.BmpSize;
            pbDicomWindow.Image = dICOM_file.Bmp;
        }

        public float Zoom( ZoomVariants zv)
        {
            switch (zv)
            {
                case ZoomVariants.Original:
                    ZoomStep = (double)(100 / ZoomCoef);
                    ZoomCoef = 100;
                break;

                case ZoomVariants.Window:
                    ZoomStep = (double)(panelpb.ClientSize.Width) / pbDicomWindow.ClientSize.Width;
                    ZoomCoef = (float)((panelpb.ClientSize.Width * ZoomCoef) / (pbDicomWindow.ClientSize.Width));
                break;

                case ZoomVariants.In:
                    if (ZoomCoef < maxZoom)
                    {
                        ZoomStep = (double)((ZoomCoef + 10) / ZoomCoef);
                        ZoomCoef = (float)(ZoomCoef * ZoomStep);
                    }
                    else
                        ZoomStep = 1;
                break;

                case ZoomVariants.Out:
                    if (ZoomCoef > minZoom)
                    {
                        ZoomStep = (double)((ZoomCoef - 10) / ZoomCoef);
                        ZoomCoef = (float)(ZoomCoef * ZoomStep);
                    }
                    else
                        ZoomStep = 1;
                break;
            }
            pbDicomWindow.Width = (int)(pbDicomWindow.Width * ZoomStep);
            pbDicomWindow.Height = (int)(pbDicomWindow.Height * ZoomStep);

            return ZoomCoef;
        }
    }
}