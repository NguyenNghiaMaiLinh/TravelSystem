using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class RegionRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<Region> GetRegions
        {
            get
            {
                return db.tbl_Region.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<Region> findRegions(string searchStr)
        {

            return db.tbl_Region.Where(a => a.Name.Contains(searchStr) && a.isDelete == false).AsNoTracking();
        }

        public List<SelectListItem> listAllCountries()
        {
            List<SelectListItem> listCountries = new List<SelectListItem>();
            listCountries = db.tbl_Country.Select(a => new SelectListItem()
            {
                Value = a.CountryID.ToString(),
                Text = a.CountryName
            }).ToList();
            return listCountries;
        }

        public void Add(Region _Region)
        {
            db.tbl_Region.Add(_Region);
            db.SaveChanges();

        }

        public void Edit(Region _Region)
        {
            var dbEntity = db.tbl_Region.Find(_Region.ID);
            dbEntity.Name = _Region.Name;
            dbEntity.note = _Region.note;
            dbEntity.CountryID = _Region.CountryID;
            db.SaveChanges();
        }

        public Region GetRegion(int? Id)
        {
            return db.tbl_Region.Include(c => c.tbl_Country).SingleOrDefault(m => m.ID == Id);
        }

        public void Remove(int? Id)
        {
            Region dbEntity = db.tbl_Region.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        public bool checkID(int? Id)
        {
            if (db.tbl_Region.FindAsync(Id) != null)
            {
                return false;
            }
            return true;
        }
    }
}

