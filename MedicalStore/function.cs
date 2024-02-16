using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public class function
    {
        public SqlConnection getConnection()
        {
            SqlConnection connectDB = new SqlConnection(@"Server=AKSHAY\SQLEXPRESS;Database=medicalStoreDatabse;Trusted_Connection=True");
            return connectDB;
        }

        public DataSet getTableData(string query)
        {
            SqlConnection connectDB = getConnection();
            SqlCommand cmd = new SqlCommand(query, connectDB);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public SqlDataReader getSingleData(string query)
        {
            SqlConnection connectDB = getConnection();
            connectDB.Open();

            SqlCommand cmd = new SqlCommand(query, connectDB);

            SqlDataReader dr = cmd.ExecuteReader();
            
            return dr;
        }

        //public void setData(string query, string message
        public void setData(string query)
        {
            SqlConnection connectDB = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectDB;
            connectDB.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connectDB.Close();

            //MessageBox.Show(message, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
