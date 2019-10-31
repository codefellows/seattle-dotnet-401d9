using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseCode { get; set; }
        public Technology Technology { get; set; }
        public decimal Price { get; set; }

        // nav properties
        public ICollection<Transcripts> Transcripts { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
    }
    public enum Technology
    {
        Python = 1,
        JavaScript,
        DotNet,
        Java
    }
}
