using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BL
/// </summary>
/// 
namespace clb.Bll
{
    public class CreateDataTable
    {
        public static DataTable CreateDataTabelWithParameterNumberOfColumns(int length)
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < length; i++)
            {
                dt.Columns.Add();
            }
            return dt;
        }

        public static void AddRowsToDatatableFromReader(SqlDataReader reader, int columns, DataTable table)
        {
            while (reader.Read())
            {
                object[] objarray = new object[columns];
                for (int i = 0; i < columns; i++)
                {
                    objarray[i] = reader[i];
                }

                table.Rows.Add(objarray);
            }

        }
    }
}