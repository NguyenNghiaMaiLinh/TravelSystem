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
    public class TravelTypeRepository
    {

        private DataContext db = new DataContext();

        public IEnumerable<TravelType> GetAllTravelTypes
        {
            get
            {
                return db.tbl_Travel_Type.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<TravelType> findTravelTypes(string searchStr)
        {
            return db.tbl_Travel_Type.Where(a => a.Name.Contains(searchStr) && a.isDelete == false).AsNoTracking();

        }

        public void Add(TravelType _TravelType)
        {
            db.tbl_Travel_Type.Add(_TravelType);
            db.SaveChanges();

        }

        public void Edit(TravelType _TravelType)
        {
            var dbEntity = db.tbl_Travel_Type.Find(_TravelType.ID);
            dbEntity.Name = _TravelType.Name;
            db.SaveChanges();
        }

        public TravelType GetTravelType(int? Id)
        {
            return db.tbl_Travel_Type.Where(a => a.isDelete.Equals(false) && a.ID == Id).FirstOrDefault();
        }

        public void Remove(int? Id)
        {
            TravelType dbEntity = db.tbl_Travel_Type.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        public bool checkID(int? Id)
        {
            if (db.tbl_Travel_Type.Find(Id) != null)
            {
                return false;
            }
            return true;
        }
    }
}
