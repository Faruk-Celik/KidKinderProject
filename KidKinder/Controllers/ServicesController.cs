using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class ServicesController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            var values =context.Services.ToList();
            return View(values);
        }

        public ActionResult DeleteServices ( int id )
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
        [HttpGet]
        public ActionResult UpdateServices ( int id )
        {
            var value = context.Services.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateServices ( Service s )
        {
            var value = context.Services.Find(s.ServiceId);
            value.Title = s.Title;
            value.Description = s.Description;
            value.IconUrl = s.IconUrl;
           
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
    }
}