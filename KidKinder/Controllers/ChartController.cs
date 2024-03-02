﻿using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class ChartController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            ViewBag.testimonial = context.Testimonials.Count();
            ViewBag.teacher = context.Teachers.Count();
            ViewBag.bookaseat = context.BookASeats.Count();
            ViewBag.notification = context.Notifications.Count();
            ViewBag.classroom = context.ClassRooms.Count();
            return View();
           
        }
    }
}