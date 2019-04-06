using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class ConvenientHotel
    {
        [Required]
        public int HotelID { get; set; }

        [Required]
        public int ConvenientID { get; set; }

        public virtual Hotel tbl_Hotel { get; set; }

        public virtual Convenients tbl_Convenient { get; set; }
    }
}
