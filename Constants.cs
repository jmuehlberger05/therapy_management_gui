using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace therapy_management_gui
{
    public static class Constants
    {
        // Database Connection
        public const string MYSQL_INSTANCE_HOST = "MacBook-Air-von-Jakob.local";
        public const uint MYSQL_INSTANCE_PORT = 3306;
        public const string MYSQL_INSTANCE_UID = "application";
        public const string MYSQL_INSTANCE_PASSWORD = "Application1!";
        public const string MYSQL_INSTANCE_DATABASE = "therapy_management";

        // Database Tables
        public const string DATABASE_TABLE_PATIENTS = "patients";
        public const string DATABASE_TABLE_ADDRESSES = "addresses";
        public const string DATABASE_TABLE_CASES = "cases";
        public const string DATABASE_TABLE_APPOINTMENTS = "appointments";
        public const string DATABASE_TABLE_COUNTRYS = "countrys";

    }
}
