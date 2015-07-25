using HighPerformanceHtmlForms.Models;
using HighPerformanceHtmlForms.Models.Repositories;
using HighPerformanceHtmlForms.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace HighPerformanceHtmlForms.Controllers
{
    public class AddressController : Controller
    {
        private AddressRepository repo = new AddressRepository();

        public ActionResult Add(int id)
        {
            var list = repo.Find(id);
            var vm = new AddressViewModel
            {
                PersonId = id,
                Addresses = list.ToArray()
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Add(Address a)
        {
            repo.Add(a);
            var list = repo.Find(a.PersonId);
            var vm = new AddressViewModel
            {
                PersonId = a.PersonId,
                Addresses = list.ToArray()
            };
            return View(vm);
        }
    }
}
