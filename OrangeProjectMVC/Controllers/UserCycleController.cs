﻿using OrangeProjectMVC.Models;
using System;
using System.Web.Mvc;

namespace OrangeProjectMVC.Controllers
{
    public class UserCycleController : Controller
    {
        private electionEntities db = new electionEntities();

        // GET: UserCycle
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult contact()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

    }
}
