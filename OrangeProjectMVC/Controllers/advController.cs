using OrangeProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrangeProjectMVC.Controllers
{
    public class AdvController : Controller
    {
        private electionEntities db = new electionEntities();

        // GET: Ads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ads/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ad model)
        {
            if (ModelState.IsValid)
            {
                Ad ad = new Ad
                {
                    description = model.description,
                    img_url = model.img_url,
                    status = "Active"
                };

                db.Ads.Add(ad);
                db.SaveChanges();
                return RedirectToAction("create"); // Redirect to an appropriate page
            }

            return View(model);
        }

        // GET: Ads
        public ActionResult Index()
        {
            var ads = db.Ads.ToList();
            return View(ads);
        }
    }
}
