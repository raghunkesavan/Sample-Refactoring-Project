
namespace PinnacleSample
{
     public interface ICreatePartInvoice
    {
        CreatePartInvoiceResult CreatePartInvoice(string stockCode, int quantity, string customerName);
    }
}
