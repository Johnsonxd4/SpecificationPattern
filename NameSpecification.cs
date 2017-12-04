namespace SpecificationPattern {
    class NameSpecification : ISpecification<Person> {
        private string _name;
        public NameSpecification(string name)
        {
            _name = name;
        }
        public bool IsSatisfied(Person person)
        {
            return person.Name == _name;
        }
    }
}