using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Office
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public bool IsOfficeMain { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fax { get; set; }

        [Required]
        [Phone]
        [Range(10, 12)]
        public string Tel { get; set; }

        public bool isDelete { get; set; }

        [Required]
        public int CityID { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayFormat(NullDisplayText = "still not updated.")]
        public string Email { get; set; }

        [DisplayName("City")]
        public virtual City tbl_City { get; set; }

    }
}
