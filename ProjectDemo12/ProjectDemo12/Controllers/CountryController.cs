using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo12.Models;
using ProjectDemo12.Repository;
using ReflectionIT.Mvc.Paging;

namespace ProjectDemo12.Controllers
{
    public class CountryController : Controller
    {
        //create object of CountryRepository
        CountryRepository countryRep = new CountryRepository();

        //default page is number 1
        public async Task<IActionResult> Index(string txtSearch, int page = 1)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch))
                {
                    dynamic querySearch = countryRep.findCountries(txtSearch);

                    if (querySearch != null)
                    {
                        ViewBag.SearchValue = txtSearch;
                        return View(await PagingList.CreateAsync(querySearch, 10, page));
                    }
                    else
                    {
                        ViewBag.Empty("Not Found.");
                        return View();
                    }
                }

                dynamic query = countryRep.GetCountries;

                // paging from ReflectionIT.Mvc.Paging
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }

        //View Create Country
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Countries model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                //check validation
                if (ModelState.IsValid)
                {
                    //check duplicate ID of Country
                    bool check = countryRep.checkID(model.CountryID);
                    if (check)
                    {
                        countryRep.Add(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View();
                    }
                }
                return View(model);
            }
        }

        //View Delete
        [HttpGet]
        public IActionResult Delete(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (Id == null)
                {
                    //Error
                    return RedirectToAction("NotFoundPage", "Home");
                }
                else
                {
                    Countries model = countryRep.GetCountry(Id);
                    return View(model);
                }
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                countryRep.Remove(Id);
                return RedirectToAction("Index");
            }
            
        }

        //View Details
        [HttpGet]
        public IActionResult Details(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                return View(countryRep.GetCountry(Id));
            }
        }

        
        [HttpGet]
        public IActionResult Edit(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (Id == null)
                {
                    //Error
                    return RedirectToAction("NotFoundPage", "Home");
                }
                else
                {
                    var model = countryRep.GetCountry(Id);
                    return View(model);
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Countries model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    countryRep.Edit(model);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
        }
    }
}