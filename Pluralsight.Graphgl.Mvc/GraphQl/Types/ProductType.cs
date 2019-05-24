using GraphQL.Types;
using Pluralsight.Graphgl.Mvc.Data.Entities;

namespace Pluralsight.Graphgl.Mvc.GraphQl.Types
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name).Description("The name of the Product");
            Field(t => t.Description);
            Field(t => t.IntroducedAt).Description("When the product first was introduced in the store");
            Field(t => t.PhotoFileName).Description("The file name of the photo so the client can load it");
            Field(t => t.Price);
            Field(t => t.Rating).Description("The (max 5) star customer rating");
            Field(t => t.Stock);
            Field<ProductTypeEnumType>("Type", "The type of the product");
        }
    }
}
