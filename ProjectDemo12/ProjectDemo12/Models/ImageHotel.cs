using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class ImageHotel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int HotelID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Path { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Hotel")]
        public virtual Hotel tbl_Hotel { get; set; }
    }
}
