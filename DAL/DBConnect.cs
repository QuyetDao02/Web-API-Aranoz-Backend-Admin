using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con { get; set; }
        public string StringConnection { get; set; }
        public DBConnect(IConfiguration configuration)
        {
            StringConnection = configuration["ConnectionStrings:DefaultConnection"];
        }
        public void OpenConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(StringConnection);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void ExecuteProcedure(string nameprocedure, params object[] param)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameprocedure;
                cmd.Connection = con;
                cmd.Transaction = con.BeginTransaction();
                int paralength = param.Length / 2;
                int j = 0;
                for (int i = 0; i < paralength; i++)
                {
                    string paramname = Convert.ToString(param[j++]);
                    object value = param[j++];
                    cmd.Parameters.AddWithValue(paramname, value ?? DBNull.Value);
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Transaction.Commit();
            }
            catch
            {
                try
                {
                    cmd.Transaction.Rollback();
                }
                catch
                {

                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable ExcuteProcedureReturnDatatable(string nameprocedure, params object[] param)
        {
            DataTable data = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameprocedure;
                cmd.Connection = con;
                int paralength = (param.Length) / 2;
                int j = 0;
                for (int i = 0; i < paralength; i++)
                {
                    string paramname = Convert.ToString(param[j++]).Trim();
                    object value = param[j++];
                    //cmd.Parameters.AddWithValue(paramname, value ?? DBNull.Value);
                    cmd.Parameters.Add(new SqlParameter(paramname, value ?? DBNull.Value));
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                cmd.Dispose();
                adapter.Dispose();
            }
            catch
            {
                data = null;
            }
            return data;
        }
    }
}

