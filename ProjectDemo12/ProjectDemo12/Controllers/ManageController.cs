using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using ProjectDemo12.Repository;

namespace ProjectDemo12.Controllers
{
    public class ManageController : Controller
    {
        DataContext db = new DataContext();

        public IActionResult Report()
        {   
            // Pie Chart about age of user
            ViewBag.ageFrom60To100 = db.tbl_User.FromSql("getAgeFrom60To100").Count();
            ViewBag.ageFrom40To60 = db.tbl_User.FromSql("getAgeFrom40To60").Count();
            ViewBag.ageFrom18To40 = db.tbl_User.FromSql("getAgeFrom18To40").Count();
            ViewBag.ageFrom0To18 = db.tbl_User.FromSql("getAgeFrom0To18").Count();

            // Regions Chart about number tour of each country
            ViewBag.getTourByVietNam = db.tbl_Tour.FromSql("getTourByVietNam").Count();
            ViewBag.getTourByBrazil = db.tbl_Tour.FromSql("getTourByBrazil").Count();
            ViewBag.getTourByChina = db.tbl_Tour.FromSql("getTourByChina").Count();
            ViewBag.getTourByRussia = db.tbl_Tour.FromSql("getTourByRussia").Count();
            ViewBag.getTourByUnitedStates = db.tbl_Tour.FromSql("getTourByUnitedStates").Count();
            ViewBag.getTourByFrance = db.tbl_Tour.FromSql("getTourByFrance").Count();
            ViewBag.getTourByIreland = db.tbl_Tour.FromSql("getTourByIreland").Count();
            ViewBag.getTourByPhilippines = db.tbl_Tour.FromSql("getTourByPhilippines").Count();
            ViewBag.getTourByMalaysia = db.tbl_Tour.FromSql("getTourByMalaysia").Count();
            ViewBag.getTourByKorea = db.tbl_Tour.FromSql("getTourByKorea").Count();
            ViewBag.getTourByJapan = db.tbl_Tour.FromSql("getTourByJapan").Count();
            ViewBag.getTourByCanada = db.tbl_Tour.FromSql("getTourByCanada").Count();
            return View();
        }

    }

}