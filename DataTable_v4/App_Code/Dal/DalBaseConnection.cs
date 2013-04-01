using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//using clb.Bll;


namespace clb.Dal
{
    public abstract class MsSqlBaseConnection
    {
        private string storedprocedure;
        private DataTable datatable;
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
        private SqlCommand cmd = new SqlCommand();

        protected ExecuteQuery executequery;
       
        public MsSqlBaseConnection(string storedprocedure)
        {
            this.storedprocedure = storedprocedure;
            ConnectionComandParametersAndQuery();
        }
        public MsSqlBaseConnection(string storedprocedure, DataTable datatable)
        {
            this.storedprocedure = storedprocedure;
            this.datatable = datatable;
            ConnectionComandParametersAndQuery();
        }

        private void ConnectionComandParametersAndQuery()
        {
            //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
            //cmd = new SqlCommand();
            cmd.Connection = conn;
            Command.TypeOfCommandAndCommandText(cmd, storedprocedure);   
            Parameters.MsSqlParametersAdd(datatable, cmd);
            executequery = new ExecuteQuery(conn, cmd);
        }
    }
}