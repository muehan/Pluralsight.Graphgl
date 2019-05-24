using GraphQL;
using GraphQL.Types;
using Pluralsight.Graphgl.Mvc.GraphQl.Types;

namespace Pluralsight.Graphgl.Mvc.GraphQl
{
    public class CarvedRockSchema : Schema
    {
        public CarvedRockSchema(
            IDependencyResolver resolver)
        : base(resolver)
        {
            Query = resolver.Resolve<CarvedRockQuery>();
        }
    }
}
