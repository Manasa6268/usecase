using AuthourApi.Model;

namespace AuthourApi.Services
{
    public interface IAuthourService
    {
       public string BlockUnblockBook(string bookId, bool status);
        public string CreateBook(BooksDetails books);
        public string EditBook(string id, BooksDetails booksDetails);
        public BooksDetails GetBooks(int authourId);
    }
}