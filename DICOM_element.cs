using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dicom
{
    public class DICOM_element
    {
        public string groupID { get; set; }
        public string elementID { get; set; }
        public string vr { get; set; }
        public string DataSet_Description { get; set; }

        public DICOM_element(string p_group_number, string p_element_number, string p_vr, string p_dataSet_Description)
        {
            groupID = p_group_number;
            elementID = p_element_number;
            vr = p_vr;
            DataSet_Description = p_dataSet_Description;
        }
    }

    public class DICOM_elements : List<DICOM_element>
    {
        public DICOM_elements(string filename)
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
                        // не работает, но попытка неплоха
                        /*XmlNode element = node.SelectSingleNode("ElementID");
                        if (element != null)
                        {
                            string vr = "";
                            string name = "";
                            vr = element.SelectSingleNode("VR")?.InnerText;
                            name = element.SelectSingleNode("Name")?.InnerText;
                            if (!string.IsNullOrEmpty(vr) && !string.IsNullOrEmpty(name))
                            {
                                Add(new DICOM_element(group.Value, element.Value, vr, name));
                            }*/
                        if (element != null)
                        {
                            string vr = "";
                            string name = "";
                            foreach (XmlNode Childnode in element.ChildNodes)
                            {
                                switch (Childnode.LocalName)
                                {
                                    case "VR": vr = Childnode.InnerText; break;
                                    case "Name": name = Childnode.InnerText; break;
                                }
                            }
                            Add(new DICOM_element(group.Value, element.Value, vr, name));
                        }
                    }
                }
            }
        }

        public DICOM_element Get_Element(string groupID, string elementID)
        {
            DICOM_element result = null;
            if (elementID == "0000")
                result = new DICOM_element(groupID, elementID, "UL", "Group Length");
            else
            {
                int index = 0;
                while (index < Count && (this[index].groupID != groupID || this[index].elementID != elementID)) 
                {
                    index++;
                }
                if (index == Count)
                    result = new DICOM_element(groupID, elementID, "UN", "User Data");
                else
                    result = this[index];
            }
            return result;
        }
    }
}
