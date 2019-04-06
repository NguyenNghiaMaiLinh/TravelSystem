using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class City
    {
        [Key]
        [Required]
        public int CityID { get; set; }

        [Required]
        [ForeignKey("Region")]
        public int RegionID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }

        [MaxLength(50)]
        public string CityLocation { get; set; }

        [MaxLength(50)]
        public string OtherDetails { get; set; }


        public bool isDelete { get; set; }

        [DisplayName("Region")]
        public virtual Region tbl_Region { get; set; }

        [DisplayName("TourDetails")]
        public virtual ICollection<TourDetail> tbl_TourDetail { get; set; }

        [DisplayName("Hotels")]
        public virtual ICollection<Hotel> tbl_Hotel { get; set; }

        [DisplayName("Offices")]
        public virtual ICollection<Office> tbl_Office { get; set; }

        [DisplayName("Tours")]
        public virtual ICollection<Tour> tbl_Tour { get; set; }
    }
}
