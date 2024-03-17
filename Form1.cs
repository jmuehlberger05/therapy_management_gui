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

            if (data.Rows.Count > 0)
            {
                populateDataGridView(view, data);
                return data;
            }
            else return new DataTable();

        }

        // Fill DataGridView with Data
        private void populateDataGridView (DataGridView view, DataTable data)
        {
            view.DataSource = data;
        }
    }
}
