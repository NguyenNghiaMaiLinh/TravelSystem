using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class TourHotel
    {
        [Required]
        public int HotelID { get; set; }

        [Required]
        public string TourID { get; set; }
        public virtual Hotel tbl_Hotel { get; set; }
        public virtual Tour tbl_Tour { get; set; }
    }
}
