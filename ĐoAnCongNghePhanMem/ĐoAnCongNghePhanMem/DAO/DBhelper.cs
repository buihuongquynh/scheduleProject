using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DAO
{
    public class DBhelper
    {
        private static DBhelper _Instance;
        public SqlConnection cnn { get; set; }
        public static DBhelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=.;Initial Catalog=PBL3;Integrated Security=True";
                    _Instance = new DBhelper(cnnstr);
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public DBhelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public DataTable GetRecord(string query)
        {
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(data);
            cnn.Close();
            return data;
        }
        public bool Execute(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                if (cmd.ExecuteNonQuery() < 0) return false;
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
