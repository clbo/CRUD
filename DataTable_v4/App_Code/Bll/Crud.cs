using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using clb.Dal;

/// <summary>
/// Summary description for Crud
/// </summary>
/// 
namespace clb.Bll
{
    public class Crud
    {
        private string storedprocedure;
        private DataTable datatable;
        private DalCrud dalcrud;

        public Crud(string storedprocedure)
        {
            this.storedprocedure = storedprocedure;
        }

        public Crud(string storedprocedure, DataTable datatable)
        {
            this.storedprocedure = storedprocedure;
            this.datatable = datatable;
        }

        public void Insert() { dalcrud.CreateOrUpdateOrDelete(); }

        public DataTable Select()
        {
            if (datatable != null)
            {
                dalcrud = new DalCrud(storedprocedure, datatable);
            }
            else
            {
                dalcrud = new DalCrud(storedprocedure);
            }

            DataTable dt = dalcrud.Select();
            return dt;
        }

        public void Update() { dalcrud.CreateOrUpdateOrDelete(); }

        public void Delete() { dalcrud.CreateOrUpdateOrDelete(); }

    }


}