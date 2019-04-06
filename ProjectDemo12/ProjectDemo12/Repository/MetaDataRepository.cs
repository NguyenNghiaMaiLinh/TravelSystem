
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class MetaDataRepository
    {
        private DataContext db = new DataContext();
        //Get all Country by entity framework

        public IEnumerable<Metadata> GetMetadatas
        {
            get
            {
                return db.tbl_Metadata.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public IEnumerable<Metadata> findMetadatas(string searchStr)
        {

            return db.tbl_Metadata.Where(a => a.WebName.Contains(searchStr) && a.isDelete == false).AsNoTracking();

        }

    }

}
