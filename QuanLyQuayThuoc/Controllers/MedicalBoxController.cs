using PagedList;
using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuayThuoc.Controllers
{
    public class MedicalBoxController : Controller
    {
        // GET: MedicalBox
        QuayThuocModelContext db = new QuayThuocModelContext();
        public ActionResult IndexMedicalBox()
        {
            return View();
        }

        public ActionResult drawer1(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 1/* || n.smallcategory_id == 2*/).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer2(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 2).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer3(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 3).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer4(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 4).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer5(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 5).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer6(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 6).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer7(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 7).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer8(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 8).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer9(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 9).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer10(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 10).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer11(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 11).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer12(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 12).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }


        public ActionResult drawer13(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 13).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer14(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 14).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer15(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 15).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer16(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 16).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer17(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 17).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer18(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 19).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer19(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 22 || n.smallcategory_id == 23).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult drawer20(string SearchString, string currentFilter, int? page)
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
            listProduct = listProduct.Where(n => n.smallcategory_id == 24).ToList();
            return View(listProduct.ToPagedList(pageNumber, pageSize));
        }
    }
}