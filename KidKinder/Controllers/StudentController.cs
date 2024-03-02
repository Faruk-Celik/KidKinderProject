using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class StudentController : Controller
    {

        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values=context.Students.ToList();
            return View(values);
           
        }
        [HttpGet]
        public ActionResult CreateStudent ()
        {
            List<SelectListItem> values = (from x in context.Students.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.StudentId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent ( Student s )
        {
            context.Students.Add(s);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult DeleteStudent ( int id )
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateStudent ( int id )
        {
            var value = context.Students.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateStudent ( Student s )
        {
            var value = context.Students.Find(s.StudentId);
            value.Name = s.Name;
            value.Surname=s.Surname;
            value.Age = s.Age;
            value.StudentClass = s.StudentClass;
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}