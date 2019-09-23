using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class Home1Controller : Controller
    {

        public ProductDbContext db = new ProductDbContext();

        // GET: Home1
        public ActionResult Index()
        {
            Catagory c = new Catagory();
            return View(c);
        }

        public ActionResult InserCat(Catagory c)
        {
            db.catagorys.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Catagory ed = db.catagorys.Where(cat => cat.CID == Id).FirstOrDefault();
            return View(ed);
        }

        public ActionResult Update(Catagory c)
        {
            Catagory oldrecord = db.catagorys.Where(Catagory => Catagory.CID == c.CID).FirstOrDefault();
            oldrecord.CName = c.CName;
            oldrecord.Price = c.Price;
            db.Entry(oldrecord).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int Id)
        {
            Catagory c = db.catagorys.Where(cat => cat.CID == Id).FirstOrDefault();
            db.catagorys.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}