using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PinnacleSample
{
    public class SqlDbConnectionProvider :  ISqlDbConnectionProvider
    {
        public IDbConnection GetPersistantStorageConnection(string name)
        {
            var strcon = StringconProvider(name);
            return new SqlConnection(strcon);
        }
        private string StringconProvider(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
