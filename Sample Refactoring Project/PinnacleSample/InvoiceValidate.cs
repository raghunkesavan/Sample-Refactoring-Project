
namespace PinnacleSample
{
    public class InvoiceValidate : IInvoiceValidate
    {
         public CreatePartInvoiceResult ValidateInvoice(string stockCode, int quantity, Customer _Customer)
        {

            if (string.IsNullOrEmpty(stockCode))
            {
                return new CreatePartInvoiceResult(false);
            }

            if (quantity <= 0)
            {
                return new CreatePartInvoiceResult(false);
            }

            if (_Customer.ID <= 0)
            {
                return new CreatePartInvoiceResult(false);
            }

            using (PartAvailabilityServiceClient _PartAvailabilityService = new PartAvailabilityServiceClient())
            {
                int _Availability = _PartAvailabilityService.GetAvailability(stockCode);
                if (_Availability <= 0)
                {
                    return new CreatePartInvoiceResult(false);
                }
            }

            return new CreatePartInvoiceResult(true);

        }


    }
}
