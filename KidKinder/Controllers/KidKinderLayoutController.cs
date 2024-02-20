using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class KidKinderLayoutController : Controller
    {
        // GET: KidKinderLayout
   
        public ActionResult _Layout ()
        {
            return View();
        }
        public PartialViewResult PartialHead ()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar ()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter ()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript ()
        {
            return PartialView();
        }
    }
}