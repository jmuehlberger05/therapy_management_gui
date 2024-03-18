using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace therapy_management_gui
{
    public partial class EditCaseForm : Form
    {
        private Dictionary<int, string> patients;
        public CaseFormData Result;
        public CaseData caseData;

        public EditCaseForm(Dictionary<int, string> patients, CaseData caseData)
        {
            InitializeComponent();

            btn_cancel.DialogResult = DialogResult.No;

            this.patients = patients;
            this.caseData = caseData;
        }

        // Fill Fields with Data
        private void EditCaseForm_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> patient in patients)
            {
                cbx_patient.Items.Add(patient.Value);
            }


            tb_title.Text = caseData.Title;
            tb_description.Text = caseData.Description;
            cbx_patient.Text = patients[caseData.PatientId];
            nud_sessions.Value = caseData.Sessions;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            int patiendId = Util.FindKeyOfDictionary(cbx_patient.Text, patients);

            if (patiendId == -1)
            {
                MessageBox.Show("Kein valider Patient gefunden");
                return;
            }

            Result = new CaseFormData
            {
                PatientId = patiendId,
                Title = tb_title.Text,
                Description = tb_description.Text,
                Sessions = (int)nud_sessions.Value
            };

            DialogResult = DialogResult.OK;
        }
    }

    public class CaseData
    {
        public int Id;
        public string Title;
        public string Description;
        public int Sessions;
        public int PatientId;

        public CaseData() { }
    }
}
