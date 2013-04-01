using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for TypeOfCommand
/// </summary>
/// 
namespace clb.Dal
{
    public class Command
    {
        public static SqlCommand TypeOfCommandAndCommandText(SqlCommand cmd, string storedprocedure)
        {
            if (storedprocedure.StartsWith("SP_"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedprocedure;
            }
            else
            {
                cmd.CommandText = storedprocedure;
            }

            return cmd;
        }
    }
}