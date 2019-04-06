using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{

    public class TourGuide
    {
        [Key]
        [Required]
        public int TourGuideID { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Phone]
        [Range(10, 12)]
        public string Phone { get; set; }

        [Required]
        [DisplayFormat(NullDisplayText ="No update.")]
        [MaxLength(50)]
        public string Address { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Tours")]
        public virtual ICollection<Tour> tbl_Tour { get; set; }
    }
}
