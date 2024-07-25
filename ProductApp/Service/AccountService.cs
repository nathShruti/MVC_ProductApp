using ProductApp.Functionality;
using ProductApp.Models;
using ProductApp.Database;

namespace ProductApp.Service
{
    public class AccountService : IAccountOperation
    {
        AccountDbContext accountDbContext;
        public AccountService()
        {
            accountDbContext = new AccountDbContext();
        }
        int IAccountOperation.AccountCreate(Account account)
        {
            accountDbContext.Accounts.Add(account);
            return accountDbContext.SaveChanges();
        }

        int IAccountOperation.AccountValidate(string username, string password)
        {
            int res;
            var result = accountDbContext.Accounts.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if(result == null)
            {
                return 0;
            }
            return 1;
        }
    }
}
