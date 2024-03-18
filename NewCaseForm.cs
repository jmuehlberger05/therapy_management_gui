using System;
using System.Collections;
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
    public partial class NewCaseForm : Form
    {
        private Dictionary<int, string> patients;
        public CaseFormData Result;

        public NewCaseForm(Dictionary<int, string> patients)
        {
            InitializeComponent();

            btn_cancel.DialogResult = DialogResult.Cancel;

            this.patients = patients;
        }

        private void NewCaseForm_Load(object sender, EventArgs e)
        {
            foreach(KeyValuePair<int, string> patient in patients) {
                cbx_patient.Items.Add(patient.Value);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int patiendId = Util.FindKeyOfDictionary(cbx_patient.Text, patients);

            if (patiendId == -1) {
                MessageBox.Show("Kein valider Patient gefunden");
                return;
            }

            Result = new CaseFormData {
                PatientId = patiendId,
                Title = tb_title.Text,
                Description = tb_description.Text,
                Sessions = (int)nud_sessions.Value
            };

            DialogResult = DialogResult.OK;
        }
    }

    public class CaseFormData
    {
        public int PatientId;
        public string Title;
        public string Description;
        public int Sessions;
        public CaseFormData() { }
    }
}
