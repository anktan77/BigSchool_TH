using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string IdLecturer { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey("Category")]
        public int IdCategory { get; set; }
        public Category Category { get; set; }
    }
}