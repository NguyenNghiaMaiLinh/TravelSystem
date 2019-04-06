using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class BookingRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<Booking> GetAllBookings
        {
            get
            {
                return db.tbl_Booking.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<Booking> findBookings(string searchStr)
        {

            return db.tbl_Booking.Where(a => a.Name.Contains(searchStr) && a.isDelete == false || a.Phone.Contains(searchStr) && a.isDelete ==false).AsNoTracking();
        }

        public Booking GetBooking(int? Id)
        {
            return db.tbl_Booking.Include(c => c.tbl_User).Include(n => n.tbl_Tour).Where(a => a.isDelete.Equals(false) && a.BookingID == Id).FirstOrDefault();
        }

    }
}
