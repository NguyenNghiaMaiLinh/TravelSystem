using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Convenients
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Convenient { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Hotels")]
        public virtual ICollection<ConvenientHotel> tbl_ConvenientHotel { get; set; }
    }
}
