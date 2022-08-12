using ReaderApi.Models;

namespace ReaderApi.Services
{
    public interface IPaymentService
    {
        string AskRefund(PaymentDetails paymentDetails);
        string BuyBook(PaymentDetails paymentDetails);
        BooksDetails FindAllBooks(PaymentDetails paymentDetails);
        BooksDetails FindBooks(PaymentDetails paymentDetails);
    }
}