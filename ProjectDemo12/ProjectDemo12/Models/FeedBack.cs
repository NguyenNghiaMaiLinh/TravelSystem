using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Models
{
    public class FeedBack
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FeedBackContent { get; set; }

        public bool isDelete { get; set; }

        public Nullable<int> ReplyTo { get; set; }

        public string Username { get; set; }

        [Required]
        public string TourID { get; set; }

        public string AdminID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }

        [DisplayName("Admin")]
        public virtual Admin tbl_Admin { get; set; }

        [DisplayName("FeedBacks")]
        public virtual ICollection<FeedBack> tbl_FeedBack1 { get; set; }

        [DisplayName("FeedBack")]
        public virtual FeedBack tbl_FeedBack2 { get; set; }

        [DisplayName("Tour")]
        public virtual Tour tbl_Tour { get; set; }

        [DisplayName("User")]
        public virtual User tbl_User { get; set; }
    }
}
