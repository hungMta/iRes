using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iRes.Configuration;

namespace Login.Test
{
    class ConfigurationTest
    {
        public void TestGetDatabaseName()
        {
            Configuration config = new Configuration();
            Console.Write(config.GetDatabaseName());
        }
    }
}
