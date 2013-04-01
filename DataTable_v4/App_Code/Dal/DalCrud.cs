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
    public class DalCrud : MsSqlBaseConnection
    {
        public DalCrud(string storedprocedure)
            : base(storedprocedure)
        {
        }

        public DalCrud(string storedprocedure, DataTable datatable)
            : base(storedprocedure, datatable)
        {
        }

        public DataTable Select()
        {
            return executequery.Reader();
        }

        public void CreateOrUpdateOrDelete()
        {
            executequery.ExecuteNonQuery();
        }

    }
}