using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using clb.Bll;

/// <summary>
/// Summary description for Execute
/// </summary>
/// 
namespace clb.Dal
{
    public class ExecuteQuery
    {

        private SqlConnection conn; 
        private SqlCommand cmd; 

        public ExecuteQuery(SqlConnection conn, SqlCommand cmd)
        {
            this.conn = conn;
            this.cmd = cmd;
        }

        public void ExecuteNonQuery()
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Reader()
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            int columnsinreader = reader.FieldCount;

            DataTable table = CreateDataTable.CreateDataTabelWithParameterNumberOfColumns(columnsinreader);
            CreateDataTable.AddRowsToDatatableFromReader(reader, columnsinreader, table);

            conn.Close();
            return table;
        }




    }
}