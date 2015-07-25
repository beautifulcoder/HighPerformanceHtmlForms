using System.Collections.Generic;
using System.Linq;

namespace HighPerformanceHtmlForms.Models.Repositories
{
    public class AddressRepository
    {
        private static List<Address> repo = new List<Address>
        {
            new Address
            {
                Id = 1,
                PersonId = 1,
                City = "Athens",
                State = "Texas"
            },
            new Address
            {
                Id = 2,
                PersonId = 1,
                City = "Paris",
                State = "Texas"
            }
        };

        public IEnumerable<Address> Find(int personId)
        {
            return repo.Where(x => x.PersonId == personId);
        }

        public Address Add(Address a)
        {
            a.Id = repo.Count() + 1;
            repo.Add(a);
            return a;
        }
    }
}
