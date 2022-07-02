using SpecificationPattern.Interfaces;
using System;

namespace SpecificationPattern.Specifications
{
    public class AndSpecification : ISpecification<Product>
    {
        private ISpecification<Product> first, second;

        public AndSpecification(ISpecification<Product> first, ISpecification<Product> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product product)
        {
            return first.IsSatisfied(product) && second.IsSatisfied(product);
        }
    }
}
