using Microsoft.EntityFrameworkCore;
using WebStoreProject.Models;

namespace WebStoreProject.Data
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }
    }
}
