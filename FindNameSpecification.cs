namespace SpecificationPattern {
    class FindNameSpecification : ISpecification<Person>
    {
        private string _name;
        public FindNameSpecification(string name)
        {
            _name = name;
        }
        public bool IsSatisfied(Person person)
        {
            return person.Name.Contains(_name);
        }
    }
}