using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Admin
    {
        [Key]
        [MaxLength(50)]
        public string AdminID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(24)]
        public string AdminPassword { get; set; }


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

        [DisplayName("Male")]
        public bool Sex { get; set; }

        public bool isDelete { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [DisplayName("FeedBacks")]
        public virtual ICollection<FeedBack> tbl_FeedBack { get; set; }
    }
}
