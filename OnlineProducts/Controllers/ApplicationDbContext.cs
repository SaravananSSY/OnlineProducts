using Microsoft.EntityFrameworkCore;
using OnlineProducts.Models;

namespace OnlineProducts.Controllers
{
    internal class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Customer> customers { get; set; }
    }
}