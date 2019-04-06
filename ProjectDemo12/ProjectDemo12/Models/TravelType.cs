using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class TravelType
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool isDelete { get; set; }

       [DisplayName("Tours")]
        public virtual ICollection<Tour> tbl_Tour { get; set; }

    }
}
