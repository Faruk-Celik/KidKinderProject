﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;


namespace KidKinder.Controllers
{
    public class GalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GalleryHeaderPartial ()
        {
            return PartialView();
        }
        public PartialViewResult GalleryImagePartial ()
        {
            var values = context.Galleries.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallery ()
        {

            var values = context.Galleries.ToList();
            
            return PartialView(values);
        }

    }
}