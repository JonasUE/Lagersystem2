using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Storage.DataAccessLayer;

namespace Storage.Models
{
    public class CategorySelectionsController : Controller
    {
        private StorageContext db = new StorageContext();

        // GET: CategorySelections
        public ActionResult Index()
        {
            return View(db.CategorySelections.ToList());
        }

        // GET: CategorySelections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategorySelection categorySelection = db.CategorySelections.Find(id);
            if (categorySelection == null)
            {
                return HttpNotFound();
            }
            return View(categorySelection);
        }

        // GET: CategorySelections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorySelections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Category")] CategorySelection categorySelection)
        {
            if (ModelState.IsValid)
            {
                db.CategorySelections.Add(categorySelection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorySelection);
        }

        // GET: CategorySelections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategorySelection categorySelection = db.CategorySelections.Find(id);
            if (categorySelection == null)
            {
                return HttpNotFound();
            }
            return View(categorySelection);
        }

        // POST: CategorySelections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Category")] CategorySelection categorySelection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorySelection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorySelection);
        }

        // GET: CategorySelections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategorySelection categorySelection = db.CategorySelections.Find(id);
            if (categorySelection == null)
            {
                return HttpNotFound();
            }
            return View(categorySelection);
        }

        // POST: CategorySelections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategorySelection categorySelection = db.CategorySelections.Find(id);
            db.CategorySelections.Remove(categorySelection);
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
