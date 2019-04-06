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
    public class HotelController : Controller
    {
        //create object of HotelRepository
        HotelRepository hotelRepository = new HotelRepository();

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
                    dynamic querySearch = hotelRepository.findHotels(txtSearch);
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

                dynamic query = hotelRepository.GetAllHotels;
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
                //forward City list
                ViewBag.listAllCities = hotelRepository.listAllCities();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Hotel model)
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
                    //check duplicate Id
                    bool check = hotelRepository.checkID(model.ID);
                    if (check)
                    {
                        //forward city list
                        ViewBag.listAllCities = hotelRepository.listAllCities();
                        hotelRepository.Add(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {

                        ViewBag.listAllCities = hotelRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View();
                    }
                }
                ViewBag.listAllCities = hotelRepository.listAllCities();
                return View(model);
            }
        }

        //view Create Convenient For Hotel
        // Relationship many to many
        [HttpGet]
        public IActionResult CreateConvenient()
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

        // model is Convenients
        // view Create convenients
        [HttpPost]
        public IActionResult CreateConvenient(Convenients model)
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
                    //check duplicate
                    bool check = hotelRepository.checkConvenientID(model.ID);
                    if (check)
                    {
                        hotelRepository.AddConvenient(model);
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
        public IActionResult Details(int? Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                //forward Convenient list
                ViewBag.listGetConvenient = hotelRepository.listGetConvenient(Id);
                return View(hotelRepository.GetHotel(Id));
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
                    Hotel model = hotelRepository.GetHotel(Id);
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
                hotelRepository.Remove(Id);
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
                    //forward City list
                    ViewBag.listAllCities = hotelRepository.listAllCities();
                    var model = hotelRepository.GetHotel(Id);
                    return View(model);
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Hotel model)
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
                    hotelRepository.Edit(model);
                    return RedirectToAction("Index");
                }
                //forward city list
                ViewBag.listAllCities = hotelRepository.listAllCities();
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult AddConvenient(int? Id)
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
                    ViewBag.hotelID = Id;
                    var model = hotelRepository.getAllConvenients;
                    return View(model);
                }
            }
        }

        //View add Convenient for Hotel
        [HttpPost]
        public IActionResult AddConvenient(ConvenientHotel model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //get HotelID
                    int hotelID = Convert.ToInt32(model.HotelID);

                    //get convenientID
                    int convenientID = Convert.ToInt32(model.ConvenientID);

                    // check convenientID and HotelID in HotelConvenient table
                    if(hotelRepository.checkConvenientIDInConvenientHotel(convenientID, hotelID))
                    {
                        //forward HotelID to View
                        ViewBag.hotelID = model.HotelID;

                        // execute addConvenient method
                        hotelRepository.AddConvenient(model);

                        //notification
                        ModelState.AddModelError(string.Empty, "Success.");
                        return View(hotelRepository.getAllConvenients);
                    }
                    else
                    {
                        ViewBag.hotelID = model.HotelID;
                        ModelState.AddModelError(string.Empty, "This Convenient already exists.");
                        return View(hotelRepository.getAllConvenients);
                    }
                    
                }
                ViewBag.hotelID = model.HotelID;
                return View(hotelRepository.getAllConvenients);
            }
        }


    }
}