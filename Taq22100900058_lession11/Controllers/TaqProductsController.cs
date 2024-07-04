using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Taq22100900058_lession11.Models;

namespace Taq22100900058_lession11.Controllers
{
    public class TaqProductsController : Controller
    {
        private TaqK22CNTt3Lession11DbEntities db = new TaqK22CNTt3Lession11DbEntities();

        // GET: TaqProducts
        public ActionResult TaqIndex()
        {
            return View(db.TaqProducts.ToList());
        }

        // GET: TaqProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaqProduct taqProduct = db.TaqProducts.Find(id);
            if (taqProduct == null)
            {
                return HttpNotFound();
            }
            return View(taqProduct);
        }

        // GET: TaqProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaqProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaqID2210900058,TaqProName,TaqQty,TaqPrice,TaqCateID,TaqActive")] TaqProduct taqProduct)
        {
            if (ModelState.IsValid)
            {
                db.TaqProducts.Add(taqProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taqProduct);
        }

        // GET: TaqProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaqProduct taqProduct = db.TaqProducts.Find(id);
            if (taqProduct == null)
            {
                return HttpNotFound();
            }
            return View(taqProduct);
        }

        // POST: TaqProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaqID2210900058,TaqProName,TaqQty,TaqPrice,TaqCateID,TaqActive")] TaqProduct taqProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taqProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taqProduct);
        }

        // GET: TaqProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaqProduct taqProduct = db.TaqProducts.Find(id);
            if (taqProduct == null)
            {
                return HttpNotFound();
            }
            return View(taqProduct);
        }

        // POST: TaqProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TaqProduct taqProduct = db.TaqProducts.Find(id);
            db.TaqProducts.Remove(taqProduct);
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
