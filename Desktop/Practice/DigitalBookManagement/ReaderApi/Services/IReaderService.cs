using ReaderApi.Models;

namespace ReaderApi.Services
{
    public interface IReaderService
    {
      public  BooksDetails GetBooks(string bookId);
      public BooksDetails SearchBooks(string BookId, string Category, string AuthorId, string Publisher);
    }
}