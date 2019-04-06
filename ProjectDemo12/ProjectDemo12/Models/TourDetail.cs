using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class TourDetail
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }

        [Required]
        [MaxLength(4000)]
        [DataType(DataType.MultilineText)]
        public string DateContent { get; set; }

        public bool isDelete { get; set; }

        [MaxLength(50)]
        [Required]
        public string TourID { get; set; }

        [Required]
        public int CityID { get; set; }

        [DisplayName("City")]
        public virtual City tbl_City { get; set; }

        [DisplayName("Tour")]
        public virtual Tour tbl_Tour { get; set; }
    }
}
