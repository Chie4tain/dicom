﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        isExplicitVR = dataset.DataStr == "1.2.840.10008.1.2.1";
                    }
                }

                do
                {
                    groupID = reader.ReadInt16().ToString("X4");
                    elementID = reader.ReadInt16().ToString("X4");

                    string vr = Encoding.ASCII.GetString(reader.ReadBytes(2));

                    uint length = ReadLength(vr);

                    byte[] data = reader.ReadBytes((int)length);

                    Add(new DICOM_Dataset(D_elements.Get_Element(groupID, elementID), length, data, this));
                } while (!(groupID == "0008" && elementID == "2111"));
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
            if (vr == "OB" || vr == "OW" || vr == "UN" || vr == "UT" || vr == "SQ")
            {
                reader.ReadBytes(2);

                result = reader.ReadUInt32();
            }
            else
                result = reader.ReadUInt16();
            return result;
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
            return result.Trim(new char[] {(char)0});
        }
    }
}
