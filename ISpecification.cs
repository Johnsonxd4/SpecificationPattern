namespace SpecificationPattern {
    interface ISpecification<T> {
        bool IsSatisfied(T entity);
    }
}