using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class TourDetailsRepository
    {
        DataContext db = new DataContext();

        public List<SelectListItem> listAllTours()
        {
            List<SelectListItem> listTours = new List<SelectListItem>();
            listTours = db.tbl_Tour.Select(a => new SelectListItem()
            {
                Value = a.ID.ToString(),
                Text = a.Name
            }).ToList();
            return listTours;
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

        public IEnumerable<TourDetail>GettourDetails(string Id)
        {
            return db.tbl_TourDetail.Where(a => a.TourID == Id && a.isDelete == false).AsNoTracking();
        }

        public DateTime GetTimeBegin(string Id)
        {
            return db.tbl_Tour.Where(a => a.ID == Id && a.isDelete == false).Select(a => a.TimeBegin).First();
        }

        public DateTime GetTimeEnd(string Id)
        {
            return db.tbl_Tour.Where(a => a.ID == Id && a.isDelete == false).Select(a => a.TimeEnd).First();
        }

        public int GetCountDate(string Id)
        {
            int i = (GetTimeEnd(Id).Date - GetTimeBegin(Id).Date).Days;
            return i;
        }

        public TourDetail GettourDetail(int? Id)
        {
            return db.tbl_TourDetail.Include(a => a.tbl_City).Include(a => a.tbl_Tour).Where(a => a.ID == Id && a.isDelete == false).FirstOrDefault();
        }

        public int GetCountTourDetails (string Id)
        {
            return db.tbl_TourDetail.Where(a => a.TourID == Id && a.isDelete == false).Count();
        }


        public void EditTourDetail(TourDetail _TourDetail)
        {
            var dbEntity = db.tbl_TourDetail.Find(_TourDetail.ID);
            dbEntity.Date = _TourDetail.Date;
            dbEntity.DateContent = _TourDetail.DateContent;
            dbEntity.Title = _TourDetail.Title;
            dbEntity.TourID = _TourDetail.TourID;
            dbEntity.CityID = _TourDetail.CityID;

            db.SaveChanges();
        }

        public void addTourDetails(TourDetail _TourDetail)
        {
            db.tbl_TourDetail.Add(_TourDetail);
            db.SaveChanges();
        }

        public void remove(int? Id)
        {
            var dbEntity = db.tbl_TourDetail.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        public bool checkID(int? Id)
        {
            if (db.tbl_TourDetail.Find(Id) != null)
            {
                return false;
            }
            return true;
        }

    }
}
