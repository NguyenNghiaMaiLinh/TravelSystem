using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo12.Models;
using ProjectDemo12.Repository;

namespace ProjectDemo12.Controllers
{
    public class AdminController : Controller
    {
        // create object of DataContext to get data
        private DataContext db = new DataContext();

        // View Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // View Login Return Data
        [HttpPost]
        public IActionResult Login(string AdminID, string Password)
        {
            var admin = CheckAccount(AdminID, Password);
            if (admin == null)
            {
                ViewBag.error = "Username or Password is not valid!";
                return View("Login");
            }
            else
            {
                // assign data for session
                HttpContext.Session.SetString("Name", admin.FirstName);
                HttpContext.Session.SetString("ID", AdminID);
                return RedirectToAction("Index","Home");
            }

        }

        //Method Logout
        [HttpGet]
        public IActionResult Logout()
        {
            // Remove Session and clear session, the same.
            HttpContext.Session.Remove("ID");
            HttpContext.Session.Remove("Name");
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        //Method check Username and Password
        private Admin CheckAccount(string AdminID, string Password)
        {
            Admin admin = db.tbl_Admin.SingleOrDefault(a => a.AdminID.Equals(AdminID));
            if (admin != null)
            {
                // decryption Password of admin 
                if (BCrypt.Net.BCrypt.Verify(Password, admin.AdminPassword))
                {
                    return admin;
                }
            }
            return null;
        }
    }

}