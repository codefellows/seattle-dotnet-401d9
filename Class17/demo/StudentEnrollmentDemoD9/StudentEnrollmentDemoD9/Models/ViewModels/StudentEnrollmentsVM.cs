using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models.ViewModels
{
    public class StudentEnrollmentsVM
    {
        public IEnumerable<Enrollments> Enrollments { get; set; }
        public Student Student { get; set; }
    }
}
