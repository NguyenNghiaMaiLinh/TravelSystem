using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Image
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TourID { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [MaxLength(50)]
        public string Path { get; set; }

        [DisplayName("Tour")]
        public virtual Tour tbl_Tour { get; set; }
    }
}
