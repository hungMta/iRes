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
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(proc, conn);
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            } catch (SqlException) {
                conn.Close();
                return null;
            }
        }

        public static DataTable GetDataByParameter(string proc, SqlParameter[] para) {
            try {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(para);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                conn.Close();
                return dataTable;
            } catch (SqlException) {
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
            } catch (SqlException) {
                conn.Close();
                return -1;
            }
        }
    }
}
