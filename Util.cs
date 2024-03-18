using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace therapy_management_gui
{
    internal static class Util
    {
        // Read a Filepath and then convert it to a byte Array
        public static byte[] ReadImageAndConvertToBinary(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] ImageData = br.ReadBytes((int)fs.Length);

            fs.Close();
            br.Close();

            return ImageData;
        }

        // Convert a binary Image and convert it to a drawing
        public static Image ConvertBinaryToImage(byte[] data)
        {
            MemoryStream buf = new MemoryStream(data);

            return (Image.FromStream(buf));
        }
       
        // Find Key of a certain Value
        public static int FindKeyOfDictionary(string input, Dictionary<int, string> dictionary)
        {
            if (!dictionary.ContainsValue(input)) return -1;

            foreach (var pair in dictionary)
            {
                if (pair.Value == input)
                {
                    return pair.Key;
                }
            }

            return -1;
        }
    }
}
