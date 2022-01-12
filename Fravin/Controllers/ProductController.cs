using Fravin.Data;
using Fravin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Fravin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Product;
            foreach (var item in objList)
            {
                item.Category = _db.Category.FirstOrDefault(u => u.Id == item.Id);
            }
            return View(objList);
        }
        //Get - Upsert
        public IActionResult Upsert(int? id)
        {
            Product product = new Product();
            if (id == null)
            {
                    return View(product);
            }
            else
            {
                product = _db.Product.Find(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }
            return View();
        }
        //Post - Upsert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        //Get - Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Category.Find(id);
            //if (obj==null)
            //{
            // return NotFound();   
            //}
            // 
            if (obj == null)
            {
                return NotFound();
            }
            _db.Category.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
