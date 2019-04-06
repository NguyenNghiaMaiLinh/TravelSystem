using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo12.Models;

namespace ProjectDemo12.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            // check session
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Contact()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewData["Message"] = "Your contact page.";

                return View();
            }
            
        }

        public IActionResult NotFoundPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
