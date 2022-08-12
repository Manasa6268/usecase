using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReaderApi.Models;
using ReaderApi.Services;

namespace ReaderApi.Controllers
{
    /// <exclude />
    [Route("api/[controller]")]
    [ApiController]
   

    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsController"/> class.
        /// </summary>
        /// <param name="paymentService">The payment service.</param>
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        /// <summary>
        /// Buys the book.
        /// </summary>
        /// <param name="paymentDetails">The payment details.</param>
        /// <returns>ActionResult&lt;System.String&gt;.</returns>
        [HttpPost]
        [Route("buybook")]
       
        public ActionResult<string> BuyBook(PaymentDetails paymentDetails)
        {
            return Ok(_paymentService.BuyBook(paymentDetails));
        }
        /// <summary>
        /// Asks the refund.
        /// </summary>
        /// <param name="paymentDetails">The payment details.</param>
        /// <returns>ActionResult&lt;System.String&gt;.</returns>
        [HttpPost]
        [Route("askrefund")]
      
        public ActionResult<string> AskRefund(PaymentDetails paymentDetails)
        {
            return Ok(_paymentService.AskRefund(paymentDetails));
        }
        /// <summary>
        /// Finds the books.
        /// </summary>
        /// <param name="paymentDetails">The payment details.</param>
        /// <returns>ActionResult&lt;BooksDetails&gt;.</returns>
        [HttpPost]
        [Route("findbooks")]
        
        public ActionResult<BooksDetails> FindBooks(PaymentDetails paymentDetails)
        {
            return Ok(_paymentService.FindBooks(paymentDetails));
        }
        /// <summary>
        /// Finds all books.
        /// </summary>
        /// <param name="paymentDetails">The payment details.</param>
        /// <returns>ActionResult&lt;BooksDetails&gt;.</returns>
        [HttpGet]
        [Route("findallbooks")]
        
        public ActionResult<BooksDetails> FindAllBooks(PaymentDetails paymentDetails)
        {
            return Ok(_paymentService.FindAllBooks(paymentDetails));
        }
    }
}
