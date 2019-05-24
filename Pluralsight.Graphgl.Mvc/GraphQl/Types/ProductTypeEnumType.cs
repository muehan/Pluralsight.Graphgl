using GraphQL.Types;

namespace Pluralsight.Graphgl.Mvc.GraphQl.Types
{
    public class ProductTypeEnumType: EnumerationGraphType<Data.ProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of the product";
        }
    }
}
