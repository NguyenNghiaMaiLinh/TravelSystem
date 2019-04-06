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
    public class PassengerRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<Passenger> GetAllPassengers
        {
            get
            {
                return db.tbl_Passenger.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<Passenger> findPassengers(string searchStr)
        {

            return db.tbl_Passenger.Where(a => a.Fullname.Contains(searchStr) && a.isDelete == false || a.Phone.Contains(searchStr) && a.isDelete ==false).AsNoTracking();
        }

        public List<SelectListItem> listAllBookings()
        {
            List<SelectListItem> listBookings = new List<SelectListItem>();
            listBookings = db.tbl_Booking.Select(a => new SelectListItem()
            {
                Value = a.BookingID.ToString(),
                Text = a.Name
            }).ToList();
            return listBookings;
        }
     
        public Passenger GetPassenger(string Id)
        {
            return db.tbl_Passenger.Include(c => c.tbl_Booking).Where(a => a.isDelete.Equals(false) && a.PassengerID.Equals(Id)).FirstOrDefault();
        }

    
    }
}
