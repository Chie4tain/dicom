using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicom
{
    internal class DICOM
    {
        string filename;
        BinaryReader reader;
        public DICOM(string fname)
        {
            filename = fname;
            reader = new BinaryReader(File.Open(filename, FileMode.Open));
            if(!is_dicom())
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
}
