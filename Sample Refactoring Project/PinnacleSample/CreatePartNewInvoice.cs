
namespace PinnacleSample
{
    public class CreatePartNewInvoice : ICreatePartInvoice
    {
        private readonly IInvoiceValidate _iinvoicevalidate;
        private readonly ICustomerRepositoryDB _customerrepositorydb;
        private readonly IPartInvoiceRepositoryDB _PartInvoiceRepository;

        public CreatePartNewInvoice(IInvoiceValidate iinvoicevalidate, 
                    ICustomerRepositoryDB customerrepositorydb,
                    IPartInvoiceRepositoryDB partinvoicerepository)
        {
            _iinvoicevalidate = iinvoicevalidate;
            _customerrepositorydb = customerrepositorydb;
            _PartInvoiceRepository = partinvoicerepository;
        }


        public CreatePartInvoiceResult CreatePartInvoice(string stockCode, int quantity, string customerName)
        {
            Customer _Customer = _customerrepositorydb.GetByName(customerName);

            CreatePartInvoiceResult createpartinvoiceresult = 
                _iinvoicevalidate.ValidateInvoice(stockCode, quantity, _Customer);
            
            if (!createpartinvoiceresult.Success) {
                return createpartinvoiceresult;
            }

            PartInvoice _PartInvoice = new PartInvoice
            {
                StockCode = stockCode,
                Quantity = quantity,
                CustomerID = _Customer.ID
            };

            _PartInvoiceRepository.Add(_PartInvoice);

            return new CreatePartInvoiceResult(true);
        }
    }
}
