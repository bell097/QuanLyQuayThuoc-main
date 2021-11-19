using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyQuayThuoc.Models
{
    public class CartItem
    {
        public Product productCart { get; set; }
        public int quantityCart { get; set; }
    }

    public class Cart
    {
        List<CartItem> items = new List<CartItem>();

        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(Product _pro, int _qua = 1)
        {
            var item = items.FirstOrDefault(s => s.productCart.product_id == _pro.product_id);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    productCart = _pro,
                    quantityCart = _qua
                });
            }
            else
            {
                item.quantityCart += _qua;
            }
        }

        public void Update_quantityCart(string id, int _qua)
        {
            var item = items.Find(s => s.productCart.product_id == id);
         
                if (item != null)
                {
                    item.quantityCart = _qua;
                }
   
        }

        public double Total_Money()
        {
            var total = items.Sum(s => s.productCart.product_saleprice * s.quantityCart);
            return (double)total;
        }

        public void Remove_CartItem(string id)
        {
            items.RemoveAll(s => s.productCart.product_id == id);
        }    
        // tong so luong shoping
        public int Total_Quantity_in_Cart()
        {
            return items.Sum(s => s.quantityCart);
        }
        //
        public void ClearCart()
        { 
            items.Clear(); // xoa gio hang de thuc hien order moi
        }
    }
}
