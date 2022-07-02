using SpecificationPattern.Interfaces;

namespace SpecificationPattern.Specifications
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Enums.Color color;

        public ColorSpecification(Enums.Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == color;
        }
    }
}
