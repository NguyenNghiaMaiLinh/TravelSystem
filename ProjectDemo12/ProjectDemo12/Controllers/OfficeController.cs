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
    public class OfficeController : Controller
    {
        OfficeRepository officeRepository = new OfficeRepository();

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
                    dynamic querySearch = officeRepository.findOffices(txtSearch);

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

                dynamic query = officeRepository.GetOffices;
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
                ViewBag.listAllCities = officeRepository.listAllCities();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Office model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = officeRepository.checkID(model.ID);
                    if (check)
                    {
                        officeRepository.Add(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.listAllCities = officeRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View();
                    }
                }
                ViewBag.listAllCities = officeRepository.listAllCities();
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
                    Office model = officeRepository.GetOffice(Id);
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
                officeRepository.Remove(Id);
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
                return View(officeRepository.GetOffice(Id));
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
                    ViewBag.listAllCities = officeRepository.listAllCities();
                    var model = officeRepository.GetOffice(Id);
                    return View(model);
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Office model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    officeRepository.Edit(model);
                    return RedirectToAction("Index");
                }
                ViewBag.listAllCitiess = officeRepository.listAllCities();
                return View(model);
            }
        }
    }
}