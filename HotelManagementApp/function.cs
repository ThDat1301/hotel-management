using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"data source= LTFA_LT\SQLSERVER_151222;" +
                                    "database=hotelManagement;" +
                                    "integrated security= True;";
            return cnn;
        }
        
        public DataSet getData(String query)
        {
            SqlConnection cnn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= cnn;
            cmd.CommandText= query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection cnn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("'" + message + "'", "Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
