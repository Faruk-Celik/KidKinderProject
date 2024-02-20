using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class ParentController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ParentList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}