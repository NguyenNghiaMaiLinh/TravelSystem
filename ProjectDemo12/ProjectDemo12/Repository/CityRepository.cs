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
    public class CityRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<City> GetAllCities
        {
            get
            {
                return db.tbl_City.Include(c => c.tbl_Region).Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public List<SelectListItem> listAllRegion()
        {
            List<SelectListItem> listRegions = new List<SelectListItem>();
            listRegions = db.tbl_Region.Select(a => new SelectListItem()
            {
                Value = a.ID.ToString(),
                Text = a.Name
            }).ToList();
            return listRegions;
        }

        public IEnumerable<City> findCities(string searchStr)
        {

            return db.tbl_City.Where(a => a.CityName.Contains(searchStr) && a.isDelete == false).AsNoTracking();
        }

        public void Add(City _City)
        {
            db.tbl_City.Add(_City);
            db.SaveChanges();

        }

        public void Edit(City _City)
        {
            var dbEntity = db.tbl_City.Find(_City.CityID);
            dbEntity.CityName = _City.CityName;
            dbEntity.RegionID = _City.RegionID;
            dbEntity.CityLocation = _City.CityLocation;
            dbEntity.OtherDetails = _City.OtherDetails;
            db.SaveChanges();
        }

        public City GetCity(int? Id)
        {
            var aa = db.tbl_City.Include(c => c.tbl_Region).Where(a => a.isDelete.Equals(false) && a.CityID == Id).FirstOrDefault();
            return aa;
        }

        public void Remove(int? Id)
        {
            City dbEntity = db.tbl_City.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        public bool checkID(int? Id)
        {
            if (db.tbl_City.FindAsync(Id) != null)
            {
                return false;
            }
            return true;
        }
    }
}
