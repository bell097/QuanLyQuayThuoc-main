﻿using System;
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
    public class BillDetailsController : Controller
    {
        private QuayThuocModelContext db = new QuayThuocModelContext();

        // GET: BillDetails
        public ActionResult Index()
        {
            var billDetails = db.BillDetails.Include(b => b.Bill).Include(b => b.Product);
            return View(billDetails.ToList());
        }

        // GET: BillDetails/Details/5
        public ActionResult Details(int? id)
        {
            var billDetail = (from a in db.BillDetails
                                 where a.bill_id == id
                                 select a).ToList();
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //BillDetail billDetail = db.BillDetails.Find(id);
            //if (billDetail == null)
            //{
            //    return HttpNotFound();
            //}
            return View(billDetail);
        }

        // GET: BillDetails/Create
        public ActionResult Create()
        {
            ViewBag.bill_id = new SelectList(db.Bills, "bill_id", "cus_Phone");
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name");
            return View();
        }

        // POST: BillDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "billdetail_id,bill_id,product_id,quantitySale,unitPriceSale")] BillDetail billDetail)
        {
            if (ModelState.IsValid)
            {
                db.BillDetails.Add(billDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.bill_id = new SelectList(db.Bills, "bill_id", "cus_Phone", billDetail.bill_id);
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", billDetail.product_id);
            return View(billDetail);
        }

        // GET: BillDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillDetail billDetail = db.BillDetails.Find(id);
            if (billDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.bill_id = new SelectList(db.Bills, "bill_id", "cus_Phone", billDetail.bill_id);
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", billDetail.product_id);
            return View(billDetail);
        }

        // POST: BillDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "billdetail_id,bill_id,product_id,quantitySale,unitPriceSale")] BillDetail billDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.bill_id = new SelectList(db.Bills, "bill_id", "cus_Phone", billDetail.bill_id);
            ViewBag.product_id = new SelectList(db.Products, "product_id", "product_name", billDetail.product_id);
            return View(billDetail);
        }

        // GET: BillDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillDetail billDetail = db.BillDetails.Find(id);
            if (billDetail == null)
            {
                return HttpNotFound();
            }
            return View(billDetail);
        }

        // POST: BillDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillDetail billDetail = db.BillDetails.Find(id);
            db.BillDetails.Remove(billDetail);
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
