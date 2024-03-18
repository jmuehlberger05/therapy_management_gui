using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private DBConnect databaseConnection;
        public Form1()
        {
            InitializeComponent();
        }

        // Init DB-Connection and fetch Tables
        private void Form1_Load(object sender, EventArgs e)
        {
            databaseConnection = new DBConnect();
            fetchData();
        }

        // Refresh Patients Table
        private void btn_refresh_patients_Click(object sender, EventArgs e)
        {
            selectDataThenPopulateView(Queries.selectPatientsForView, dgv_patients);
        }

        // Refresh Cases Table
        private void btn_refresh_cases_Click(object sender, EventArgs e)
        {
            selectDataThenPopulateView(Queries.selectCasesForView, dgv_cases);
        }

        // Add new Patient to Database
        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            DialogResult result = newPatientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PatientFormData patient = newPatientForm.Result;
                string query = "";

                // Check if filePath exists
                // If Not, insert Patient normally
                if (patient.filePath == "")
                {
                    query = $@"INSERT INTO {Constants.DATABASE_TABLE_PATIENTS} (first_name, last_name, phone, email, birth_date) VALUES 
                              ('{patient.firstName}', '{patient.lastName}', '{patient.tel}', '{patient.eMail}', '{patient.birthDate.ToString("yyyy-MM-dd")}')";

                    databaseConnection.ExecuteSQLStatement(query);
                } 
                // if Yes, Then covert image to binary and insert with Photo
                else
                {
                    try
                    {

                        query = $@"INSERT INTO {Constants.DATABASE_TABLE_PATIENTS} (first_name, last_name, phone, email, birth_date, photo) VALUES 
                                         ('{patient.firstName}', '{patient.lastName}', '{patient.tel}', '{patient.eMail}', '{patient.birthDate.ToString("yyyy-MM-dd")}', @photo)";

                        var command = new MySqlCommand(query, databaseConnection.Connection);
                        command.Parameters.Add("@photo", MySqlDbType.MediumBlob);
                        command.Parameters["@photo"].Value = Util.ReadImageAndConvertToBinary(patient.filePath);

                        if (databaseConnection.ExecuteMySQLCommand(command) > 0)
                        {
                            MessageBox.Show("Saving Successful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }  
            }

            newPatientForm.Dispose();
            fetchData();
        }

        // Add new Case to Database
        private void btn_add_case_Click(object sender, EventArgs e)
        {
            DataTable patientsTable = databaseConnection.Select(Queries.selectPatientsForSelect);
            NewCaseForm newCaseForm = new NewCaseForm(ConvertDataTableToDictionary(patientsTable));
            DialogResult result = newCaseForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                CaseFormData caseData = newCaseForm.Result;
                string query = $@"INSERT INTO cases (patient_id, title, description, n_sessions)
                                  VALUES ({caseData.PatientId}, '{caseData.Title}', '{caseData.Description}', {caseData.Sessions});";

                databaseConnection.ExecuteSQLStatement(query);
            }

            newCaseForm.Dispose();
            fetchData();
        }

        // Search Functionality
        private void btn_search_Click(object sender, EventArgs e)
        {
            // Searches for a simple string in tables "patients" and "cases" then displays the results

            string searchTerm = tb_search.Text;

            string patientsQuery = $@"SELECT id, first_name, last_name, phone, email, birth_date FROM {Constants.DATABASE_TABLE_PATIENTS} 
                                      WHERE first_name LIKE '%{searchTerm}%' 
                                      OR last_name LIKE '%{searchTerm}%';";

            string caseQuery = $@"SELECT c.id, c.title AS titel, c.description AS beschreibung, CONCAT(p.first_name, ' ', p.last_name) AS patient, c.n_sessions AS termine 
                                  FROM {Constants.DATABASE_TABLE_CASES} c 
                                  JOIN {Constants.DATABASE_TABLE_PATIENTS} p ON c.patient_id = p.id
                                  WHERE c.title LIKE '%{searchTerm}%' 
                                  OR c.description LIKE '%{searchTerm}%' 
                                  OR CONCAT(p.first_name, ' ', p.last_name) LIKE '%{searchTerm}%';";

            selectDataThenPopulateView(patientsQuery, dgv_patients);
            selectDataThenPopulateView(caseQuery, dgv_cases);
        }

        // Open Patient Details Window on DataGridView Doubleclick
        private void dgv_patients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if Rowindex is valid
            if (e.RowIndex <= 0) return;
            
            // Access the DataGridView
            var dgv = sender as DataGridView;
            if (dgv == null) return;
                
            // Access the clicked Row
            var row = dgv.Rows[e.RowIndex];
            var cellValue = (int)row.Cells[0].Value;

            // Get specific Data from Database
            DataTable data = databaseConnection.Select($"SELECT * FROM {Constants.DATABASE_TABLE_PATIENTS} WHERE id = {cellValue};");
            var dataRow = data.Rows[0];

            // Convert to PatientData
            PatientData patientData = new PatientData
            {
                Id = Convert.ToInt32(dataRow["id"]), // Adjust column names as per your database schema
                FirstName = dataRow["first_name"].ToString(),
                LastName = dataRow["last_name"].ToString(),
                EMail = dataRow["email"].ToString(),
                Phone = dataRow["phone"].ToString(),
                BirthDate = dataRow["birth_date"].ToString(),
                Photo = dataRow["photo"] as byte[] // Assuming 'photo' is stored as a byte array in your DB
            };

            // Show Details Dialog
            PatientDetailsForm patientDetails = new PatientDetailsForm(patientData);
            DialogResult result = patientDetails.ShowDialog();

            // "OK" = Update Patient; "No" = Delete Patient
            if (result == DialogResult.OK)
            {
                var newPatientValues = patientDetails.UpdateResult;
                string updateQuery = $@"UPDATE {Constants.DATABASE_TABLE_PATIENTS}
                                        SET
                                            first_name = '{newPatientValues.firstName}',
                                            last_name = '{newPatientValues.lastName}',
                                            phone = '{newPatientValues.tel}',
                                            email = '{newPatientValues.eMail}',
                                            birth_date = '{newPatientValues.birthDate.ToString("yyyy-MM-dd")}'
                                        WHERE id = {patientDetails.Patient.Id};";

                databaseConnection.ExecuteSQLStatement(updateQuery);
            } 
            else if (result == DialogResult.No)
            {
                string deleteQuery = $"DELETE from {Constants.DATABASE_TABLE_PATIENTS} WHERE id = {patientDetails.Patient.Id};";
                databaseConnection.ExecuteSQLStatement(deleteQuery);
            }

            patientDetails.Dispose();
            fetchData();
        }

        // Open CaseDetails on DoubleClick of Table
        private void dgv_cases_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if Rowindex is valid
            if (e.RowIndex <= 0) return;

            // Access the DataGridView
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            // Access the clicked Row
            var row = dgv.Rows[e.RowIndex];
            var cellValue = (int)row.Cells[0].Value;

            // Get specific Data from Database
            DataTable data = databaseConnection.Select($"SELECT * FROM {Constants.DATABASE_TABLE_CASES} WHERE id = {cellValue};");
            var dataRow = data.Rows[0];

            var caseData = new CaseData
            {
                Id = Convert.ToInt32(dataRow["id"]),
                PatientId = Convert.ToInt32(dataRow["patient_id"]),
                Title = dataRow["title"].ToString(),
                Description = dataRow["description"].ToString(),
                Sessions = Convert.ToInt32(dataRow["n_sessions"]),
            };

            DataTable patientsTable = databaseConnection.Select(Queries.selectPatientsForSelect);

            EditCaseForm editCaseForm = new EditCaseForm(ConvertDataTableToDictionary(patientsTable), caseData);
            DialogResult result = editCaseForm.ShowDialog();

            // "OK" = Update Patient; "No" = Delete Patient
            if (result == DialogResult.OK)
            {
                var newCaseValues = editCaseForm.Result;

                string updateQuery = $@"UPDATE {Constants.DATABASE_TABLE_CASES}
                                        SET
                                            patient_id = '{newCaseValues.PatientId}',
                                            title = '{newCaseValues.Title}',
                                            description = '{newCaseValues.Description}',
                                            n_sessions = '{newCaseValues.Sessions}'
                                        WHERE id = {editCaseForm.caseData.Id};";

                databaseConnection.ExecuteSQLStatement(updateQuery);
            }
            else if (result == DialogResult.No)
            {
                string deleteQuery = $"DELETE from {Constants.DATABASE_TABLE_CASES} WHERE id = {editCaseForm.caseData.Id};";
                databaseConnection.ExecuteSQLStatement(deleteQuery);
            }

            fetchData();
        }


        #region Local Utility Functions


        // Select Data from Database, then fill it in a DataGridView
        private DataTable selectDataThenPopulateView(string query, DataGridView view)
        {
            DataTable data = databaseConnection.Select(query);

            populateDataGridView(view, data);
            return data;
        }


        // Fill DataGridView with Data
        private void populateDataGridView(DataGridView view, DataTable data)
        {
            view.DataSource = data;
        }

        // Fetch the Tables on the Homepage and populate them
        private void fetchData()
        {
            selectDataThenPopulateView(Queries.selectPatientsForView, dgv_patients);
            selectDataThenPopulateView(Queries.selectCasesForView, dgv_cases);
        }

        // Convert PatientsTable to Dictionary
        private Dictionary<int, string> ConvertDataTableToDictionary(DataTable input)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (DataRow row in input.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();

                if (!dict.ContainsKey(id))
                {
                   dict.Add(id, name);
                }
            }

            return dict;
        }


        #endregion
    }
}
