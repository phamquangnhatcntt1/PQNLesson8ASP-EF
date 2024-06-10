using PQNLesson8ASP_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PqntLesson8.Controllers
{
    public class PqnCategoryController : Controller
    {
        private static PqnBookStore _PqnbookStore;
        public PqnCategoryController()
        {
            _PqnbookStore = new PqnBookStore();
        }

        public ActionResult PqnIndex()
        {
            var pqnCategory = _PqnbookStore.PqnCategories.ToList();
            return View(pqnCategory);
        }
        public ActionResult PqnCreate()
        {
            var PqnCategory = new PqnCategory();
            return View();
        }
        [HttpPost]
        public ActionResult PqnCreate(PqnCategory pqnCategory)
        {
            _PqnbookStore.PqnCategories.Add(pqnCategory);
            _PqnbookStore.SaveChanges();
            return RedirectToAction("PqnIndex");
        }
    }
}