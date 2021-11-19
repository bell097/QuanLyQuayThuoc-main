using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyQuayThuoc.Models;
namespace QuanLyQuayThuoc.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        QuayThuocModelContext db = new QuayThuocModelContext();

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            db.Customers.Add(cus);
            db.SaveChanges();
            return RedirectToAction("ViewCart", "Cart");
        }

    }
}