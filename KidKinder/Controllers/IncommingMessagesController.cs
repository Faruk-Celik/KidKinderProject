using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class IncommingMessagesController : Controller
    {
        // GET: IncommingMessages
        public ActionResult Index()
        {
            return View();
        }
    }
}