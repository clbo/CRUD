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
    public class ParametersAdd : DalBaseConnection
    {
        public DataTable DataTableProperty2 { get; set; }
        public ParametersAdd(DataTable dt)
        {
            DataTableProperty = dt;
        }

        public SqlCommand TilfoejParameters2()
        {
            if (DataTableProperty2 != null)
            {
                DataRow[] result = DataTableProperty2.Select();
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