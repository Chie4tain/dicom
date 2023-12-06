using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dicom
{
    public class DICOM_dataset
    {
        public string group_number;
        public string element_number;
        public string vr;
        public string DataSet_Description;

        public DICOM_dataset(string p_group_number, string p_element_number, string p_vr, string p_dataSet_Description)
        {
            group_number = p_group_number;
            element_number = p_element_number;
            vr = p_vr;
            DataSet_Description = p_dataSet_Description;
        }
    }

    public class DICOM_datasets : List<DICOM_dataset>
    {
        public DICOM_datasets(string filename)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filename);

            XmlElement root = xmlDocument.DocumentElement;
            foreach (XmlNode node in root)
            {
                if(node.Attributes.Count > 0)
                {
                    XmlNode group = node.Attributes.GetNamedItem("GroupID");
                    if(group != null)
                    {
                        XmlNode element = node.Attributes.GetNamedItem("ElementID");
                        if(element != null)
                        {
                            string vr = "";
                            string name = "";
                            foreach (XmlNode Childnode in element.ChildNodes)
                            {
                                switch (Childnode.Name)
                                {
                                    case "VR": vr = Childnode.InnerText; break;
                                    case "Name": name = Childnode.InnerText; break;                         
                                }
                            }
                            Add(new DICOM_dataset(group.Value, element.Value, vr, name));
                        }
                    }
                }
            }
        }

        public DICOM_dataset Get_Dataset(string groupID, string elementID)
        {
            DICOM_dataset result = null;
            if (elementID == "0000")
                result = new DICOM_dataset(groupID, elementID, "UL", "Group Length");
            else
            {
                int index = 0;
                while (index < Count && (this[index].group_number != groupID || this[index].element_number != elementID)) 
                {
                    index++;
                }
                if (index == Count)
                    result = new DICOM_dataset(groupID, elementID, "UN", "User Data");
                else
                    result = this[index];
            }
            return result;
        }
    }
}
