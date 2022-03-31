using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Yousif_Project.Data;
using Yousif_Project.Models;

namespace Yousif_Project.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {

            IEnumerable<ApplicationType> objList = _db.ApplicationType;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            if (ModelState.IsValid)
            {
                _db.ApplicationType.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _db.ApplicationType.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [HttpPost]
        public IActionResult Edit(ApplicationType obj)
        {
            if(obj == null)
            {
                return NotFound();
            }
            _db.ApplicationType.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _db.ApplicationType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(ApplicationType obj)
        {
            if(obj == null)
            {
                return NotFound();
            }
            _db.ApplicationType.Remove(obj);
            _db.SaveChanges();
           return RedirectToAction("Index");
        }



    }
}
