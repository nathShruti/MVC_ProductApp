using Microsoft.EntityFrameworkCore;
using ProductApp.Functionality;
using ProductApp.Models;


namespace ProductApp.Database
{
    public class AccountDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-T2MIRLG;Initial Catalog=Coforge;integrated security=true;multipleactiveresultsets=True;Encrypt=False"); // Using connection string // TRD-408\SQLEXPRESS
        }
        public DbSet<Account> Accounts { get; set; } // Accounts will be table name
    }
}
