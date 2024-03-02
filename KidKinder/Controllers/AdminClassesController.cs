using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class AdminClassesController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
            
        }
        [HttpGet]
        public ActionResult CreateClasses ()
        {
            List<SelectListItem> values = (from x in context.ClassRooms.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ClassroomId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateClasses ( ClassRoom c )
        {
            context.ClassRooms.Add(c);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult DeleteClasses ( int id )
        {
            var value = context.ClassRooms.Find(id);
            context.ClassRooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateClasses ( int id )
        {
            var value = context.ClassRooms.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateClasses ( ClassRoom c )
        {
            var value = context.ClassRooms.Find(c.ClassroomId);
            value.Title = c.Title;
            value.Description = c.Description;
            value.AgeofKids = c.AgeofKids;
            value.Totalseat = c.Totalseat;
            value.ClassTime =c.ClassTime;
            value.Price =c.Price;
            value.ImageUrl =c.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}