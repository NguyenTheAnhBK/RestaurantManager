using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private CustomGuidDbContext _db = new CustomGuidDbContext();
        public ActionResult Index()
        {
            var model = _db.PortFolios.ToList();
            return View(model);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        [ChildActionOnly]
        public ActionResult Navigation()
        {
            var model = _db.Navigations.ToList();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult Header()
        {
            var model = _db.Headers.ToList();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult AboutSection()
        {
            var model = _db.AboutSections.ToList();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult ContactSection()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult Footer()
        {
            var model = _db.Footers.ToList();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult Copyright()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult Social()
        {
            var model = _db.Socials.ToList();
            return PartialView(model);
        }
    }
}