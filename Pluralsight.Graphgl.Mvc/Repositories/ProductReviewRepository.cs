using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pluralsight.Graphgl.Mvc.Data;
using Pluralsight.Graphgl.Mvc.Data.Entities;

namespace Pluralsight.Graphgl.Mvc.Repositories
{
    public class ProductReviewRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public ProductReviewRepository(
            CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ProductReview> GetAll()
        {
            return _dbContext.ProductReviews;
        }

        public List<ProductReview> GetForProduct(
            int sourceId)
        {
            return _dbContext.ProductReviews.Where(x => x.ProductId == sourceId).ToList();
        }

        public async Task<ILookup<int, ProductReview>> GetForProducts(
            IEnumerable<int> productIds)
        {
            var reviews = await _dbContext
                .ProductReviews
                .Where(x => productIds.Contains(x.ProductId))
                .ToListAsync();

            return reviews.ToLookup(r => r.ProductId);
        }
    }
}
