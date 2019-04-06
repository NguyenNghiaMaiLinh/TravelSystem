using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Booking
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public int BookingID { get; set; }

        public Nullable<double> TotalMoney { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        public bool isDelete { get; set; }

        [Required]
        public int NumOfKid { get; set; }

        [Required]
        public int NumOfAdult { get; set; }

        [Required]
        public int NumOfBaBy { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }

        [Phone]
        [Range(10, 12)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string TourID { get; set; }

        [DataType(DataType.Date)]
        public string Birthday { get; set; }

        [Required]
        public string Email { get; set; }

        [DisplayName("Tour")]
        public virtual Tour tbl_Tour { get; set; }

        [DisplayName("User")]
        public virtual User tbl_User { get; set; }

        [DisplayName("Passengers")]
        public virtual ICollection<Passenger> tbl_Passenger { get; set; }
    }
}
