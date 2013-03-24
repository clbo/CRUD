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

        public SqlConnection Conn { get; set; }
        public SqlCommand Cmd { get; set; }

        public ExecuteQuery(SqlConnection conn, SqlCommand cmd)
        {
            Conn = conn;
            Cmd = cmd;
        }

        public void ExecuteNonQuery()
        {
            Conn.Open();
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public DataTable Reader()
        {
            Conn.Open();
            SqlDataReader reader = Cmd.ExecuteReader();

            int columnsinreader = reader.FieldCount;

            DataTable table = CreateDataTable.CreateDataTabelWithParameterNumberOfColumns(columnsinreader);
            CreateDataTable.AddRowsToDatatableFromReader(reader, columnsinreader, table);

            Conn.Close();
            return table;
        }




    }
}