using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Flight
    {
        [Key]
        [MaxLength(100)]
        [Required]
        public string ID { get; set; }

        [Required]
        public DateTime DateGo { get; set; }

        [Required]

        public DateTime DateBack { get; set; }

        [Required]
        [MaxLength(100)]
        public string CodeGo { get; set; }

        [Required]
        [MaxLength(100)]
        public string CodeBack { get; set; }

        [Required]
        public DateTime DateGoArrival { get; set; }

        [Required]
        public DateTime DateBackArrival { get; set; }

        public bool isDelete { get; set; }

        [DisplayName("Tours")]
        public virtual ICollection<Tour> tbl_Tour { get; set; }
    }
}
