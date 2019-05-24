using Microsoft.EntityFrameworkCore;
using Pluralsight.Graphgl.Mvc.Data.Entities;

namespace Pluralsight.Graphgl.Mvc.Data
{
    public class CarvedRockDbContext : DbContext
    {

        public CarvedRockDbContext(
            DbContextOptions<CarvedRockDbContext> options)
        : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
