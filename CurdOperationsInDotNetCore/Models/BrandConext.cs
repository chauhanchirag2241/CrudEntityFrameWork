using Microsoft.EntityFrameworkCore;

namespace CurdOperationsInDotNetCore.Models
{
    public class BrandConext : DbContext
    {
        public BrandConext(DbContextOptions<BrandConext> options) : base(options)
        {
               
        }
       public DbSet<Brand> Brands { get; set; }
        public DbSet<product> Products { get; set; }
    }
}
