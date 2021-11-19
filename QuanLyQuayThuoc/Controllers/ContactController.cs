using QuanLyQuayThuoc.Dao;
using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuayThuoc.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult IndexContact()
        {
            var model = new ContactDao().GetActiveContact();
            return View(model);
        }

        public JsonResult Send(string name, string email, string phone, string message)
        {
            var feedback = new Feedback();
            feedback.fb_name = name;
            feedback.fb_email = email;
            feedback.fb_phone = phone;
            feedback.fb_message = message;
            feedback.fb_createDate = DateTime.Now;

            var id = new ContactDao().InsertFeedBack(feedback);
            if (id > 0)
                return Json(new
                {
                    status = true
                });
            else
                return Json(new
                {
                    status = false
                });
        }
    }
}