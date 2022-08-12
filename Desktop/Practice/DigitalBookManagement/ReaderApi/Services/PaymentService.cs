using ReaderApi.Models;


namespace ReaderApi.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly DbReaderContext _DbMasterContext;
        public PaymentService(DbReaderContext dbMasterContext)
        {
            _DbMasterContext = dbMasterContext;
        }
        public string AskRefund(PaymentDetails paymentDetails)
        {
            throw new NotImplementedException();
        }

        public string BuyBook(PaymentDetails paymentDetails)
        {
            try
            {
                _DbMasterContext.PaymentDetails.Add(paymentDetails);
                _DbMasterContext.SaveChanges();
                return "Book Purchased Succesfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public BooksDetails FindAllBooks(PaymentDetails paymentDetails)
        {
            throw new NotImplementedException();
        }

        public BooksDetails FindBooks(PaymentDetails paymentDetails)
        {
            throw new NotImplementedException();
        }
    }
}
