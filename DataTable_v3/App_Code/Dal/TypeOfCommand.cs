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
    public class TypeOfCommand
    {
        public SqlCommand CmdProperty { get; set; }
        public string StoredProcedureProperty { get; set; }

        public TypeOfCommand(string storedprocedure, SqlCommand cmd)
        {
            CmdProperty = cmd;
            StoredProcedureProperty = storedprocedure;
        }

        public SqlCommand TypeAfKomando()
        {
            if (StoredProcedureProperty.StartsWith("SP_"))
            {
                CmdProperty.CommandType = CommandType.StoredProcedure;
                CmdProperty.CommandText = StoredProcedureProperty;
            }
            else
            {
                CmdProperty.CommandText = StoredProcedureProperty;
            }

            return CmdProperty;
        }

    }
}