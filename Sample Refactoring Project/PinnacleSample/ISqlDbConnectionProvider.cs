using System.Data;

namespace PinnacleSample
{
    public interface ISqlDbConnectionProvider
    {
        IDbConnection GetPersistantStorageConnection(string name);
    }
}