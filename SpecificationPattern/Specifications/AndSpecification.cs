using SpecificationPattern.Interfaces;

namespace SpecificationPattern.Specifications
{
    public class AndSpecification : ISpecification<Product>
    {
        private Enums.Color color;
        private Enums.Size size;

        public AndSpecification(Enums.Color color, Enums.Size size)
        {
            this.color = color;
            this.size = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == color && product.Size == size;
        }
    }
}
