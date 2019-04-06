using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectDemo12.Models;
using ProjectDemo12.Repository;
using ReflectionIT.Mvc.Paging;

namespace ProjectDemo12.Controllers
{
    public class CityController : Controller
    {
        //Create object of City Repository
        CityRepository cityRepository = new CityRepository();

        //default page number 1
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
                    dynamic querySearch = cityRepository.findCities(txtSearch);

                    if (querySearch != null)
                    {
                        ViewBag.SearchValue = txtSearch;
                        return View(await PagingList.CreateAsync(querySearch, 10, page));
                    }
                    else
                    {
                        // if list empty, show "Not Found"
                        ViewBag.Empty("Not Found.");
                        return View();
                    }
                }
                // forward city list
                dynamic query = cityRepository.GetAllCities;
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }

        //View Create City
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                // forward Region list
                ViewBag.list = cityRepository.listAllRegion();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(City model)
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
                    // check duplicate ID
                    bool check = cityRepository.checkID(model.CityID);
                    if (check)
                    {
                        cityRepository.Add(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        ViewBag.list = cityRepository.listAllRegion();
                        return View();
                    }
                }
                //forward Region list
                ViewBag.list = cityRepository.listAllRegion();
                return View(model);
            }
        }

        // View Delete City
        [HttpGet]
        public IActionResult Delete(int? Id)
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
                    City model = cityRepository.GetCity(Id);
                    return View(model);
                }
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                cityRepository.Remove(Id);
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public IActionResult Edit(int? Id)
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
                    //forward Region list
                    ViewBag.list = cityRepository.listAllRegion();
                    return View(cityRepository.GetCity(Id));
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(City model)
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
                    cityRepository.Edit(model);
                    return RedirectToAction("Index");
                }
                //forward region list
                ViewBag.list = cityRepository.listAllRegion();
                return View(model);
            }
        }
    }
}