using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models.ViewModels
{
    public class StudentCourseVM
    {
        public IEnumerable<Enrollments> Enrollments { get; set; }
        public Course Course { get; set; }
    }
}
