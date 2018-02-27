using System;

namespace SpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var eddie = new Person {Email = "eddie@PearlJam.com.br", Name = "Eddie Vedder"};
            var petter = new Person {Email = "petter@spyderman.com.br", Name = "Petter Parker"};
            var james = new Person {Email = "james@metallica.com.br", Name = "James Hatfield"};

            Person[] people = { eddie, petter, james };

            var pf = new PersonFilter();
            var spec = new FindNameSpecification("James");
            
            foreach (var item in pf.Filter(people, spec))
                Console.WriteLine($"The name {item.Name} satisfies the specification");
            
        }
    }
}
