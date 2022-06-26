using Core.Utilities.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace DataAccess.Concrete.Contexts
{
    public class ProductManagementDbContext : DbContext
    {
        private IConfiguration Configuration;
        public ProductManagementDbContext()
        {
            Configuration = ServiceTool.ServiceProvider.GetService<IConfiguration>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<VerificationCode> VerificationCodes { get; set; }
        public DbSet<MailTransaction> MailTransactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserCustomer> UserCustomers { get; set; }
        public DbSet<CompanyCustomer> CompanyCustomers { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductTransaction> ProductTransactions { get; set; }
        public DbSet<SaleTransaction> SaleTransactions { get; set; }
        public DbSet<BuyTransaction> BuyTransactions { get; set; }
    }
}
