using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        // Navigation Properties
        public ICollection<Transcripts> Transcripts { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }

    }
}
