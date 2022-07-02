namespace SpecificationPattern.Interfaces
{
    public interface ISpecification<T>
    {
        public bool IsSatisfied(T t);
    }
}
