using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class FlightRepository
    {
        private DataContext db = new DataContext();

        public void addFlight(Flight _Flight)
        {
            db.tbl_Flight.Add(_Flight);
            db.SaveChanges();
        }

        public bool checkID(string Id)
        {
            if (db.tbl_Flight.Find(Id) != null)
            {
                return false;
            }
            return true;
        }
    }
}
