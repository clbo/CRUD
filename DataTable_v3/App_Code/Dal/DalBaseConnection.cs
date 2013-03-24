using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using clb.Bll;


namespace clb.Dal
{
    public abstract class DalBaseConnection
    {
        protected string StoredProcedureProperty { get; set; }
        protected DataTable DataTableProperty { get; set; }
        public SqlConnection conn { get; private set; }
        public SqlCommand cmd { get; set; }

        protected ExecuteQuery _executequery;
        private TypeOfCommand _command;

        public DalBaseConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        protected void Command()
        {
            _command = new TypeOfCommand(StoredProcedureProperty, cmd);
            cmd = _command.TypeAfKomando();
        }

        protected void TilfoejParameters()
        {
            if (DataTableProperty != null)
            {
                DataRow[] result = DataTableProperty.Select();
                foreach (DataRow row in result)
                {
                    for (int i = 1; i <= row.ItemArray.Length; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + i.ToString(), row[i - 1]);
                    }
                }
            }
        }
    }
}