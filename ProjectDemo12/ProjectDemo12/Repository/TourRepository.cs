using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectDemo12.Repository
{
    public class TourRepository
    {
        private DataContext db = new DataContext();

        public IEnumerable<Tour> GetAllTours
        {
            get
            {
                return db.tbl_Tour.Where(a => a.isDelete.Equals(false)).AsNoTracking();
            }
        }

        public List<SelectListItem> listAllTourGuides()
        {
            List<SelectListItem> listTourGuides = new List<SelectListItem>();
            listTourGuides = db.tbl_TourGuide.Select(a => new SelectListItem()
            {
                Value = a.TourGuideID.ToString(),
                Text = a.FirstName
            }).ToList();
            return listTourGuides;
        }

        public List<SelectListItem> listAllCities()
        {
            List<SelectListItem> listCities = new List<SelectListItem>();
            listCities = db.tbl_City.Select(a => new SelectListItem()
            {
                Value = a.CityID.ToString(),
                Text = a.CityName
            }).ToList();
            return listCities;
        }

        public List<SelectListItem> listAllTravelTypes()
        {
            List<SelectListItem> listTravelTypes = new List<SelectListItem>();
            listTravelTypes = db.tbl_Travel_Type.Select(a => new SelectListItem()
            {
                Value = a.ID.ToString(),
                Text = a.Name
            }).ToList();
            return listTravelTypes;
        }

        public List<SelectListItem> listAllFlights()
        {
            List<SelectListItem> listFlights = new List<SelectListItem>();
            listFlights = db.tbl_Flight.Select(a => new SelectListItem()
            {
                Value = a.ID.ToString(),
                Text = a.CodeGo +" - "+ a.CodeBack
            }).ToList();
            return listFlights;
        }

        public List<SelectListItem> listGetHotels(string Id)
        {
            List<SelectListItem> listHotels = new List<SelectListItem>();
            listHotels = db.tbl_TourHotel
                .Where(a => a.TourID == Id && a.tbl_Tour.isDelete ==false && a.tbl_Hotel.isDelete ==false)
                .Select(a => new SelectListItem()
            {
                Value = a.tbl_Hotel.ID.ToString(),
                Text = a.tbl_Hotel.Name
            }).ToList();
            return listHotels;
        }

        public List<SelectListItem> getHoTelLists(string Id)
        {
            List<SelectListItem> getHoTelList = new List<SelectListItem>();
            getHoTelList = db.tbl_TourHotel
                .Where(a => a.TourID.Equals(Id) && a.tbl_Tour.isDelete.Equals(false) && a.tbl_Hotel.isDelete.Equals(false))
                .Select(a => new SelectListItem()
            {
                Value = a.HotelID.ToString(),
                Text = a.tbl_Hotel.Name
            }).ToList();
            return getHoTelList;
        }

        public IEnumerable<Hotel> findHotels(string searchStr)
        {
            return db.tbl_Hotel.Where(a => a.Name.Contains(searchStr) && a.isDelete == false || a.PhoneNumber.Contains(searchStr) && a.isDelete == false).AsNoTracking();
        }

        public IEnumerable<Hotel> getAllHotels
        {
            get { return db.tbl_Hotel.Where(a => a.isDelete == false).AsNoTracking(); }
        }

        public Flight getFlight (string flightID)
        {
            return db.tbl_Flight.Where(a => a.ID == flightID && a.isDelete == false).First();
        }

        public IEnumerable<Tour> findTours(string searchStr)
        {
            return db.tbl_Tour.Where(a => a.Name.Contains(searchStr) && a.isDelete == false).AsNoTracking();

        }

        public void AddHotel(TourHotel _TourHotel)
        {

            db.tbl_TourHotel.Add(_TourHotel);
            db.SaveChanges();
        }

        public bool checkHotelID(string tourID, int? hotelID)
        {
            if (db.tbl_TourHotel
                .Where(a => a.HotelID.Equals(hotelID) && a.TourID.Equals(tourID)).Count() == 0)
            {
                return true;
            }
            return false;
        }

        public Tour getTour(string Id)
        {
            return db.tbl_Tour.Include(a => a.tbl_Flight).Include(a => a.tbl_TourGuide)
                .Include(a => a.tbl_TravelType).Include(b => b.fromPlaceModel).Where(a => a.isDelete.Equals(false) && a.ID == Id).FirstOrDefault();

        }

        public void addTour(Tour _Tour)
        {
            db.tbl_Tour.Add(_Tour);
            db.SaveChanges();
        }

        public void Remove(string Id)
        {
            Tour dbEntity = db.tbl_Tour.Find(Id);
            dbEntity.isDelete = true;
            db.SaveChanges();
        }

      
        public void Edit(Tour _Tour)
        {
            var dbEntity = db.tbl_Tour.Find(_Tour.ID);
            dbEntity.TimeBegin = _Tour.TimeBegin;
            dbEntity.TimeEnd = _Tour.TimeEnd;
            dbEntity.Name = _Tour.Name;
            dbEntity.PriceForAdult = _Tour.PriceForAdult;
            dbEntity.PriceForBaby = _Tour.PriceForBaby;
            dbEntity.PriceForKid = _Tour.PriceForKid;
            dbEntity.Vehicle = _Tour.Vehicle;
            dbEntity.TourGuideID = _Tour.TourGuideID;
            dbEntity.SeatsRemaining = _Tour.SeatsRemaining;
            dbEntity.TotalSeats = _Tour.TotalSeats;
            dbEntity.Description = _Tour.Description;
            dbEntity.IsSale = _Tour.IsSale;
            dbEntity.TravelTypeID = _Tour.TravelTypeID;
            dbEntity.fromPlace = _Tour.fromPlace;
            dbEntity.isHot = _Tour.isHot;
            dbEntity.rating = _Tour.rating;
            dbEntity.FlightID = _Tour.FlightID;
            dbEntity.GroupUpPlace = _Tour.GroupUpPlace;
            dbEntity.GroupUpTime = _Tour.GroupUpTime;
            dbEntity.MeetingPlace = _Tour.MeetingPlace;
            dbEntity.MeetingTime = _Tour.MeetingTime;
            dbEntity.Note = _Tour.Note;
          
            db.SaveChanges();
        }


        public bool checkID(string Id)
        {
            if (db.tbl_Tour.Find(Id) != null)
            {
                return false;
            }
            return true;
        }
    }
}
