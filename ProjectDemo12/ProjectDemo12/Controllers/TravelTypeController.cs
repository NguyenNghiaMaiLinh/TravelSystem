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
    public class TravelTypeController : Controller
    {
        TravelTypeRepository travelTypeRepository = new TravelTypeRepository();

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
                    dynamic querySearch = travelTypeRepository.findTravelTypes(txtSearch);
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

                dynamic query = travelTypeRepository.GetAllTravelTypes;
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TravelType model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = travelTypeRepository.checkID(model.ID);
                    if (check)
                    {
                        travelTypeRepository.Add(model);
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
                    return NotFound();
                }
                else
                {
                    TravelType model = travelTypeRepository.GetTravelType(Id);
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
                travelTypeRepository.Remove(Id);
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
                var model = travelTypeRepository.GetTravelType(Id);
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Edit(TravelType model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    travelTypeRepository.Edit(model);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
        }
    }
}