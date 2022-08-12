using System.ComponentModel.DataAnnotations;

namespace ReaderApi.Models
{
	public class BooksDetails
	{
	
		[Key]
		public string BookId { get; set; }
		public string Logo { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public string AuthorId { get; set; }

		public string Publisher { get; set; }

		public DateTime PublishDate { get; set; }

		public string Content { get; set; }

		public int Active { get; set; }

		public DateTime CreatedDate { get; set; }

		public DateTime ModifiedDate { get; set; }

	}
}
