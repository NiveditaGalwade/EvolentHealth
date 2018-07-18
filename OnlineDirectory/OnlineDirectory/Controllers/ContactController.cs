using OnlineDirectory.BLL;
using OnlineDirectory.DomainEntites;
using System.Net;
using System.Web.Mvc;

namespace OnlineDirectory.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService<Contact> _contactService = null;
        public ContactController(IContactService<Contact> contactService)
        {
            _contactService = contactService;
        }
        public ActionResult Index()
        {
            var contacts = _contactService.FindAll();
            return View("Index",contacts);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            _contactService.Create(contact);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var contact = FindById(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Edit(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var contact = FindById(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }
        [NonAction]
        public Contact FindById(int? id)
        {
            return _contactService.FindById(id);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            try
            {
                Contact contact = FindById(id);
                _contactService.Delete(contact);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}