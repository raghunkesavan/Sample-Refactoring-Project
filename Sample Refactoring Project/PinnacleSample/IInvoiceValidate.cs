namespace PinnacleSample
{
    public interface IInvoiceValidate
    {
        CreatePartInvoiceResult ValidateInvoice(string stockCode, int quantity, Customer customer);
    }
}