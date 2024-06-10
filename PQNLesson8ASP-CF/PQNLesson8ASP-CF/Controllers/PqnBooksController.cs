using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PQNLesson8ASP_CF.Models;

namespace PqnLesson8.Controllers
{
    public class PqnBooksController : Controller
    {
        private PqnBookStore db = new PqnBookStore();


        public ActionResult PqnIndex()
        {
            return View(db.PqnBooks.ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pqnbook pqnBook = db.PqnBooks.Find(id);
            if (pqnBook == null)
            {
                return HttpNotFound();
            }
            return View(pqnBook);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pqnBookId,PqnTitle,PqnAuthor,PqnYear,pqnPublisher,PqnPicture,PqnCategoryId")] Pqnbook pqnBook)
        {
            if (ModelState.IsValid)
            {
                db.PqnBooks.Add(pqnBook);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            return View(pqnBook);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pqnbook pqnBook = db.PqnBooks.Find(id);
            if (pqnBook == null)
            {
                return HttpNotFound();
            }
            return View(pqnBook);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PqnBookId,PqnTitle,PqnAuthor,PqnYear,PqnPublisher,PqnPicture,PqnCategoryId")] Pqnbook pqnBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            return View(pqnBook);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pqnbook pqnBook = db.PqnBooks.Find(id);
            if (pqnBook == null)
            {
                return HttpNotFound();
            }
            return View(pqnBook);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pqnbook pqnBook = db.PqnBooks.Find(id);
            db.PqnBooks.Remove(pqnBook);
            db.SaveChanges();
            return RedirectToAction("PqnIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}