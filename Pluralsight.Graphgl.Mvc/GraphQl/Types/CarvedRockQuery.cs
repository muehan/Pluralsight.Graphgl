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

            Field<ProductType>(
                "product",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return productRepository.GetOne(id);
                });
        }
    }
}
