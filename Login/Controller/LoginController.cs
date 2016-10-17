using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Database;
using System.Data;
using iRes.Configuration;

namespace Login.LoginController
{
    public class Login
    {
        private static Configuration config = new Configuration();
        /// <summary>
        /// Singleton Class
        /// </summary>
        
        private static Login instance;

        private Login()
        {

        }

        private static Login Intance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }

        public static int CheckLogin(String username, String password)
        { 
            Console.WriteLine(username);
            Console.WriteLine(password);
            int resConnect = Database.Database.Connect(config.GetDatabaseName());
            int isValid = -1;
            if (resConnect == 1)
            {
                DataTable dataTable = Database.Database.Read(config.GetAccountTableName());
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    if (dataTable.Rows[i][1].ToString() == username && (string)dataTable.Rows[i][2].ToString() == password)
                    {
                        isValid = 1;
                        break;
                    }
            }
            return isValid;
        }

    }
}
