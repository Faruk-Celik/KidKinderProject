using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
           
            ViewBag.ArtLessonCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(y => y.BranchName == "Art").Select(z => z.BranchId).FirstOrDefault()).Count();

            ViewBag.AvgPrice =context.ClassRooms.Average(x => x.Price).ToString("0.00");

            ViewBag.TotalService = context.Services.Count();

            ViewBag.TotalTeacher = context.Teachers.Count();

            ViewBag.ClassRoom = context.ClassRooms.Count();

            ViewBag.Branch = context.Branches.Count();

            ViewBag.Contact = context.Contacts.Count();

            ViewBag.Admin = context.Admins.Count();

            ViewBag.MailSubscribers = context.MailSubscribes.Count();

            ViewBag.Testimonial = context.Testimonials.Count();

            var value = context.Teachers.ToList();
            return View(value);
            
        }
    }
}