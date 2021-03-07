namespace PinnacleSample
{
    public interface ICustomerRepositoryDB
    {
        Customer GetByName(string name);
    }
}