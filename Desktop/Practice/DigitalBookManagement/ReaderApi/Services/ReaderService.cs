using ReaderApi.Models;


namespace ReaderApi.Services
{
    public class ReaderService : IReaderService
    {
        private readonly DbReaderContext _DbMasterContext;
        public ReaderService(DbReaderContext dbMasterContext)
        {
            _DbMasterContext = dbMasterContext;
        }

        public BooksDetails GetBooks(string bookId)
        {
            try
            {
                return _DbMasterContext.BooksDetails.Find(bookId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public BooksDetails SearchBooks(string BookId, string Category, string AuthorId, string Publisher)
        {
            try 
            { 
            BooksDetails booksDetails = _DbMasterContext.BooksDetails.Where(s => s.Equals(BookId)).FirstOrDefault<BooksDetails>();
            return booksDetails;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
