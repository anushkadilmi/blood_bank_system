using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    internal class Function
    {
        private SqlConnection con;

        public Function()
        {
            con = getConnection();
        }

        public SqlConnection getConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LAPTOP-UL0VVV27";
            builder.InitialCatalog = "BloodBank";
            builder.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(builder.ConnectionString);
            return con;
        }

        public DataSet getData(string query)
        {
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public void SetData(string query, Dictionary<string, object> parameters)
        {
            using (SqlCommand com = new SqlCommand(query, con))
            {
                foreach (var parameter in parameters)
                {
                    com.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }

          
        }
    }
}



