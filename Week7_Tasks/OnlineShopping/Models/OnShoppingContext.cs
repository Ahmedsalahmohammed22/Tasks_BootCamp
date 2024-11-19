using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.Models
{
    public class OnShoppingContext:IdentityDbContext
    {
        public OnShoppingContext(DbContextOptions<OnShoppingContext> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
