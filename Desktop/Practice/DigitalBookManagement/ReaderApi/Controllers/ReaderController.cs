using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReaderApi.Models;
using ReaderApi.Services;

namespace ReaderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ReaderController : ControllerBase
    {
        private readonly IReaderService _readerService;
        public ReaderController(IReaderService readerService)
        {
            _readerService = readerService;
        }
        /// <summary>
        /// Searches the books.
        /// </summary>
        /// <param name="BookId">The book identifier.</param>
        /// <param name="Category">The category.</param>
        /// <param name="AuthorId">The author identifier.</param>
        /// <param name="Publisher">The publisher.</param>
        /// <returns>ActionResult&lt;BooksDetails&gt;.</returns>
        [HttpGet]
        [Route("searchbook")]
        
        public ActionResult<BooksDetails> SearchBooks(string BookId, string Category, string AuthorId, string Publisher)
        {
            return _readerService.SearchBooks(BookId, Category, AuthorId, Publisher);
        }
        /// <summary>
        /// Gets the reader books.
        /// </summary>
        /// <param name="BookId">The book identifier.</param>
        /// <returns>ActionResult&lt;BooksDetails&gt;.</returns>
        [HttpGet]
        [Route("readbook")]
        
        public ActionResult<BooksDetails> GetReaderBooks(string BookId)
        {
            var books = _readerService.GetBooks(BookId);
            if (books == null)
                return NoContent();
            else
                return books;
        }
    }
}
