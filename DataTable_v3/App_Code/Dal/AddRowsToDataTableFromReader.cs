﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddRowsToTableFromReader
/// </summary>
/// 
namespace clb.Dal
{
    public class AddRowsToDataTableFromReader
    {
        //public SqlDataReader readerProperty { get; set; }
        //public int antalKolonnerProperty { get; set; }
        //public DataTable dataTableProperty { get; set; }

        public AddRowsToDataTableFromReader()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static void AddRowsToDatatableFromReader(SqlDataReader reader, int kolonner, DataTable table)
        {
            object[] objarray = new object[kolonner];
            for (int i = 0; i < kolonner; i++)
            {
                objarray[i] = reader[i];
            }

            table.Rows.Add(objarray);
        }


    }
}