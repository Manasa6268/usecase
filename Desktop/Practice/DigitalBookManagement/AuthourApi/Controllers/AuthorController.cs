using AuthourApi.Model;
using AuthourApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AuthourApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    
    public class AuthorController : ControllerBase
    {
        private readonly IAuthourService _authorService;
        private readonly IAccountsService _accountsService;
       

        public AuthorController(IAuthourService authorService, IAccountsService accountsService)
        {
            _authorService = authorService;
            _accountsService = accountsService;
            
        }

       /// <summary>
        /// Creates the account.
        /// </summary>
        /// <param name="userDetails">The user details.</param>
        /// <returns>ActionResult&lt;System.String&gt;.</returns>
        [HttpPost]
        [Route("signup")]
       
        public ActionResult<string> CreateAccount([FromBody] UserDetails userDetails)
        {
            try
            {
                return Ok(_accountsService.CreateAccount(userDetails));
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Check accounts the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>ActionResult&lt;System.String&gt;.</returns>
        [HttpGet]
        [Route("login")]
       [Authorize]
        public ActionResult<string> checksaccount(string? username, string password)
        {
            try 
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                UserClaims userClaims = VerifyUser(identity);
                if (userClaims.UserType == "author")
                {
                    return Ok(_accountsService.checkaccount(username, password));
                }
                else
                {
                    return "Login Unsuccessful";
                }
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Creates the book.
        /// </summary>
        /// <param name="books">The books.</param>
        /// <returns>ActionResult&lt;BooksDetails&gt;.</returns>
        [HttpPost]
        [Route("createbook")]
        [Authorize]
        public ActionResult<string> CreateBook([FromBody] BooksDetails books)
        {
            try 
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                UserClaims userClaims = VerifyUser(identity);
                if (userClaims.UserType == "Author")
                {
                    return _authorService.CreateBook(books);
                }
                else
                {
                    return "Only Author can create books";
                }
               
             }
            catch
            {
                return BadRequest();
            }
}
        /// <summary>
        /// Edits the book.
        /// </summary>
        /// <param name="bookId">The book identifier.</param>
        /// <param name="booksDetails">The books details.</param>
        /// <returns>ActionResult&lt;System.String&gt;.</returns>
        [HttpPut("{bookId}")]
        [Authorize]
        public ActionResult<string> EditBook(string bookId, [FromBody] BooksDetails booksDetails)
        {
            try 
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                UserClaims userClaims = VerifyUser(identity);
                if (userClaims.UserType == "Author")
                {
                    return _authorService.EditBook(bookId, booksDetails);
                }
                else
                {
                    return "only author can edit the book";
                }
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Blocks the unblock book.
        /// </summary>
        /// <param name="BookId">The book identifier.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        /// <returns>ActionResult&lt;System.String&gt;.</returns>
        [HttpPut]
        [Route("blockunblockbook")]
       
        public ActionResult<string> BlockUnblockBook(string BookId, bool status)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                UserClaims userClaims = VerifyUser(identity);
                if (userClaims.UserType == "Author")
                {
                    return _authorService.BlockUnblockBook(BookId, status);
                }
                else
                {
                    return "only author can block or unblock the book";
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Gets the list of books.
        /// </summary>
        /// <param name="AuthorId">The author identifier.</param>
        /// <returns>ActionResult&lt;BooksDetails&gt;.</returns>
        [HttpGet]
        [Route("getallbooks")]
        
        public ActionResult<BooksDetails> GetBooks(int AuthorId)
        {
            try 
            { 
            var books = _authorService.GetBooks(AuthorId);
            if (books == null)
                return NoContent();
            else
                return books;
            }
            catch
            {
                return BadRequest();
            }
}
        private UserClaims VerifyUser(ClaimsIdentity identity)
        {
            UserClaims userClaims = new UserClaims();
            //userClaims.UserName = identity.FindFirst("UserName").Value.ToString();
            //userClaims.EmailId = identity.FindFirst("EmailId").Value.ToString();
            userClaims.UserType= identity.FindFirst("UserType").Value.ToString();
            return userClaims;
        }
    }
}
