using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeriBilisimCase.Data;
using VeriBilisimCase.Models;

namespace VeriBilisimCase.Controllers
{
    public class AdayController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdayController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Aday> adayList = _db.Adays;
            return View(adayList);
        }

        //GET-Create
        public IActionResult Create()
        {
            return View();
        }


        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Aday per)
        {
            if (ModelState.IsValid)
            {
                _db.Adays.Add(per);
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
            var obj = _db.Adays.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Aday obj)
        {
            if (ModelState.IsValid)
            {
                _db.Adays.Update(obj);
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
            var obj = _db.Adays.Find(id);
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
            var obj = _db.Adays.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Adays.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
