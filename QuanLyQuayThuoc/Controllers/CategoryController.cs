using PagedList;
using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuayThuoc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        QuayThuocModelContext db = new QuayThuocModelContext();
        public ActionResult ViewCategory(int id, string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.SmallCategory.category_id == id).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
            //var listProduct = db.Products.Where(n => n.SmallCategory.category_id == id).ToList();
            //return View(listProduct);
        }
        public ActionResult ViewSmallCategory(int id, string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == id).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
            //var listProduct1 = db.Products.Where(n => n.smallcategory_id == id).ToList();
            //return View(listProduct1);
        }
    }
}