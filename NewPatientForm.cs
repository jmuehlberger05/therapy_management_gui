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
    public partial class NewPatientForm : Form
    {
        public PatientFormData Result;
        private string filePath = "";

        public NewPatientForm()
        {
            InitializeComponent();

            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_submit.DialogResult = DialogResult.OK;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Result = new PatientFormData(tb_first_name.Text, tb_last_name.Text, tb_mail.Text, tb_tel.Text, dtp_birth_date.Value, filePath);
        }

        // Open File Explorer and set filePath
        private void btn_file_explorer_Click(object sender, EventArgs e)
        {
            // Create FileExplorer Instance
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Suche ein Foto aus";

            // open Explorer
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            { 
                filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                lbl_file_path.Text = filePath;
            }

        }
    }

    // Class for Formresult from NewPatientForm
    public class PatientFormData
    {
        public string firstName;
        public string lastName;
        public string eMail;
        public string tel;
        public DateTime birthDate;
        public string filePath;

        public PatientFormData(string firstName, string lastName, string eMail, string tel, DateTime birthDate, string filePath)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMail = eMail;
            this.tel = tel;
            this.birthDate = birthDate;
            this.filePath = filePath;
        }
    }
}
