using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkCase
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=ProductsEF;Trusted_Connection=True");
        }
    }
}
