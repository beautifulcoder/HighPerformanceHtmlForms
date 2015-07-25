using System.Collections.Generic;
using System.Linq;

namespace HighPerformanceHtmlForms.Models.Repositories
{
    public class PersonRepository
    {
        private static List<Person> repo = new List<Person>
        {
            new Person
            {
                Id = 1,
                Name = "Jane Doe"
            },
            new Person
            {
                Id = 2,
                PersonId = 1,
                Name = "Jon Doe"
            }
        };

        public Person Find(int id)
        {
            return repo.First(x => x.Id == id);
        }

        public Person FindByPersonId(int personId)
        {
            return repo.First(x => x.PersonId == personId);
        }

        public Person Update(Person p)
        {
            var person = repo.First(x => x.Id == p.Id);
            person.Name = p.Name;
            return person;
        }
    }
}
