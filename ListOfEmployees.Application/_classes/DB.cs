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
            string connectionString = Properties.Settings.Default.connection_String;
            SqlConnection connectionSQL = new SqlConnection(connectionString);
            if(connectionSQL.State != ConnectionState.Open)
            {
                connectionSQL.Open();
            }
            return connectionSQL;
        }
        public static DataTable GetDataTable(string sqlCommand)
        {
            SqlConnection connectionSQL = GetDBConnection();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connectionSQL);
            adapter.Fill(dataTable);
            return dataTable;
        }
        public static void ExecuteSql(string sqlCommandText)
        {
            SqlConnection connectionSQL = GetDBConnection();
            SqlCommand sqlCommand = new SqlCommand(sqlCommandText, connectionSQL);
            sqlCommand.ExecuteNonQuery();
        }
        public static void CloseDBConnection()
        {
            string connectionString = Properties.Settings.Default.connection_String;
            SqlConnection connectionSQL = new SqlConnection(connectionString);
            if (connectionSQL.State != ConnectionState.Closed)
            {
                connectionSQL.Close();
            }
        }
    }
}


