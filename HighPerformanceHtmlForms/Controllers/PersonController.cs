using HighPerformanceHtmlForms.Models;
using HighPerformanceHtmlForms.Models.Repositories;
using HighPerformanceHtmlForms.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace HighPerformanceHtmlForms.Controllers
{
    public class PersonController : Controller
    {
        private PersonRepository personRepo = new PersonRepository();
        private AddressRepository addressRepo = new AddressRepository();

        public ActionResult Index()
        {
            var p = personRepo.Find(1);
            var vm = new PersonViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Friend = personRepo.FindByPersonId(p.Id),
                Addresses = addressRepo.Find(p.Id).ToArray()
            };
            return View(vm);
        }

        public ActionResult PersonEdit()
        {
            var p = personRepo.Find(1);
            var vm = new PersonViewModel
            {
                Id = p.Id,
                Name = p.Name
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult PersonEdit(Person p)
        {
            personRepo.Update(p);
            return RedirectToAction("Index");
        }

        public ActionResult FriendEdit(int id)
        {
            var p = personRepo.FindByPersonId(id);
            var vm = new FriendViewModel
            {
                Id = p.Id,
                PersonId = id,
                Name = p.Name
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult FriendEdit(Person p)
        {
            personRepo.Update(p);
            return RedirectToAction("PersonEdit");
        }
    }
}
