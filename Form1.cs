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

        private void Form1_Load(object sender, EventArgs e)
        {
            databaseConnection = new DBConnect();
        }

        private void btn_refresh_patients_Click(object sender, EventArgs e)
        {
            DataTable patients = new DataTable();

            patients = databaseConnection.Select("SELECT * FROM patients");

            if (patients.Rows.Count > 0)
            {
                dgv_patients.DataSource = patients;
            }
        }
    }
}
