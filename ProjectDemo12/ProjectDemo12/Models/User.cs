using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class User
    {

        [Key]
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MaxLength(24)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        [Range(10, 12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Birthday { get; set; }

        [DisplayName("Male")]
        public bool Sex { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Bookings")]
        public virtual ICollection<Booking> tbl_Booking { get; set; }

        [DisplayName("FeedBacks")]
        public virtual ICollection<FeedBack> tbl_FeedBack { get; set; }
    }
}
