using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models
{
    public class Enrollments
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        // Nav Props
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
