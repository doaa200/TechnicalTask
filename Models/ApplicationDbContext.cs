using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TechnicalTassk.Models
{
    public class ApplicationDbContext:IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
