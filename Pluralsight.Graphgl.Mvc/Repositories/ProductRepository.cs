using System.Collections.Generic;
using Pluralsight.Graphgl.Mvc.Data;
using Pluralsight.Graphgl.Mvc.Data.Entities;

namespace Pluralsight.Graphgl.Mvc.Repositories
{
    public class ProductRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public ProductRepository(
            CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products;
        }
    }
}
