using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicom
{
    internal class DICOM_dataset
    {
        private int group_number;
        private int element_number;
        private string vr;
        private string DataSet_Description;

        DICOM_dataset(int p_group_number, int p_element_number, string p_vr, string p_dataSet_Description)
        {
            group_number = p_group_number;
            element_number = p_element_number;
            vr = p_vr;
            DataSet_Description = p_dataSet_Description;
        }
    }
}
