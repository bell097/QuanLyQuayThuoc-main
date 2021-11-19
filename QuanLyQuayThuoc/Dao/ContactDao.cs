using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuayThuoc.Models;

namespace QuanLyQuayThuoc.Dao
{
    public class ContactDao
    {
        QuayThuocModelContext db = null;
        public ContactDao()
        {
            db = new QuayThuocModelContext();
        }

        public Contact GetActiveContact()
        {
            return db.Contacts.Single(s => s.contact_status == 1);
        }

        public int  InsertFeedBack(Feedback fb)
        {
            db.Feedbacks.Add(fb);
            db.SaveChanges();
            return fb.fb_id;
        }
    }
}