using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyQuayThuoc.Models;

namespace QuanLyQuayThuoc.Controllers
{
    public class SmallCategoriesController : Controller
    {
        private QuayThuocModelContext db = new QuayThuocModelContext();

        // GET: SmallCategories
        public ActionResult Index()
        {
            var smallCategories = db.SmallCategories.Include(s => s.Category);
            return View(smallCategories.ToList());
        }

        // GET: SmallCategories/Create
        public ActionResult Create()
        {
            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name");
            return View();
        }

        // POST: SmallCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "smallcategory_id,category_id,smallcategory_name")] SmallCategory smallCategory)
        {
            if (ModelState.IsValid)
            {
                db.SmallCategories.Add(smallCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name", smallCategory.category_id);
            return View(smallCategory);
        }

        // GET: SmallCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmallCategory smallCategory = db.SmallCategories.Find(id);
            if (smallCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name", smallCategory.category_id);
            return View(smallCategory);
        }

        // POST: SmallCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "smallcategory_id,category_id,smallcategory_name")] SmallCategory smallCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smallCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name", smallCategory.category_id);
            return View(smallCategory);
        }

        // GET: SmallCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmallCategory smallCategory = db.SmallCategories.Find(id);
            if (smallCategory == null)
            {
                return HttpNotFound();
            }
            return View(smallCategory);
        }

        // POST: SmallCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SmallCategory smallCategory = db.SmallCategories.Find(id);
            db.SmallCategories.Remove(smallCategory);
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
