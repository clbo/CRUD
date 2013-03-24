using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for DalCreateUpdateDelete
/// </summary>
/// 
namespace clb.Dal
{
    public class DalCreateUpdateDelete : DalBaseConnection
    {
         public DalCreateUpdateDelete(string storedprocedure, DataTable datatable)
        {
            StoredProcedureProperty = storedprocedure;
            DataTableProperty = datatable;
        }

        public void CreateUpdateDelete()
        {
            Command();
            TilfoejParameters();
            _executequery = new ExecuteQuery(conn, cmd);
            _executequery.ExecuteNonQuery();
        }
    }
}