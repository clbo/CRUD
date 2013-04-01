using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ParametersAdd
/// </summary>
/// 
namespace clb.Dal
{
    public class Parameters
    {
        public static SqlCommand MsSqlParametersAdd(DataTable datatable, SqlCommand cmd)
        {
            if (datatable != null)
            {
                DataRow[] result = datatable.Select();
                foreach (DataRow row in result)
                {
                    for (int i = 1; i <= row.ItemArray.Length; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + i.ToString(), row[i - 1]);
                    }

                }

            } return cmd;
        }
    }
}