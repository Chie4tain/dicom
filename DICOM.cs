using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicom
{
    internal class DICOM : List<DICOM_Dataset>
    {
        string filename;
        BinaryReader reader;
        public DICOM(string fname, DICOM_elements D_elements)
        {
            filename = fname;
            reader = new BinaryReader(File.Open(filename, FileMode.Open));
            if(is_dicom())
            {
                reader.ReadBytes(8); // пропускаем номер группы номер элемента vr и длину значения (2 байта)
                uint length_0002 = reader.ReadUInt32();
                Add(new DICOM_Dataset(D_elements.Get_Element("0002", "0000"), 4, BitConverter.GetBytes(length_0002)));

                long group_0002_end = reader.BaseStream.Position + length_0002;
                
                while (reader.BaseStream.Position < group_0002_end)
                {
                    string groupID = reader.ReadInt16().ToString("X4");
                    string elementID = reader.ReadInt16().ToString("X4");
                    string vr = Encoding.ASCII.GetString(reader.ReadBytes(2));

                }
            }
            else
            {
                reader.Close();
                throw new FormatException("Is not a DICOM file");
            }     
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
        public DICOM_element DICOM_element;
        public uint length;
        public byte[] data;

        public DICOM_Dataset(DICOM_element p_DICOM_element, uint length, byte[] data)
        {
            DICOM_element = p_DICOM_element;
            this.length = length;
            this.data = data;
        }
    }
}
// дз: добавить форму справка в которую будут выводиться значения dicom_elements элемент формы datagridview и его заполнить
/*резиновая форма*/