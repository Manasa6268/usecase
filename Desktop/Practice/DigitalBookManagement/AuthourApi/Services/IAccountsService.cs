using AuthourApi.Model;

namespace AuthourApi.Services
{
    public interface IAccountsService
    {
        string checkaccount(string? username, string password);
        string CreateAccount(UserDetails userDetails);
        List<UserDetails> ValidateAccount(string? userName, string? password);
    }
}