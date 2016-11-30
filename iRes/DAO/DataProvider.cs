using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title.Config;

namespace Title.DAO {
    public class DataProvider {
        private static SqlConnection conn;
        public static Configuration config = new Configuration();

        public static SqlConnection Connect() {
            try {
                SqlConnection conn = new SqlConnection(config.DATA_SOURCE);
                conn.Open();
                return conn;
            } catch (SqlException) {
                return null;
            }
        }

        public static DataTable GetData(string proc) {
            try {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            } catch (SqlException) {
                conn.Close();
                return null;
            }
        }

        public static DataTable GetDataAndImage(string proc)
        {
            try
            {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(proc, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }

        public static int ExecuteNonQuery(string proc, SqlParameter[] para) {
            try {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            } catch (Exception e) {
                return -1;
            }
        }
    }
}
