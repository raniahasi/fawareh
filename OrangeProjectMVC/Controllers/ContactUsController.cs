using System.Web.Mvc;
using OrangeProjectMVC.Models;

namespace OrangeProjectMVC.Controllers
{
    public class ContactUsController : Controller
    {
        private electionEntities db = new electionEntities();

        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var contact = new contact_us
                {
                    name = model.Name,
                    email = model.Email,
                    subject = model.Subject,
                    message = model.Message,
                    status = "New"
                };

                db.contact_us.Add(contact);
                db.SaveChanges();

                TempData["SuccessMessage"] = "شكرا لقد تم استلام رسالتك";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
