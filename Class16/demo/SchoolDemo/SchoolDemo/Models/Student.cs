using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models
{
    public class Student
    {
        // primary key
        public int ID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        // Nav props
        public ICollection<Transcripts> Transcripts { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
