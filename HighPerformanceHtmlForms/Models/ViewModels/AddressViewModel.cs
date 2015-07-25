using System.Collections.Generic;

namespace HighPerformanceHtmlForms.Models.ViewModels
{
    public class AddressViewModel
    {
        public int PersonId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Address[] Addresses { get; set; }
    }
}
