using Microsoft.EntityFrameworkCore;

namespace InternetBanking.Model
{
    public class InternetBankingContext:DbContext
    {
        public InternetBankingContext(DbContextOptions options):base(options) 
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FAQ> FAQ { get; set; }
        public DbSet<FAQCategory> FAQCategories { get; set; }
        public DbSet<HelpRequest> HelpRequests { get; set; }
        public DbSet<HelpRequestType> HelpRequestsTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServicesTypes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
    
}
