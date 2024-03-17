using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace therapy_management_gui
{
    internal class Queries
    {
        public static string selectPatientsForView = $"SELECT p.id, CONCAT(p.first_name, ' ',  p.last_name) AS name, p.phone AS Mobil, p.email AS 'E-Mail' " + 
                                                     $"FROM {Constants.DATABASE_TABLE_PATIENTS} p;";

        public static string selectCasesForView = $"SELECT c.id, c.title AS titel, c.description AS beschreibung, CONCAT(p.first_name, ' ',  p.last_name) AS patient, c.n_sessions AS termine " +
                                                  $"FROM {Constants.DATABASE_TABLE_CASES} c " +
                                                  $"JOIN {Constants.DATABASE_TABLE_PATIENTS} p on c.patient_id = p.id;";
    }
}
