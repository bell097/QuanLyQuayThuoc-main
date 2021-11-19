using PagedList;
using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuayThuoc.Controllers
{
    public class ProductController : Controller
    {
        QuayThuocModelContext db = new QuayThuocModelContext();
        // GET: Product
        public ActionResult IndexProduct(string SearchString, string currentFilter, int? page)
        {
            var listProduct = new List<Product>();
            if (SearchString != null)
            {
                page = 1;
            }
            else
            {
                SearchString = currentFilter;
            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                listProduct = db.Products.Where(n => n.product_name.Contains(SearchString)).ToList();
            }
            else 
            {
                listProduct = db.Products.ToList();
            }
            ViewBag.CurrentFilter = SearchString;
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            listProduct = listProduct.Where(n => n.product_status == 1).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
            //var KetQua = (from item in db.Products
            //              select item).ToList();

            //return View(db.Products.ToList());

        }

        // GET: Product/Details/5
        public ActionResult DetailsProduct(string id)
        {
            var product = from p in db.Products
                          where p.product_id == id
                          select p;

            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
