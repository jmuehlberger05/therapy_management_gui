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
        public Patient Result;
        private string filePath = "";

        public NewPatientForm()
        {
            InitializeComponent();

            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_submit.DialogResult = DialogResult.OK;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Result = new Patient(tb_first_name.Text, tb_last_name.Text, tb_mail.Text, tb_tel.Text, dtp_birth_date.Value, filePath);
        }

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
            }

        }
    }

    public class Patient
    {
        public string firstName;
        public string lastName;
        public string eMail;
        public string tel;
        public DateTime birthDate;
        public string filePath;

        public Patient(string firstName, string lastName, string eMail, string tel, DateTime birthDate, string filePath)
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
