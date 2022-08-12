using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace AuthourApi.Model
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
	public class UserDetails
	{
		[Key]
		public string UserId { get; set; }
		public string UserName { get; set; }
		public string EmailId { get; set; }
		public string Password { get; set; }
		public string UserType { get; set; }

		public UserDetails(string userId, string userName, string emailId, string password, string userType)
		{
			UserId = userId;
			UserName = userName;
			EmailId = emailId;
			Password = password;
			UserType = userType;
		}
	}
	public class UserClaims
	{
		
		public string UserName { get; set; }
		public string EmailId { get; set; }
		
		public string UserType { get; set; }

		public enum UserTypes
        {
			
		}
	}
}
