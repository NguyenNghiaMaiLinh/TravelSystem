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
    public class TourController : Controller
    {
        //Create object of TourRepository
        TourRepository tourRepository = new TourRepository();

        //Create object of FlightRepository
        FlightRepository flightRepository = new FlightRepository();

        //Create object of TourDetailRepository
        TourDetailsRepository tourDetailRepository = new TourDetailsRepository();

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
                    dynamic querySearch = tourRepository.findTours(txtSearch);
                    if (querySearch != null)
                    {
                        //keep Search value
                        ViewBag.SearchValue = txtSearch;
                        return View(await PagingList.CreateAsync(querySearch, 10, page));
                    }
                    else
                    {
                        ViewBag.Empty("Not Found.");
                        return View();
                    }
                }
                //get Tour list
                dynamic query = tourRepository.GetAllTours;
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }

        [HttpGet]
        public IActionResult CreatebyCar()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                // forward Flight list
                ViewBag.listAllFlights = tourRepository.listAllFlights();

                // forward Tour Guide list
                ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();

                // forward Travel Type list
                ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();

                // forward City list
                ViewBag.listAllCities = tourRepository.listAllCities();
                return View();
            }
        }

        // view create Tour By Car
        [HttpPost]
        public IActionResult CreatebyCar(Tour model)
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
                    bool check = tourRepository.checkID(model.ID);
                    if (check)
                    {

                        //check Date of tour
                        if(model.TimeEnd.Date.CompareTo(model.TimeBegin.Date) > 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time End must be bigger than Time Begin.");
                            return View();
                        }else if (model.TimeBegin.Date.CompareTo(model.GroupUpTime.Date) != 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Group Time must be must be the same with Time Begin.");
                            return View();
                        }
                        else if (model.TimeEnd.Date.CompareTo(model.GroupUpTime.Date) <= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Group Time must be must be the same with Time End.");
                            return View();
                        }
                        // check price of tour
                        else
                        if (model.PriceForKid > model.PriceForAdult)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Kid.");
                            return View();
                        }else
                        if (model.PriceForBaby > model.PriceForAdult)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Bady.");
                            return View();
                        }
                        else
                        if (model.PriceForBaby > model.PriceForKid)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Price For Kid must be bigger than Price For Bady.");
                            return View();
                        }
                        else if (model.SeatsRemaining.CompareTo(model.TotalSeats) >= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Total Seats must be must be the same with Seat Remaining.");
                            return View();
                        }
                        else
                        {
                            tourRepository.addTour(model);
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View();
                    }
                }
                ViewBag.listAllFlights = tourRepository.listAllFlights();
                ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                ViewBag.listAllCities = tourRepository.listAllCities();
                return View(model);
            }
        }

        // view create tour by Flight
        [HttpGet]
        public IActionResult CreatebyFlight()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.listAllFlights = tourRepository.listAllFlights();
                ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                ViewBag.listAllCities = tourRepository.listAllCities();
                return View();
            }
        }
        [HttpPost]
        public IActionResult CreatebyFlight(Tour model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = tourRepository.checkID(model.ID);
                    if (check)
                    {
                        if (model.TimeBegin.Date.CompareTo(model.TimeEnd.Date) >= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time End must be bigger than Time Begin.");
                            return View(model);
                        }
                        //check date of tour with date of plane
                        /*
                        else if (model.TimeBegin.Date.CompareTo(model.tbl_Flight.DateGo.Date) != 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time Begin must be the same with Date Go of Flight | " + model.tbl_Flight.DateGo);
                            return View(model);
                        }
                        else if (model.TimeEnd.Date.CompareTo(model.tbl_Flight.DateBack.Date) != 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time End must be the same with Date Back of Flight | " + model.tbl_Flight.DateBack);
                            return View(model);
                        }*/
                        else if (model.TimeBegin.Date.CompareTo(model.GroupUpTime.Date) != 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time Begin must be the same with Group Up Time.");
                            return View(model);
                        }
                        //check price of tour
                        else if (model.PriceForKid > model.PriceForAdult)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Kid.");
                            return View();
                        }
                        else
                        if (model.PriceForBaby > model.PriceForAdult)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Bady.");
                            return View();
                        }
                        else
                        if (model.PriceForBaby > model.PriceForKid)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Price For Kid must be bigger than Price For Bady.");
                            return View();
                        }
                        else if (model.SeatsRemaining.CompareTo(model.TotalSeats) >= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Total Seats must be must be the same with Seat Remaining.");
                            return View();
                        }
                        //meeting of flight
                        else if (model.MeetingTime.CompareTo(model.GroupUpTime) >= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Group Up Time must be bigger than Meeting Time.");
                            return View(model);
                        }
                        else if (model.MeetingTime.Date.CompareTo(model.TimeBegin.Date) >= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time Begin must be bigger than Meeting Time.");
                            return View(model);
                        }
                        else if (model.TimeEnd.Date.CompareTo(model.MeetingTime.Date) <= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time End must be bigger than Meeting Time.");
                            return View(model);
                        }
                        else if (model.TimeEnd.Date.CompareTo(model.GroupUpTime.Date) <= 0)
                        {
                            ViewBag.listAllFlights = tourRepository.listAllFlights();
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                            ViewBag.listAllCities = tourRepository.listAllCities();
                            ModelState.AddModelError(string.Empty, "Time End must be bigger than Group Up Time.");
                            return View(model);
                        }
                        else
                        {
                            tourRepository.addTour(model);
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View();
                    }
                }
                ViewBag.listAllFlights = tourRepository.listAllFlights();
                ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                ViewBag.listAllCities = tourRepository.listAllCities();
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult CreateFlight()
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

        //view create Flight with Flight model
        [HttpPost]
        public IActionResult CreateFlight(Flight model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = flightRepository.checkID(model.ID);
                    if (check)
                    {
                       
                        if (model.DateGo.Date.CompareTo(model.DateBack.Date) >= 0)
                        {
                            ModelState.AddModelError(string.Empty, "Date Back must be bigger than Date Go.");
                            return View(model);
                        }
                        else if (model.DateGoArrival.Date.CompareTo(model.DateBackArrival.Date) >= 0)
                        {
                            ModelState.AddModelError(string.Empty, "Date Back Arrival must be bigger than Date Go Arrival.");
                            return View(model);
                        }else
                        if (model.DateGo.CompareTo(model.DateGoArrival) >= 0)
                        {
                            ModelState.AddModelError(string.Empty, "Date Go Arrival must be bigger than Date Go.");
                            return View(model);
                        }
                        else if (model.DateBack.CompareTo(model.DateBackArrival) >= 0)
                        {
                            ModelState.AddModelError(string.Empty, "Date Back Arrival must be bigger than Date Back.");
                            return View(model);
                        }
                        else
                        {
                            //execute addFlight method
                            flightRepository.addFlight(model);

                            //forward FlightID to View
                            ViewBag.FlightID = model.ID;

                            //forward info Flight to View
                            ViewBag.FlightCore = model.CodeGo+" - "+model.CodeBack;

                            //forward Flight list to View
                            ViewBag.listAllFlights = tourRepository.listAllFlights();

                            //forward Tour Guide list to View
                            ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();

                            //forward Travel Type list to View
                            ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();

                            //forward City list to View
                            ViewBag.listAllCities = tourRepository.listAllCities();

                            //return View Create Tour by Flight
                            return View("CreatebyFlight");
                        }
                       
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        return View(model);
                    }
                }

                return View(model);
            }
        }

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
                    Tour model = tourRepository.getTour(Id);
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
                tourRepository.Remove(Id);
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public IActionResult Details(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.listGetHotels = tourRepository.listGetHotels(Id);
                return View(tourRepository.getTour(Id));
            }
        }

        // Id of Tour selected
        [HttpGet]
        public async Task<IActionResult> TourDetails(string Id, int page = 1)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                int numberCountDetails = tourDetailRepository.GetCountTourDetails(Id);
                int numberCountDate = tourDetailRepository.GetCountDate(Id);
                int numberOfMissingDays = numberCountDate - numberCountDetails;
                if (numberOfMissingDays > 0)
                {
                    ViewBag.numberOfMissingDays = numberOfMissingDays;
                }else if(numberOfMissingDays == 0)
                {
                    ViewBag.Error = "full";
                }
                ViewBag.Wanning = tourDetailRepository.GetCountDate(Id);
                dynamic query = tourDetailRepository.GettourDetails(Id);
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }

        //view Create Tour Details
        [HttpGet]
        public IActionResult CreateTourDetails()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.listAllTours = tourDetailRepository.listAllTours();
                ViewBag.listAllCities = tourDetailRepository.listAllCities();
                return View();
            }
        }


        [HttpPost]
        public IActionResult CreateTourDetails(TourDetail model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = tourDetailRepository.checkID(model.ID);
                    if (check)
                    {
                        tourDetailRepository.addTourDetails(model);
                        return View("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "This ID already exists.");
                        ViewBag.listAllTours = tourDetailRepository.listAllTours();
                        ViewBag.listAllCities = tourDetailRepository.listAllCities();
                        return View(model);
                    }
                }

                return View(model);
            }
        }

        //View Edit Tour Details
        [HttpGet]
        public IActionResult EditTourDetails(int? Id)
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
                    ViewBag.listAllTours = tourDetailRepository.listAllTours();
                    ViewBag.listAllCities = tourDetailRepository.listAllCities();
                    return View(tourDetailRepository.GettourDetail(Id));
                }
            }
        }

        [HttpPost]
        public IActionResult EditTourDetails(TourDetail model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                        tourDetailRepository.EditTourDetail(model);
                        return RedirectToAction("Index");
                }
                ViewBag.listAllTours = tourDetailRepository.listAllTours();
                ViewBag.listAllCities = tourDetailRepository.listAllCities();
                return View(model);
            }
        }

        //View Delete Tour Details
        [HttpGet]
        public IActionResult DeleteTourDetails(int? Id)
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
                    TourDetail model = tourDetailRepository.GettourDetail(Id);
                    return View(model);
                }
            }
        }

        [HttpPost, ActionName("DeleteTourDetails")]
        public IActionResult DeleteTourDetailsConfirm(int? Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                tourDetailRepository.remove(Id);
                return RedirectToAction("Index");
            }

        }

        //view Details of Tour Details
        [HttpGet]
        public IActionResult DetailsTourDetails(int Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                return View(tourDetailRepository.GettourDetail(Id));
            }
        }

        //View Edit of Tour Details
        [HttpGet]
        public IActionResult EditByCar(string Id)
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
                    ViewBag.listAllFlights = tourRepository.listAllFlights();
                    ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                    ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                    ViewBag.listAllCities = tourRepository.listAllCities();
                    return View(tourRepository.getTour(Id));
                }
            }
        }

        [HttpPost]
        public IActionResult EditByCar(Tour model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (model.TimeEnd.Date.CompareTo(model.TimeBegin.Date) > 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time End must be bigger than Time Begin.");
                        return View(model);
                    }
                    else if (model.TimeBegin.Date.CompareTo(model.GroupUpTime.Date) != 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Group Time must be must be the same with Time Begin.");
                        return View(model);
                    }
                    else if (model.TimeEnd.Date.CompareTo(model.GroupUpTime.Date) <= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Group Time must be must be the same with Time End.");
                        return View(model);
                    }
                    else
                    if (model.PriceForKid > model.PriceForAdult)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Kid.");
                        return View(model);
                    }
                    else
                    if (model.PriceForBaby > model.PriceForAdult)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Bady.");
                        return View(model);
                    }
                    else
                    if (model.PriceForBaby > model.PriceForKid)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Price For Kid must be bigger than Price For Bady.");
                        return View(model);
                    }
                    else if (model.SeatsRemaining.CompareTo(model.TotalSeats) >= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Total Seats must be must be the same with Seat Remaining.");
                        return View(model);
                    }
                    else
                    {
                        tourRepository.Edit(model);
                        return RedirectToAction("Index");
                    }
                }
                ViewBag.listAllFlights = tourRepository.listAllFlights();
                ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                ViewBag.listAllCities = tourRepository.listAllCities();
                return View(model);
            }
        }

        //View Edit of Tour by Flight
        // Id of Tour 
        [HttpGet]
        public IActionResult EditByFlight(string Id)
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
                    ViewBag.listAllFlights = tourRepository.listAllFlights();
                    ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                    ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                    ViewBag.listAllCities = tourRepository.listAllCities();
                    return View(tourRepository.getTour(Id));
                }
            }
        }


        [HttpPost]
        public IActionResult EditByFlight(Tour model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (model.TimeBegin.Date.CompareTo(model.TimeEnd.Date) >= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time End must be bigger than Time Begin.");
                        return View(model);
                    }
                    else if (!model.TimeBegin.Date.Equals(tourRepository.getFlight(model.FlightID).DateGo.Date))
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time Begin must be the same with Date Go of Flight | " + tourRepository.getFlight(model.FlightID).DateGo.Date);
                        return View(model);
                    }
                    else if (!model.TimeEnd.Date.Equals(tourRepository.getFlight(model.FlightID).DateBack.Date))
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time End must be the same with Date Back of Flight | " + tourRepository.getFlight(model.FlightID).DateBack.Date);
                        return View(model);
                    }
                    else if (model.TimeBegin.Date.CompareTo(model.GroupUpTime.Date) != 0)
                    {

                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time Begin must be the same with Group Up Time.");
                        return View(model);
                    }
                    else if (model.PriceForKid > model.PriceForAdult)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Kid.");
                        return View(model);
                    }
                    else
                    if (model.PriceForBaby > model.PriceForAdult)
                    {

                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Price For Adult must be bigger than Price For Bady.");
                        return View(model);
                    }
                    else
                    if (model.PriceForBaby > model.PriceForKid)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Price For Kid must be bigger than Price For Bady.");
                        return View(model);
                    }
                    else if (model.SeatsRemaining.CompareTo(model.TotalSeats) >= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Total Seats must be must be the same with Seat Remaining.");
                        return View(model);
                    }
                    else if (model.MeetingTime.CompareTo(model.GroupUpTime) >= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Group Up Time must be bigger than Meeting Time.");
                        return View(model);
                    }
                    else if (model.MeetingTime.Date.CompareTo(model.TimeBegin.Date) >= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time Begin must be bigger than Meeting Time.");
                        return View(model);
                    }
                    else if (model.TimeEnd.Date.CompareTo(model.MeetingTime.Date) <= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time End must be bigger than Meeting Time.");
                        return View(model);
                    }
                    else if (model.TimeEnd.Date.CompareTo(model.GroupUpTime.Date) <= 0)
                    {
                        ViewBag.listAllFlights = tourRepository.listAllFlights();
                        ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                        ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                        ViewBag.listAllCities = tourRepository.listAllCities();
                        ModelState.AddModelError(string.Empty, "Time End must be bigger than Group Up Time.");
                        return View(model);
                    }
                    else
                    {
                        // return view Index of Tour
                        tourRepository.Edit(model);
                        return RedirectToAction("Index");
                    }
                }
                ViewBag.listAllFlights = tourRepository.listAllFlights();
                ViewBag.listAllTourGuides = tourRepository.listAllTourGuides();
                ViewBag.listAllTravelTypes = tourRepository.listAllTravelTypes();
                ViewBag.listAllCities = tourRepository.listAllCities();
                return View(model);
            }
        }


        public async Task<IActionResult> AddHotel(string Id, string txtSearch, int page = 1)
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
                    if (!string.IsNullOrEmpty(txtSearch))
                    {
                        dynamic querySearch = tourRepository.findHotels(txtSearch);
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
                    //get temData from AddHotels method
                    if(TempData["Error"] != null) { ViewBag.Error = TempData["Error"].ToString(); }
                    
                    ViewBag.TourID = Id;
                    dynamic query = tourRepository.getAllHotels;
                    return View(await PagingList.CreateAsync(query, 10, page));
                }
            }
        }

        [HttpPost]
        public IActionResult AddHotels(TourHotel model)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    int hotelID = Convert.ToInt32(model.HotelID);
                    string tourID = model.TourID.ToString();
                    if (tourRepository.checkHotelID(tourID, hotelID))
                    {
                        tourRepository.AddHotel(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "This Hotel already exists.");
                        //ViewBag.Error = "This Hotel already exists.";

                        //If the system encounters an error, immediately go to the Addhotel page.
                        //return Redirect("https://localhost:44361/Tour/AddHotel/"+tourID);
                        TempData["Error"] = "This Hotel already exists.";
                        return RedirectToAction("AddHotel","Tour", new { Id = tourID });
                    }

                }
                //If the system encounters an error, immediately go to the Addhotel page.
                return Redirect("https://localhost:44361/Tour/AddHotel/" + model.TourID);
            }
        }

    }
}