using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Countries
    {
        [Key]
        [MaxLength(3)]
        public string CountryID { get; set; }

        [MaxLength(50)]
        [Required]
        public string CountryName { get; set; }

        public int Population { get; set; }

        [Required]
        [MaxLength(50)]
        public string Language { get; set; }

        [DisplayFormat(NullDisplayText = "still not updated.")]
        [MaxLength(50)]
        public string MainReligion { get; set; }

        [DisplayFormat(NullDisplayText = "still not updated.")]
        [MaxLength(500)]
        public string OtherDetails { get; set; }
        
        public bool isDelete { get; set; }

        [DisplayName("Regions")]
        public virtual ICollection<Region> tbl_Region { get; set; }
    }
}
