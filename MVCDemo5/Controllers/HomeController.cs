using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo5.Models;

namespace MVCDemo5.Controllers
{
    public class HomeController : Controller
    {
        studentEntities1 conn = new studentEntities1();
        // GET: Home
        public ActionResult Index()
        {
            student_info st = new student_info();
            return View(st);
        }

        public ActionResult InsertRecord(student_info std)
        {
            
            conn.student_info.Add(std);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
           // studentEntities1 conn = new studentEntities1();
            student_info ed = conn.student_info.Where(my_model => my_model.id == id).FirstOrDefault();
            return View(ed);
        }

        public ActionResult UpdateRecord(student_info std)
        {
           // studentEntities1 conn = new studentEntities1();
            student_info oldrecord = conn.student_info.Where(my_modle => my_modle.id == std.id).FirstOrDefault();
            oldrecord.names = std.names;
            oldrecord.mobile = std.mobile;
            conn.Entry(oldrecord).State = System.Data.Entity.EntityState.Modified;
            conn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
           // studentEntities1 conn = new studentEntities1();
            student_info ed = conn.student_info.Where(my_model => my_model.id == id).FirstOrDefault();
            conn.student_info.Remove(ed);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}