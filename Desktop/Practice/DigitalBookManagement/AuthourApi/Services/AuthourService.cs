using AuthourApi.Model;


namespace AuthourApi.Services
{
    public class AuthourService : IAuthourService
    {
        private readonly DbAuthorContext _DbMasterContext;
        public AuthourService(DbAuthorContext dbMasterContext)
        {
            _DbMasterContext = dbMasterContext;
        }

        public string CreateBook(BooksDetails books)
        {
            try { 
            _DbMasterContext.BooksDetails.Add(books);
            _DbMasterContext.SaveChanges();
            return "Book added Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public string EditBook(string id, BooksDetails booksDetails)
        {
            try
            { 
            var book = _DbMasterContext.BooksDetails
                .FirstOrDefault(s => s.BookId.Equals(id));

            book.BookId = booksDetails.BookId;
            book.Logo = booksDetails.Logo;
            book.Title = booksDetails.Title;
            book.Category = booksDetails.Category;
            book.Price = booksDetails.Price;
            book.AuthorId = booksDetails.AuthorId;
            book.Publisher = booksDetails.Publisher;
            book.PublishDate = DateTime.UtcNow;
            book.Content = booksDetails.Content;
            book.Active = booksDetails.Active;
            book.ModifiedDate = DateTime.UtcNow;

            _DbMasterContext.SaveChanges();

            return "Books details Updated Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public string BlockUnblockBook(string bookId, bool status)
        {
            try
            {
                int activeid;
                var book = _DbMasterContext.BooksDetails.Find(bookId);
                if (status == true)
                    activeid = 1;
                else
                    activeid = 0;
                book.Active = activeid;
                _DbMasterContext.BooksDetails.Update(book);
                _DbMasterContext.SaveChanges();
                return "Book Blocked or Unblocked Succesfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public BooksDetails GetBooks(int authourId)
        {
            try
            {
                return _DbMasterContext.BooksDetails.Find(authourId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
    public class AccountsService : IAccountsService
    {
        private readonly DbAuthorContext _DbMasterContext;
        public AccountsService(DbAuthorContext dbMasterContext)
        {
            _DbMasterContext = dbMasterContext;
        }

        public string CreateAccount(UserDetails userDetails)
        {
            try
            {
                _DbMasterContext.Add(userDetails);
                _DbMasterContext.SaveChanges();
                return "Account Successfully Created";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public List<UserDetails> ValidateAccount(string? userName, string? password)
        {
            try { 
            var status = _DbMasterContext.UserDetails.Where(x => x.UserName == userName && x.Password == password).First();
            if (status != null)
            {
                return _DbMasterContext.UserDetails.ToList();
            }
            else
            {
                return null;
            }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }


        public string checkaccount(string? username, string password)
        {
            try { 
            var status = _DbMasterContext.UserDetails.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            if (status != null)
            {
                return "Account Successfully loggedin";
            }
            else
            {
                return "Please enter vaild login credentials";
            }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
