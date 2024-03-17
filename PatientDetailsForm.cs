using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace therapy_management_gui
{
    public partial class PatientDetailsForm : Form
    {
        public PatientData Patient;

        public PatientDetailsForm(PatientData data)
        {
            InitializeComponent();
            Patient = data;

            this.Name = $"{data.FirstName} {data.LastName}";

            if (data.Photo != null)
                pb_patient_details.Image = ConvertBinaryToImage(data.Photo);
        }

        private Image ConvertBinaryToImage(byte[] data)
        {
            MemoryStream buf = new MemoryStream(data);

            return (Image.FromStream(buf));
        }
    }

    public class PatientData
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string EMail;
        public string Phone;
        public string BirthDate;
        public byte[] Photo;

        public PatientData() { }
    }
}
