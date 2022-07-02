using SpecificationPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SpecificationPattern.Specifications
{
    public class MultipleAndSpecification : ISpecification<Product>
    {
        IList<ISpecification<Product>> specifications;

        public MultipleAndSpecification(IList<ISpecification<Product>> specifications)
        {
            this.specifications = specifications;
        }

        public bool IsSatisfied(Product t)
        {
            return specifications.All(s => s.IsSatisfied(t));
        }
    }
}
