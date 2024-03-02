using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using KidKinder.Context;
using KidKinder.Entities;


namespace KidKinder.Controllers
{
    public class ParentController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ParentList()
        {
            var values = context.Parents.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateParent ()
        {
            List<SelectListItem> values = (from x in context.Parents.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.ParentId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateParent ( Parent parent )
        {
            context.Parents.Add(parent);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
        public ActionResult DeleteParent ( int id )
        {
            var value = context.Parents.Find(id);
            context.Parents.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
        [HttpGet]
        public ActionResult UpdateParent ( int id )
        {
            var value = context.Parents.Find(id);
            
            return View( value);
        }
        [HttpPost]
        public ActionResult UpdateParent ( Parent parent )
        {
            var value = context.Parents.Find(parent.ParentId);          
            value.Name = parent.Name;
            value.Surname = parent.Surname;       
            value.Email = parent.Email;
            value.Phone = parent.Phone;
            value.Adress = parent.Adress;
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
    }
}