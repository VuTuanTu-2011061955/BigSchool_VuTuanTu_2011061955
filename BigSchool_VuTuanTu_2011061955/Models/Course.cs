using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_VuTuanTu_2011061955.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]

        public string LecturerId { get; set; }
        [Required]

        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public Category Category { get; set; }
        [Required]

        public byte CateroryId { get; set; }
    }
}
