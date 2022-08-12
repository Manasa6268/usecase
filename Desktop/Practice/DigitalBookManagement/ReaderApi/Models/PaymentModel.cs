using System.ComponentModel.DataAnnotations;

namespace ReaderApi.Models
{
    public class PaymentDetails
    {

        [Key]
        public string PaymentId { get; set; }
        public string Email { get; set; }
        public string ReaderId { get; set; }

        public string Name { get; set; }
        public string BookId { get; set; }

        public DateTime PaymentDate { get; set; }

    }
}
