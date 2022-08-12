using System.ComponentModel.DataAnnotations;

namespace AuthorizationApi.Models
{
    public class UserData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        enum roles
        {
            Authour,
            Reader
        }
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
    

}
