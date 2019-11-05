using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Required]
        [Display(Name ="Course Name")]
        public string CourseCode { get; set; }

        [Required]
        public Technology Technology { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }

        // Navigation Properties
        public ICollection<Transcripts> Transcripts { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
    }

    public enum Technology
    {
        [Display(Name = "C#")]
        CSharp = 1,
        Java,
        Python,
        JavaScript
    }
}
