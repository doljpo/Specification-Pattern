using SpecificationPattern.Interfaces;
using System.Collections.Generic;

namespace SpecificationPattern
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var product in items)
            {
                if (spec.IsSatisfied(product))
                    yield return product;
            }
        }
    }
}
