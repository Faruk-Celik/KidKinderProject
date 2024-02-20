using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class AboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutHeaderPartial ()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutList ()
        {
            var values = context.AboutLists.ToList();
            return PartialView(values);
        }
    }
}