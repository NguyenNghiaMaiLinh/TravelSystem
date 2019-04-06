using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class UserRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<User> GetAllUsers
        {
            get
            {
                return db.tbl_User.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<User> findUsers(string searchStr)
        {

            return db.tbl_User.Where(a => a.FirstName.Contains(searchStr) && a.isDelete == false || a.PhoneNumber.Contains(searchStr) && a.isDelete == false).AsNoTracking();

        }

        public int getCountUsers()
        {
            return db.tbl_User.Where(a => a.isDelete.Equals(false)).Count();
        }


        public User GetUser(string Id)
        {
            return db.tbl_User.Where(a => a.isDelete.Equals(false) && a.Username == Id).FirstOrDefault();
        }

        public void Remove(string Id)
        {
            User dbEntity = db.tbl_User.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

    }
}
