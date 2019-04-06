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
    public class RegionController : Controller
    {
        RegionRepository regionRepository = new RegionRepository();

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
                    dynamic querySearch = regionRepository.findRegions(txtSearch);

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

                dynamic query = regionRepository.GetRegions;
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.listAllCountries = regionRepository.listAllCountries();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Region model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = regionRepository.checkID(model.ID);
                    if (check)
                    {
                        regionRepository.Add(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.listAllCountries = regionRepository.listAllCountries();
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View();
                    }
                }
                ViewBag.listAllCountries = regionRepository.listAllCountries();
                return View(model);
            }
        }

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
                    Region model = regionRepository.GetRegion(Id);
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
                regionRepository.Remove(Id);
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                return View(regionRepository.GetRegion(Id));
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
                    ViewBag.listAllCountries = regionRepository.listAllCountries();
                    var model = regionRepository.GetRegion(Id);
                    return View(model);
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Region model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    regionRepository.Edit(model);
                    return RedirectToAction("Index");
                }
                ViewBag.listAllCountries = regionRepository.listAllCountries();
                return View(model);
            }
        }
    }
}