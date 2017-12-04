namespace SpecificationPattern {
    class EmailSpecification : ISpecification<Person>
    {
        private string _email;
        public EmailSpecification(string email)
        {
            _email = email;
        }

        public bool IsSatisfied(Person person)
        {
            return person.Email == _email;
        }
    }
}