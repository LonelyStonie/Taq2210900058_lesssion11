using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Taq22100900058_lession11.Models
{
    public class TaqCategoriesController : Controller
    {
        private TaqK22CNTt3Lession11DbEntities db = new TaqK22CNTt3Lession11DbEntities();

        // GET: TaqCategories
        public ActionResult TaqIndex()
        {
            return View(db.TaqCategories.ToList());
        }

        // GET: TaqCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaqCategory taqCategory = db.TaqCategories.Find(id);
            if (taqCategory == null)
            {
                return HttpNotFound();
            }
            return View(taqCategory);
        }

        // GET: TaqCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaqCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaqID,TaqCateName,TaqStatus")] TaqCategory taqCategory)
        {
            if (ModelState.IsValid)
            {
                db.TaqCategories.Add(taqCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taqCategory);
        }

        // GET: TaqCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaqCategory taqCategory = db.TaqCategories.Find(id);
            if (taqCategory == null)
            {
                return HttpNotFound();
            }
            return View(taqCategory);
        }

        // POST: TaqCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaqID,TaqCateName,TaqStatus")] TaqCategory taqCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taqCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taqCategory);
        }

        // GET: TaqCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaqCategory taqCategory = db.TaqCategories.Find(id);
            if (taqCategory == null)
            {
                return HttpNotFound();
            }
            return View(taqCategory);
        }

        // POST: TaqCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaqCategory taqCategory = db.TaqCategories.Find(id);
            db.TaqCategories.Remove(taqCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
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
