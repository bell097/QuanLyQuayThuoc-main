using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuayThuoc.Controllers
{
    public class SickController : Controller
    {
        QuayThuocModelContext db = new QuayThuocModelContext();
        // GET: Sick
        public ActionResult IndexSick()
        {
            var KetQua = (from item in db.CategorySicks
                          select item).ToList();

            return View(db.CategorySicks.ToList());
        }
        public ActionResult IndexSmallSick(int id)
        {
            var listProduct = db.Sicks.Where(n => n.CategorySick.categorySick_id == id ).ToList();
            return View(listProduct);
        }
        public ActionResult DetailsSick(int id)
        {
            var sick = from p in db.Sicks
                          where p.sick_id == id
                          select p;

            return View(sick);
        }
    }
}