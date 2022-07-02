using System.Collections.Generic;

namespace SpecificationPattern.Interfaces
{
    public interface IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
