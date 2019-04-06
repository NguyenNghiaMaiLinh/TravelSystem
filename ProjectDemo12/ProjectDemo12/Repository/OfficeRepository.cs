using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class OfficeRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<Office> GetOffices
        {
            get
            {
                return db.tbl_Office.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<Office> findOffices(string searchStr)
        {

            return db.tbl_Office.Where(a => a.Name.Contains(searchStr) && a.isDelete == false).AsNoTracking();
        }

        public List<SelectListItem> listAllCities()
        {
            List<SelectListItem> listCities = new List<SelectListItem>();
            listCities = db.tbl_City.Select(a => new SelectListItem()
            {
                Value = a.CityID.ToString(),
                Text = a.CityName
            }).ToList();
            return listCities;
        }

        public void Add(Office _Office)
        {
            db.tbl_Office.Add(_Office);
            db.SaveChanges();

        }

        public void Edit(Office _Office)
        {
            var dbEntity = db.tbl_Office.Find(_Office.ID);
            dbEntity.Name = _Office.Name;
            dbEntity.IsOfficeMain = _Office.IsOfficeMain;
            dbEntity.Address = _Office.Address;
            dbEntity.Fax = _Office.Fax;
            dbEntity.Tel = _Office.Tel;
            dbEntity.Email = _Office.Email;
            dbEntity.CityID = _Office.CityID;
            db.SaveChanges();
        }

        public Office GetOffice(int? Id)
        {
            return db.tbl_Office.Include(c => c.tbl_City).SingleOrDefault(m => m.ID == Id);
        }

        public void Remove(int? Id)
        {
            Office dbEntity = db.tbl_Office.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        public bool checkID(int? Id)
        {
            if (db.tbl_Office.FindAsync(Id) != null)
            {
                return false;
            }
            return true;
        }
    }
}
