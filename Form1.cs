using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
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

        // Fetch the Tables on the Homepage and populate them
        private void fetchData()
        {
            selectDataThenPopulateView(Queries.selectPatientsForView, dgv_patients);
            selectDataThenPopulateView(Queries.selectCasesForView, dgv_cases);
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

        // Select Data from Database, then fill it in a DataGridView
        private DataTable selectDataThenPopulateView(string query, DataGridView view)
        {
            DataTable data = databaseConnection.Select(query);

            populateDataGridView(view, data);
            return data;
        }

        // Fill DataGridView with Data
        private void populateDataGridView (DataGridView view, DataTable data)
        {
            view.DataSource = data;
        }

        // Add new Patient to Database
        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            DialogResult result = newPatientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Patient patient = newPatientForm.Result;
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
                        command.Parameters["@photo"].Value = readImageAndConvertToBinary(patient.filePath);

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
        }

        // Search Functionality
        private void bt_search_Click(object sender, EventArgs e)
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

        private byte[] readImageAndConvertToBinary (string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] ImageData = br.ReadBytes((int)fs.Length);

            fs.Close();
            br.Close();

            return ImageData;
        }
    }
}
