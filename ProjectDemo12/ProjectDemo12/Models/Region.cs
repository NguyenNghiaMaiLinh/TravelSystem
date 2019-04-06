using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Region
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public bool isDelete { get; set; }

        [DisplayFormat(NullDisplayText = "still not updated.")]
        public string note { get; set; }

        [Required]
        [MaxLength(3)]
        [ForeignKey("Country")]
        public string CountryID { get; set; }

        [DisplayName("Cities")]
        public virtual ICollection<City> tbl_City { get; set; }

        [DisplayName("Country")]
        public virtual Countries tbl_Country { get; set; }
    }
}
