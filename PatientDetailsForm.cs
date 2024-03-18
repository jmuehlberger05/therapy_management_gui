using MySqlX.XDevAPI.Common;
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
        public PatientFormData UpdateResult;
        public string filePath = "";
        public PatientDetailsForm(PatientData data)
        {
            InitializeComponent();
            Patient = data;

            btn_update.DialogResult = DialogResult.OK;
            btn_delete.DialogResult = DialogResult.No;

        }

        private void PatientDetailsForm_Load(object sender, EventArgs e)
        {
            tb_first_name.Text = Patient.FirstName;
            tb_last_name.Text = Patient.LastName;
            tb_tel.Text = Patient.Phone;
            tb_mail.Text = Patient.EMail;
            dtp_birth_date.Value = DateTime.Parse(Patient.BirthDate);

            if (Patient.Photo != null)
                pb_patient_details.Image = Util.ConvertBinaryToImage(Patient.Photo);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateResult = new PatientFormData(tb_first_name.Text, tb_last_name.Text, tb_mail.Text, tb_tel.Text, dtp_birth_date.Value, filePath);
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UpdateResult = new PatientFormData(tb_first_name.Text, tb_last_name.Text, tb_mail.Text, tb_tel.Text, dtp_birth_date.Value, filePath);
            this.Close();
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
