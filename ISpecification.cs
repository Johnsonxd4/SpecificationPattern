namespace SpecificationPattern {
    interface ISpecification<T> {
        bool IsSatisfied(Person person);
    }
}