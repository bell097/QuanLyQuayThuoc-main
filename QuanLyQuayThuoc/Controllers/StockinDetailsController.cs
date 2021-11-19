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
    public class StockinDetailsController : Controller
    {
        private QuayThuocModelContext db = new QuayThuocModelContext();

        // GET: StockinDetails
        public ActionResult Index()
        {
            var stockinDetails = db.StockinDetails.Include(s => s.Product).Include(s => s.StockIn);
            return View(stockinDetails.ToList());
        }

        // GET: StockinDetails/Details/5
        public ActionResult Details(int id)
        {
            var stockinDetail = (from a in db.StockinDetails
                                 where a.stockin_id == id
                                 select a).ToList();

            //foreach (StockinDetail stockins in stockinDetail)
            //{
            //    var stockin = from b in db.StockinDetails
            //                  join p in db.Products on b.product_id equals p.product_id
            //                  select p;
            //    foreach (Product p in stockin)
            //    {
            //        stockins.Product.product_name = p.product_name;
            //    }
            //}
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            //StockinDetail stockinDetail = db.StockinDetails.Find(id);
            //if (stockinDetail == null)
            //{
            //    return HttpNotFound();
            //}
            return View(stockinDetail);
        }

        // GET: StockinDetails/Create
        public ActionResult Create()
        {
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name");
            ViewBag.stockin_id = new SelectList(db.StockIns, "stockin_id", "stockin_id");
            return View();
        }

        // POST: StockinDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "stockindetail_id,stockin_id,product_id,stockin_quantity,impirce")] StockinDetail stockinDetail)
        {
            if (ModelState.IsValid)
            {
                db.StockinDetails.Add(stockinDetail);
                db.SaveChanges();
                return RedirectToAction("Index","StockIns");
            }

            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", stockinDetail.product_id);
            ViewBag.stockin_id = new SelectList(db.StockIns, "stockin_id", "stockin_id", stockinDetail.stockin_id);
            return View(stockinDetail);
        }

        // GET: StockinDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StockinDetail stockinDetail = db.StockinDetails.Find(id);
            if (stockinDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", stockinDetail.product_id);
            ViewBag.stockin_id = new SelectList(db.StockIns, "stockin_id", "stockin_id", stockinDetail.stockin_id);
            return View(stockinDetail);
        }

        // POST: StockinDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "stockindetail_id,stockin_id,product_id,stockin_quantity,impirce")] StockinDetail stockinDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stockinDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", stockinDetail.product_id);
            ViewBag.stockin_id = new SelectList(db.StockIns, "stockin_id", "stockin_id", stockinDetail.stockin_id);
            return View(stockinDetail);
        }

        // GET: StockinDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StockinDetail stockinDetail = db.StockinDetails.Find(id);
            if (stockinDetail == null)
            {
                return HttpNotFound();
            }
            return View(stockinDetail);
        }

        // POST: StockinDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StockinDetail stockinDetail = db.StockinDetails.Find(id);
            db.StockinDetails.Remove(stockinDetail);
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
