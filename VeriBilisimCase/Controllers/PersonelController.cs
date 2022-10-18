using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeriBilisimCase.Data;
using VeriBilisimCase.Models;

namespace VeriBilisimCase.Controllers
{
    public class PersonelController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PersonelController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Personel> perList = _db.Personels;
            return View(perList);
        }

        //GET-Create
        public IActionResult Create()
        {
            return View();
        }


        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Personel per)
        {
            if (ModelState.IsValid)
            {
                _db.Personels.Add(per);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(per);

        }

        //GET-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Personels.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Personel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Personels.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)  
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Personels.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Personels.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Personels.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
