using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Passenger
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public int PassengerID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = false )]
        public DateTime Birthday { get; set; }

        [DisplayName("Male")]
        public bool Gender { get; set; }

        [Required]
        [Phone]
        [Range(10, 12)]
        public string Phone { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int BookingID { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Booking")]
        public virtual Booking tbl_Booking { get; set; }
    }
}
