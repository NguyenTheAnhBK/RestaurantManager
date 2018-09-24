using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Areas.Admin.Controllers
{
    public class TemplateController : Controller
    {
        private CustomGuidDbContext _db = new CustomGuidDbContext();
        // GET: Admin/Template
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Navigation()
        {
            var model = _db.Navigations.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Navigation(string nav_brand, string background_color)
        {
            if (!String.IsNullOrEmpty(nav_brand) && !String.IsNullOrEmpty(background_color))
            {
                var nav = new Navigation { NavName = nav_brand, NavBackgroundColor = background_color, NavColor = "white" };
                _db.Navigations.Add(nav);
                _db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Header()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Header(Header header)
        {
            if (ModelState.IsValid)
            {
                _db.Headers.Add(header);
                _db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Social()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Social(Social social)
        {
            if (ModelState.IsValid)
            {
                _db.Socials.Add(social);
                _db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Portfolio()
        {
            var model = _db.PortFolios.ToList();
            return View(model);
        }
        [HttpDelete]
        public ActionResult Portfolio(int id)
        {
                var result = _db.PortFolios.Find(id);
                _db.PortFolios.Remove(result);
                _db.SaveChanges();
            return RedirectToAction("Portfolio");
        }
        //public ActionResult AddPortfolio()
        //{
        //    return View();
        //}
        //public ActionResult UpdatePortfolio()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult AboutSection()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AboutSection(AboutSection aboutSection)
        {
            if (ModelState.IsValid)
            {
                _db.AboutSections.Add(aboutSection);
                _db.SaveChanges();
            }
            return View();
        }
    }
}