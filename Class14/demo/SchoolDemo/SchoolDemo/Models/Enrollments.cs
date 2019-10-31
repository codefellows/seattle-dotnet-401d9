using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models
{
    public class Enrollments
    {
        // composite keys for the pure join table
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        
        // Nav Props
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
