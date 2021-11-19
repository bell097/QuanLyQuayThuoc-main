using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace QuanLyQuayThuoc.Controllers
{
    public class CartController : Controller
    {
        QuayThuocModelContext db = new QuayThuocModelContext();



        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;

            }
            return cart;
        }
        // them san pham vao gio hang
        public ActionResult AddItem(string id)
        {
            var pro = db.Products.SingleOrDefault(s => s.product_id == id);
            if (pro != null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("ViewCart", "Cart");
        }
        //trang gio hang
        public ActionResult ViewCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("ViewCart", "Cart");
            Cart cart = Session["Cart"] as Cart;
            return View(cart);

        }
        // cap nhat gio hang
        public ActionResult Update_quatity_cart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            string _pro_id = form["ID_Product"];
            int quantity = int.Parse(form["Quantity"]);
            cart.Update_quantityCart(_pro_id, quantity);
            return RedirectToAction("ViewCart", "Cart");
        }
        // xoa gio hang
        public  ActionResult RemoveCart(string id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove_CartItem(id);
            return RedirectToAction("ViewCart", "Cart");
        }

        public PartialViewResult BagCart()
        {
            int total_item = 0;
            Cart cart = Session["Cart"] as Cart;
            if(cart != null)
            
                total_item = cart.Total_Quantity_in_Cart();
                ViewBag.quantityCart = total_item;
                return PartialView("BagCart");
            
        }
        public ActionResult Shoping_Success()
        {
            return View();
        }

        public ActionResult IndexCheckout(FormCollection form)
        {
            try
            {
                Cart cart = Session["Cart"] as Cart;
                Bill _bill = new Bill();
                _bill.bill_date = DateTime.Now;
                _bill.cus_Phone = form["cus_Phone"];
                _bill.seller = form["seller_Name"];
                db.Bills.Add(_bill);
                foreach(var item in cart.Items)
                {
                    BillDetail _bill_Detail = new BillDetail();
                    _bill_Detail.billdetail_id = _bill.bill_id;
                    _bill_Detail.product_id = item.productCart.product_id;
                    _bill_Detail.unitPriceSale = item.productCart.product_saleprice;
                    _bill_Detail.quantitySale = item.quantityCart;
                    
                    db.BillDetails.Add(_bill_Detail);
                }
                db.SaveChanges();
                cart.ClearCart();
                return RedirectToAction("Shoping_Success", "Cart");
            }
            catch
            {
                return Content("Xin lỗi. Hãy đăng kí thông tin khách hàng trước khi mua!");
            }
        }
    }
}