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
    public class CountryRepository
    {
        private DataContext db = new DataContext();
        //Get all Country by entity framework
       
                public IEnumerable<Countries> GetCountries
                {
                    get
                    {
                        return db.tbl_Country.Where(a => a.isDelete.Equals(false)).AsNoTracking();
                    }
                }

        public IEnumerable<Countries> findCountries(string searchStr)
        {

                return db.tbl_Country.Where(a => a.CountryName.Contains(searchStr) && a.isDelete == false).AsNoTracking();
            
        }
        // get data by stored procedure
        /*
           public IEnumerable<Countries> GetAllCountries()
           {
               return db.tbl_Country.FromSql("spGetAllCountries").AsNoTracking();
           }
           */

        // get data by stored procedure
        /*
        public IEnumerable<Countries> findCountries(string searchStr)
        {
            var param = new SqlParameter("@Region", "%" + searchStr + "%");
            var param1 = new SqlParameter("@Name", "%" + searchStr + "%" );
            return db.tbl_Country.FromSql("spFindCountries @Region, @Name", param, param1).AsNoTracking();
        }
         */
        public void Add(Countries _Countries)
{
    db.tbl_Country.Add(_Countries);
    db.SaveChanges();

}

public void Edit(Countries _Countries)
{
    var dbEntity = db.tbl_Country.Find(_Countries.CountryID);
    dbEntity.CountryName = _Countries.CountryName;
    dbEntity.Population = _Countries.Population;
    dbEntity.Language = _Countries.Language;
    dbEntity.MainReligion = _Countries.MainReligion;
    dbEntity.OtherDetails = _Countries.OtherDetails;
    db.SaveChanges();
}

public Countries GetCountry(string Id)
{
    return db.tbl_Country.Include(c => c.tbl_Region).Where(a => a.isDelete.Equals(false) && a.CountryID == Id).FirstOrDefault();
        }

public void Remove(string Id)
{
    Countries dbEntity = db.tbl_Country.Find(Id);
    dbEntity.isDelete = true;
    db.SaveChanges();
}

  public bool checkID(string Id)
{
    if (db.tbl_Country.FindAsync(Id) != null)
    {
        return false;
    }
    return true;
}
}
}
