using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class ContactController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactAddressPartial ()
        {
            ViewBag.Description=context.Communications.Select(x => x.Description).FirstOrDefault();
            ViewBag.Phone=context.Communications.Select(x => x.Phone).FirstOrDefault();
            ViewBag.Adress = context.Communications.Select(x => x.Adress).FirstOrDefault();
            ViewBag.Email = context.Communications.Select(x => x.Email).FirstOrDefault();
            return PartialView();
        }
        public ActionResult CreateContact ( Contact c)
        {
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            context.Contacts.Add(c);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult ContactMaps ()
        {
            return PartialView();
        }

    }
}