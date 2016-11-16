using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Tutorial.SqlConn;
using iRes.Configuration;

namespace Login.Database
{
    public class Database {
        private static Configuration config = new Configuration();

        private static Database instance;

        private Database() {

        }

        private static Database Intance {
            get {
                if (instance == null) {
                    instance = new Database();
                }
                return instance;
            }
        }

        public static void Create() {
            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE MyDatabase ON PRIMARY " +
                "(NAME = MyDatabase_Data, " +
                "FILENAME = 'C:\\MyDatabaseData.mdf', " +
                "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = MyDatabase_Log, " +
                "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
                "SIZE = 1MB, " +
                "MAXSIZE = 5MB, " +
                "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex) {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                if (myConn.State == ConnectionState.Open) {
                    myConn.Close();
                }
            }
        }

        public static DataSet Read(string strTableName, string strQuerySelect) {
            SqlConnection conn = DBUtils.GetDBConnection(config.GetDatabaseName());
            SqlDataAdapter adapter = new SqlDataAdapter(strQuerySelect, conn);
            DataSet dataSet = new DataSet();
            try {
                conn.Open();
                adapter.Fill(dataSet, strTableName);
                Console.WriteLine("Get table");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally {
                conn.Close();
            }
            return dataSet;
        }

        public static int Update(string query) {
            SqlConnection conn = DBUtils.GetDBConnection(config.GetDatabaseName());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            int res = 1;
            try {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) {
                Console.Write(e.Message);
                res = -1;
            }
            return res;
        }

        public static int Delete(string query) {
            SqlConnection conn = DBUtils.GetDBConnection(config.GetDatabaseName());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            int res = 1;
            try {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) {
                Console.Write(e.Message);
                res = -1;
            }
            return res;
        }

    
    }
}
