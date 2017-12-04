using System.Collections.Generic;

namespace SpecificationPattern {
    class PersonFilter : IFilter<Person>
    {
        public IEnumerable<Person> Filter(IEnumerable<Person> items, ISpecification<Person> spec)
        {
            foreach (var item in items)
                if(spec.IsSatisfied(item))
                    yield return item;
        }
    }
}