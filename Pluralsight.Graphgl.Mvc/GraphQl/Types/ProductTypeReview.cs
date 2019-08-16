using GraphQL.Types;
using Pluralsight.Graphgl.Mvc.Data.Entities;

namespace Pluralsight.Graphgl.Mvc.GraphQl.Types
{
    public class ProductReviewType: ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(t => t.Id);
            Field(t => t.Review);
            Field(t => t.Title);    
        }
    }
}
