using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class Metadata
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string WebName { get; set; }

        [Required]
        public string Copyright { get; set; }

        public bool isDelete { get; set; }

        [Required]
        public int Count { get; set; }

    }
}
