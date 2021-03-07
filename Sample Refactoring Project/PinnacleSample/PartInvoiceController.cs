namespace PinnacleSample
{
    public class PartInvoiceController
    {
        private ICreatePartInvoice _createpartinvoice;

        public PartInvoiceController(ICreatePartInvoice createpartinvoice)
        {
            _createpartinvoice = createpartinvoice;
        }

        public CreatePartInvoiceResult CreatePartInvoice(string stockCode, int quantity, string customerName)
        {
            
            return _createpartinvoice.CreatePartInvoice(stockCode, quantity, customerName);
        }

    }
}
