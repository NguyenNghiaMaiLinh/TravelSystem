using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class HotelRepository
    {

        private DataContext db = new DataContext();

        public IEnumerable<Hotel> GetAllHotels
        {
            get { return db.tbl_Hotel.Where(a => a.isDelete ==false).AsNoTracking(); }
        }

        public IEnumerable<Hotel> findHotels(string searchStr)
        {
            return db.tbl_Hotel.Where(a => a.Name.Contains(searchStr) && a.isDelete == false || a.PhoneNumber.Contains(searchStr) && a.isDelete == false).AsNoTracking();
        }

        public void Add(Hotel _Hotel)
        {
            db.tbl_Hotel.Add(_Hotel);
            db.SaveChanges();

        }

        public List<SelectListItem> listGetConvenient(int? Id)
        {
            List<SelectListItem> listConvenient = new List<SelectListItem>();
            listConvenient = db.tbl_ConvenientHotel
                .Where(a => a.HotelID == Id && a.tbl_Hotel.isDelete ==false && a.tbl_Convenient.isDelete ==false)
                .Select(a => new SelectListItem()
            {
                Value = a.ConvenientID.ToString(),
                Text = a.tbl_Convenient.Convenient
            }).ToList();
            return listConvenient;
        }

        public List<SelectListItem> listAllCities()
        {
            List<SelectListItem> listCities = new List<SelectListItem>();
            listCities = db.tbl_City
                .Where(a => a.isDelete == false)
                .Select(a => new SelectListItem()
                {
                    Value = a.CityID.ToString(),
                    Text = a.CityName
                }).ToList();
            return listCities;
        }

        public IEnumerable<Convenients> getAllConvenients
        {
            get { return db.tbl_Convenient.Where(a => a.isDelete == false).AsNoTracking(); }
        }

        public void AddConvenient(ConvenientHotel _ConvenientHotel)
        {

            db.tbl_ConvenientHotel.Add(_ConvenientHotel);
            db.SaveChanges();
        }

        public void Edit(Hotel _Hotel)
        {
            var dbEntity = db.tbl_Hotel.Find(_Hotel.ID);
            dbEntity.Name = _Hotel.Name;
            dbEntity.PhoneNumber = _Hotel.PhoneNumber;
            dbEntity.Address = _Hotel.Address;
            dbEntity.Email = _Hotel.Email;
            dbEntity.Description = _Hotel.Description;
            dbEntity.RoomNumber = _Hotel.RoomNumber;
            dbEntity.isHot = _Hotel.isHot;
            dbEntity.Price = _Hotel.Price;
            dbEntity.Rating = _Hotel.Rating;
            dbEntity.CityID = _Hotel.CityID;
            dbEntity.Type = _Hotel.Type;
            dbEntity.isParking = _Hotel.isParking;
            dbEntity.isCredit = _Hotel.isCredit;

            db.SaveChanges();
        }

        public Hotel GetHotel(int? Id)
        {
            return db.tbl_Hotel.Include(c => c.tbl_City).Where(a => a.ID == Id && a.isDelete ==false).FirstOrDefault();
        }

        public void Remove(int? Id)
        {
            Hotel dbEntity = db.tbl_Hotel.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        public bool checkID(int? Id)
        {
            if (db.tbl_Hotel.Find(Id) != null)
            {
                return false;
            }
            return true;
        }

        public bool checkConvenientIDInConvenientHotel(int? convenientID, int? hotelID)
        {
            if (db.tbl_ConvenientHotel.Where(a => a.HotelID.Equals(hotelID) && a.ConvenientID.Equals(convenientID)).Count() == 0)
            {
                return true;
            }
            return false;
        }

        public bool checkConvenientID(int? Id)
        {
            if (db.tbl_Convenient.Find(Id) != null)
            {
                return false;
            }
            return true;
        }

        public void AddConvenient(Convenients _Convenients)
        {
            db.tbl_Convenient.Add(_Convenients);
            db.SaveChanges();
        }
    }
}
