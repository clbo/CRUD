using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BL;

/// <summary>
/// Summary description for crud
/// </summary>
/// 
namespace DAL
{
    public class Crud
    {

        #region Properties & Fields

        private string StoredProcedureProperty { get; set; }
        private DataTable DataTableProperty { get; set; }

        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
        private SqlCommand cmd = new SqlCommand();

        #endregion

        #region Constructors

        public Crud(string storedprocedure)
        {
            StoredProcedureProperty = storedprocedure;
        }

        public Crud(string storedprocedure, DataTable datatable)
        {
            StoredProcedureProperty = storedprocedure;
            DataTableProperty = datatable;
        }

        #endregion

        #region Public Methods

        public void Insert()
        {
            Connection();
            TilfoejParameters();
            ExNoQuery();
        }

        public void Update()
        {
            Connection();
            TilfoejParameters();
            ExNoQuery();
        }

        public void Delete()
        {
            Connection();
            TilfoejParameters();
            ExNoQuery();
        }

        public DataTable Select()
        {
            Connection();
            TilfoejParameters();
            return Reader();
        }

        #endregion

        #region Private Methods

        private void Connection()
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedureProperty;

        }

        private void TilfoejParameters()
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

        private void ExNoQuery()
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private DataTable Reader()
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Tæl kolonnerne i udtrækket fra databasen
            int kolonner = reader.FieldCount;

            // Opret DataTable med X antal Kolonner  - Kalder statisk metode i BL namespace, CrateDataTable Class
            DataTable table = CreateDataTable.CreateDataTabelMethod(kolonner);

            while (reader.Read())
            {
                AddRowsToDataTableFromReader(reader, kolonner, table);
            }
            conn.Close();
            return table;
        }

        private static void AddRowsToDataTableFromReader(SqlDataReader reader, int kolonner, DataTable table)
        {
            object[] objarray = new object[kolonner];
            for (int i = 0; i < kolonner; i++)
            {
                objarray[i] = reader[i];
            }

            table.Rows.Add(objarray);
        }

        #endregion

    }
}