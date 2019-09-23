using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
   
    public class HomeController : Controller
    {
        public ProductDbContext db = new ProductDbContext();
        // GET: Home
        public ActionResult Index()
        {
            Product p = new Product();
            return View(p);
        }
        
        public ActionResult AddRecord(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Pid)
        {
            Product p= db.Products.Where(product => product.ID == Pid).FirstOrDefault();
            return View(p);
        }

        public ActionResult Update(Product p)
        {
            Product oldrecord = db.Products.Where(Product => Product.ID == p.ID).FirstOrDefault();
            oldrecord.Name = p.Name;
            oldrecord.Price = p.Price;
            oldrecord.Description = p.Description;
            db.Entry(oldrecord).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public ActionResult Delete(int Pid)
        {
            Product p = db.Products.Where(Product => Product.ID == Pid).FirstOrDefault();
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}