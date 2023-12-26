using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace dicom
{
    public class DICOM : List<DICOM_Dataset>
    {
        string filename;
        BinaryReader reader;
        private bool isExplicitVR;

        public Encoding encoding;
        public DICOM(string fname, DICOM_elements D_elements)
        {
            filename = fname;
            reader = new BinaryReader(File.Open(filename, FileMode.Open));
            encoding = Encoding.ASCII;
            isExplicitVR = true;

            if (is_dicom())
            {
                reader.ReadBytes(8); // пропускаем номер группы номер элемента vr и длину значения (2 байта)
                uint length_0002 = reader.ReadUInt32();
                DICOM_Dataset dataset = new DICOM_Dataset(D_elements.Get_Element("0002", "0000"), 4, BitConverter.GetBytes(length_0002), this);
                Add(dataset);

                long group_0002_end = reader.BaseStream.Position + length_0002;

                string groupID = "";
                string elementID = "";


                while (reader.BaseStream.Position < group_0002_end)
                {
                    groupID = reader.ReadInt16().ToString("X4");
                    elementID = reader.ReadInt16().ToString("X4");
                    
                    string vr = Encoding.ASCII.GetString(reader.ReadBytes(2));

                    uint length = ReadLength(vr);

                    byte[] data = reader.ReadBytes((int)length);

                    dataset = new DICOM_Dataset(D_elements.Get_Element(groupID, elementID), length, data, this);
                    Add(dataset);

                    if (dataset.DICOM_element.elementID == "0010")
                    {
                        isExplicitVR = dataset.DataStr != "1.2.840.10008.1.2";
                    }
                }

                bool is_pixel_data = false;

                do
                {
                    string vr = "";
                    byte[] data = {};

                    groupID = reader.ReadInt16().ToString("X4");
                    elementID = reader.ReadInt16().ToString("X4");
                    is_pixel_data = groupID == "7FE0" && elementID == "0010";

                    if (isExplicitVR)
                        vr = Encoding.ASCII.GetString(reader.ReadBytes(2));

                    uint length = ReadLength(vr);

                    if (!is_pixel_data)
                    {
                        if (vr == "SQ")
                            ReadSequence(length);
                        else
                            data = reader.ReadBytes((int)length); 
                    }

                    Add(new DICOM_Dataset(D_elements.Get_Element(groupID, elementID), length, data, this));

                } while (!is_pixel_data);
            }
            else
            {
                reader.Close();
                throw new FormatException("Is not a DICOM file");
            }     
        }

        private uint ReadLength(string vr)
        {
            uint result = 0;
            if(isExplicitVR)
            {
                if (vr == "OB" || vr == "OW" || vr == "UN" || vr == "UT" || vr == "SQ")
                {
                    reader.ReadBytes(2);

                    result = reader.ReadUInt32();
                }
                else
                    result = reader.ReadUInt16();
            }
            else
                result = reader.ReadUInt32();

            return result;
        }

        private void ReadSequence(uint length)
        {
            if(length == 0xffffffff)
            {
                bool stop = false;
                do
                {
                    ushort tmp = reader.ReadUInt16();
                    if(tmp == 0xfffe)
                    {
                        tmp = reader.ReadUInt16();
                        stop = tmp == 0xe0dd;
                    }
                } while (!stop);
                reader.ReadBytes(4);
            }
        }

        void SaveXML(string filename)
        {
            XmlDocument Xml = new XmlDocument();
            XmlDeclaration decl = Xml.CreateXmlDeclaration("1.0", "utf-8", null);
            Xml.AppendChild(decl);
            XmlNode root = Xml.CreateElement("Datasets");
            Xml.AppendChild(root);
            foreach (var ds in this)
            {
                root.AppendChild(ds.GetXmlNode(Xml));
            }
            Xml.Save(filename);
        }

        public bool is_dicom()
        {
            reader.ReadBytes(128);
            byte[] data = reader.ReadBytes(4);
            string s = Encoding.ASCII.GetString(data);
            return s == "DICM";
        }
    }

    public class DICOM_Dataset
    {
        private readonly DICOM parent;

        public DICOM_element DICOM_element;
        public uint length { get; set; }
        public byte[] data;

        public string DataStr 
        { 
            get 
            {
               return  GetDataStr(parent.encoding);
            }
        }

        public string DicomElementGroupID => DICOM_element.groupID;
        public string DicomElementID => DICOM_element.elementID;
        public string DicomElementVR => DICOM_element.vr;
        public string DicomElementDescr => DICOM_element.DataSet_Description;
        public DICOM_Dataset(DICOM_element p_DICOM_element, uint Length, byte[] Data, DICOM p_parent)
        {
            DICOM_element = p_DICOM_element;
            length = Length;
            data = Data;
            parent = p_parent;
        }

        private string GetDataStr(Encoding cp)
        {
            string result = "";
            if (DICOM_element.vr == "SQ")
                result = "(Sequence)";
            else
            {
                if(length == 0)
                    result = string.Empty;
                else
                {
                    switch (DICOM_element.vr)
                    {
                        case "SS":
                            result = BitConverter.ToInt16(data, 0).ToString();
                            break;
                        case "US":
                            result = BitConverter.ToUInt16(data, 0).ToString();
                            break;
                        case "SL":
                            result = BitConverter.ToInt32(data, 0).ToString();
                            break;
                        case "UL":
                            result = BitConverter.ToUInt32(data, 0).ToString();
                            break;
                        case "FL":
                            result = BitConverter.ToSingle(data, 0).ToString();
                            break;
                        case "FD":
                            result = BitConverter.ToDouble(data, 0).ToString();
                            break;
                        default: result = cp.GetString(data); break; //кодировка
                    }
                }
            }
            return result.Trim(new char[] {(char)0});
        }

        public XmlNode GetXmlNode(XmlDocument p_xml)
        {
            XmlNode xmlElement = p_xml.CreateElement("DataSet");
            XmlAttribute xmlAttribute;

            xmlAttribute = p_xml.CreateAttribute("GroupID");
            xmlAttribute.Value = DICOM_element.groupID;
            xmlElement.Attributes.Append(xmlAttribute);

            xmlAttribute = p_xml.CreateAttribute("ElementID");
            xmlAttribute.Value = DICOM_element.elementID;
            xmlElement.Attributes.Append(xmlAttribute);

            xmlAttribute = p_xml.CreateAttribute("Description");
            xmlAttribute.Value = DICOM_element.DataSet_Description;
            xmlElement.Attributes.Append(xmlAttribute);

            XmlNode xmlVR = p_xml.CreateElement("VR");
            xmlVR.InnerText = DICOM_element.vr;
            xmlElement.AppendChild(xmlVR);

            XmlNode xmlLength = p_xml.CreateElement("Length");
            xmlLength.InnerText = length.ToString();
            xmlElement.AppendChild(xmlLength);

            XmlNode xmlValue = p_xml.CreateElement("Value");
            xmlValue.InnerText = GetDataStr(Encoding.ASCII);
            xmlElement.AppendChild(xmlValue);

            return xmlElement;
        }
    }
}

// в воркинг форм добавить пикчербокс, реализовать вывод в xml: gr,el,vr,disc,length,datastr; public void SaveXML(string filename) fname передать из savedialog

