using ReaderApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ReaderApi
{
    public class DbReaderContext : DbContext
    {
        private readonly IConfiguration _configuration;
       
        public DbSet<BooksDetails> BooksDetails { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbReaderContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_configuration.GetConnectionString("ConnectionString"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<BooksDetails>().ToTable("tbl_Books");
            modelBuilder.Entity<PaymentDetails>().ToTable("tbl_Payments");
        }
    }
}
