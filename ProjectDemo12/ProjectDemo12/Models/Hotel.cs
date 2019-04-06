using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Hotel
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(10, 12)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayFormat(NullDisplayText = "still not updated.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int RoomNumber { get; set; }

        public bool isHot { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Parking")]
        public Nullable<bool> isParking { get; set; }

        [DisplayName("Credit")]
        public Nullable<bool> isCredit { get; set; }

        [Required]
        public int CityID { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [DisplayName("Tours")]
        public virtual ICollection<TourHotel> tbl_TourHotel { get; set; }

        [DisplayName("City")]
        public virtual City tbl_City { get; set; }

        [DisplayName("ImageHotels")]
        public virtual ICollection<ImageHotel> tbl_ImageHotel { get; set; }

        [DisplayName("Convenients")]
        public virtual ICollection<ConvenientHotel> tbl_ConvenientHotel { get; set; }

    }

}
