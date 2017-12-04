using System.Collections.Generic;

namespace SpecificationPattern {
    interface IFilter<T> {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}