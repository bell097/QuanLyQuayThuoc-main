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
    public class SicksAdminController : Controller
    {
        private QuayThuocModelContext db = new QuayThuocModelContext();

        // GET: SicksAdmin
        public ActionResult Index()
        {
            var sicks = db.Sicks.Include(s => s.CategorySick);
            return View(sicks.ToList());
        }

        // GET: SicksAdmin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sick sick = db.Sicks.Find(id);
            if (sick == null)
            {
                return HttpNotFound();
            }
            return View(sick);
        }

        // GET: SicksAdmin/Create
        public ActionResult Create()
        {
            ViewBag.categorySick_id = new SelectList(db.CategorySicks, "categorySick_id", "categorySick_name");
            return View();
        }

        // POST: SicksAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [ValidateInput(false)]

        public ActionResult Create([Bind(Include = "sick_id,sick_name,sick_content,categorySick_id")] Sick sick)
        {
            if (ModelState.IsValid)
            {
                db.Sicks.Add(sick);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categorySick_id = new SelectList(db.CategorySicks, "categorySick_id", "categorySick_name", sick.categorySick_id);
            return View(sick);
        }

        // GET: SicksAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sick sick = db.Sicks.Find(id);
            if (sick == null)
            {
                return HttpNotFound();
            }
            ViewBag.categorySick_id = new SelectList(db.CategorySicks, "categorySick_id", "categorySick_name", sick.categorySick_id);
            return View(sick);
        }

        // POST: SicksAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sick_id,sick_name,sick_content,categorySick_id")] Sick sick)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sick).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categorySick_id = new SelectList(db.CategorySicks, "categorySick_id", "categorySick_name", sick.categorySick_id);
            return View(sick);
        }

        // GET: SicksAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sick sick = db.Sicks.Find(id);
            if (sick == null)
            {
                return HttpNotFound();
            }
            return View(sick);
        }

        // POST: SicksAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sick sick = db.Sicks.Find(id);
            db.Sicks.Remove(sick);
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
