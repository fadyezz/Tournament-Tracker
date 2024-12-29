using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public class GlobalConfig
    {
        // private set here that only the method inside the class can set
        public static IDataConnection Connection { get;private set; }


        public static void IntializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql) 
            {
                // TODO - Create the SQL Connections
                SqlConnector sql = new SqlConnector();
                Connection=sql;

            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connections
                TextConnection text = new TextConnection();
                Connection = text;
            }



        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
    }
}
