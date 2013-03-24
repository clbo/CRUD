using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for DalRead
/// </summary>
/// 
namespace clb.Dal
{
    public class DalRead : DalBaseConnection
    {
        public DalRead(string storedprocedure)
        {
            StoredProcedureProperty = storedprocedure;
        }

        public DalRead(string storedprocedure, DataTable datatable)
        {
            StoredProcedureProperty = storedprocedure;
            DataTableProperty = datatable;
        }

        public DataTable Select()
        {
            Command();
            TilfoejParameters();
            _executequery = new ExecuteQuery(conn, cmd);
            return _executequery.Reader();
        }
    }
}