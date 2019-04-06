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
    public class TourGuideRepository
    {
        private DataContext db = new DataContext();

        // get List Tour guide by Enumerable - Use foreach to browse.
        // C# ->7.0 return n value
        // C# <-7/0 OUTPUT - "out" in C#

        // same get data by Store Procedure
        /* public IEnumerable<TourGuide> getTourGuides()
         {
             return db.tbl_TourGuide.FromSql("spGetAllTourGuides").AsNoTracking();
         }
         */
        public IEnumerable<TourGuide> getTourGuides
        {
            get
            {
                return db.tbl_TourGuide.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }
        // same.
        /*
           public IEnumerable<TourGuide> GetAllTourGuides()
       {
           List<TourGuide> listTourGuide = null;
           try {
               using(SqlConnection cnn = new SqlConnection("Server=.;Database=TravelDB;Trusted_Connection=True;MultipleActiveResultSets=true"))
               {
                   using(SqlCommand cmd = new SqlCommand("[spGetAllTourGuides]", cnn))
                   {
                       cmd.CommandType = CommandType.StoredProcedure;
                       if(cnn.State == ConnectionState.Closed)
                       {
                           cnn.Open();
                       }
                       SqlDataReader dr = cmd.ExecuteReader();
                       while (dr.Read())
                       {
                           TourGuide tourGuide = new TourGuide();
                           tourGuide.TourGuideID = Convert.ToInt32(dr["TourGuideID"]);
                           tourGuide.LastName = dr["LastName"].ToString();
                           tourGuide.FirstName = dr["FirstName"].ToString();
                           tourGuide.Address = dr["Address"].ToString();
                           tourGuide.Phone = dr["Phone"].ToString();
                           if(listTourGuide == null)
                           {
                               listTourGuide = new List<TourGuide>();
                           }
                           listTourGuide.Add(tourGuide);
                       }
                   }
               }
           } catch(Exception e)
           {
               throw new Exception(e.Message);
           }
           return listTourGuide;
       }
        */

// find data by Store procedure
        /*
                public IEnumerable<TourGuide> findTourguides(string searchStr)
                {
                    var param = new SqlParameter("@FirstName","%"+ searchStr + "%" );
                    var param1 = new SqlParameter("@Phone", "%" + searchStr + "%");
                    return db.tbl_TourGuide.FromSql("spFindTourGuides @FirstName, @Phone", param, param1).AsNoTracking();
                }
                */
        public IEnumerable<TourGuide> findTourguides(string searchStr)
        {
            return db.tbl_TourGuide.Where(a => a.FirstName.Contains(searchStr) && a.isDelete == false || a.Phone.Contains(searchStr) && a.isDelete ==false).AsNoTracking();
          
        }

        // add Tour Guide to database and stored completely in memory to work offline.
        public void addTourGuide(TourGuide _TourGuide)
        {
            db.tbl_TourGuide.Add(_TourGuide);
            db.SaveChanges();
        }

        // get count Tour Guide in database
        public int getCountTourGuide()
        {
            return db.tbl_TourGuide.Where(a => a.isDelete.Equals(false)).Count();
        }

        // edit Tour Guide informantion to database and stored completely in memory to work offline.
        public void editTourGuide(TourGuide _TourGuide)
        {
            var dbEntity = db.tbl_TourGuide.Find(_TourGuide.TourGuideID);
            dbEntity.FirstName = _TourGuide.FirstName;
            dbEntity.LastName = _TourGuide.LastName;
            dbEntity.Phone = _TourGuide.Phone;
            dbEntity.Address = _TourGuide.Address;
            dbEntity.isDelete = _TourGuide.isDelete;
            db.SaveChanges();
        }

        // get a tour guide from memory to work offline.
        public TourGuide getTourGuide(int? Id)
        {
            return db.tbl_TourGuide.Where(a => a.isDelete.Equals(false) && a.TourGuideID == Id).FirstOrDefault();
        }

        // delete Tour Guide informantion to database and stored completely in memory to work offline.
        public void removeTourGuide(int? Id)
        {
            TourGuide dbEntity = db.tbl_TourGuide.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

        // check Tour Guide ID of  in memory to work offline.
        public bool checkID(int? Id)
        {
            if (db.tbl_TourGuide.FindAsync(Id) != null)
            {
                return false;
            }
            return true;
        }

    }
}
