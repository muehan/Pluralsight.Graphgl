using GraphQL.Types;
using Pluralsight.Graphgl.Mvc.Repositories;

namespace Pluralsight.Graphgl.Mvc.GraphQl.Types
{
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(
            ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
            );
        }
    }
}
