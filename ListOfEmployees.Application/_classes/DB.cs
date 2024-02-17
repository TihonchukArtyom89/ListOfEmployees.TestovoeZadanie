using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//local DB0
using System.Data;//ConnectionSate, DataTable

namespace ListOfEmployees.Application._classes
{
    public static class DB
    {
        public static SqlConnection GetDBConnection()
        {

        }
        public static DataTable GetDataTable()
        {
            SqlConnection connection = GetDBConnection();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}


