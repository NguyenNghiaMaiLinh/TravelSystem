using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Tour
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime TimeBegin { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime TimeEnd { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double PriceForKid { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double PriceForBaby { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double PriceForAdult { get; set; }

        [MaxLength(50)]
        public string Vehicle { get; set; }

        [Required]
        public int TourGuideID { get; set; }

        [Required]
        public int SeatsRemaining { get; set; }

        [Required]
        public int TotalSeats { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [DisplayName("Sale")]
        public int IsSale { get; set; }

        [Required]
        [DisplayName("From Place")]
        public int fromPlace { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Hot")]
        public bool isHot { get; set; }

        [Range(1, 10)]
        public int rating { get; set; }

        [Required]
        public int TravelTypeID { get; set; }

        [DisplayName("Flight")]
        public string FlightID { get; set; }

        [Required]
        [MaxLength(100)]
        public string GroupUpPlace { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime GroupUpTime { get; set; }

        [MaxLength(100)]
        public string MeetingPlace { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime MeetingTime { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [DisplayName("Bookings")]
        public virtual ICollection<Booking> tbl_Booking { get; set; }

        [DisplayName("FeedBacks")]
        public virtual ICollection<FeedBack> tbl_FeedBack { get; set; }

        [DisplayName("Flight")]
        public virtual Flight tbl_Flight { get; set; }

        [DisplayName("Hotels")]
        public virtual ICollection<TourHotel> tbl_TourHotel { get; set; }

        [DisplayName("Images")]
        public virtual ICollection<Image> tbl_Image { get; set; }

        [DisplayName("Tour Guide")]
        public virtual TourGuide tbl_TourGuide { get; set; }

        
        [DisplayName("City")]
        [ForeignKey("fromPlace")]
        public virtual City fromPlaceModel{ get; set; }

        [DisplayName("Travel Type")]
        public virtual TravelType tbl_TravelType { get; set; }

        [DisplayName("Tour Details")]
        public virtual ICollection<TourDetail> tbl_TourDetail { get; set; }

    }
}
