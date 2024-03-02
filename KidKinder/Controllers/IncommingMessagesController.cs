using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class IncommingMessagesController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}