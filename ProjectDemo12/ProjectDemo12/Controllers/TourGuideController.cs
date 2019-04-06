 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectDemo12.Models;
using ProjectDemo12.Repository;
using ReflectionIT.Mvc.Paging;

namespace ProjectDemo12.Controllers
{
    
    public class TourGuideController : Controller
    {
        //Create object of class TourGuideRepository.
        TourGuideRepository tourGuideRepostory = new TourGuideRepository();

        //
        
        public async Task<IActionResult> Index(string txtSearch = null, int page =1)
        {
            

            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login","Admin");
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch))
                {
                    dynamic querySearch = tourGuideRepostory.findTourguides(txtSearch);
                    if (querySearch != null)
                    {

                        ViewBag.SearchValue = txtSearch;
                        ViewBag.Count = tourGuideRepostory.getCountTourGuide();
                        return View(await PagingList.CreateAsync(querySearch, 10, page));
                    }
                    else
                    {
                        ViewBag.Empty("Not Found.");
                        return View();
                    }
                }
                ViewBag.Count = tourGuideRepostory.getCountTourGuide();
                dynamic query = tourGuideRepostory.getTourGuides;
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
                return View();
            }
        }


        [HttpPost]
        public IActionResult Create(TourGuide model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = tourGuideRepostory.checkID(model.TourGuideID);
                    if (check)
                    {
                        tourGuideRepostory.addTourGuide(model);
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
                    return RedirectToAction("NotFoundPage");
                }
                else
                {
                    TourGuide model = tourGuideRepostory.getTourGuide(Id);
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
                tourGuideRepostory.removeTourGuide(Id);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("NotFoundPage");
            }
            else
            {
                return View(tourGuideRepostory.getTourGuide(Id));
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
                    return RedirectToAction("NotFoundPage");
                }
                else
                {
                    var model = tourGuideRepostory.getTourGuide(Id);
                    return View(model);
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(TourGuide model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    tourGuideRepostory.editTourGuide(model);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
        }

        public IActionResult NotFoundPage()
        {
            return View();
        }
    }
}