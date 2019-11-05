using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
    public interface ICourseManager
    {
        // Create
        Task CreateCourse(Course course);

        // Read
        Task<Course> GetCourse(int id);

        // Update
        Task UpdateCourse(Course course);

        // Delete
        Task DeleteCourse(int id);

        Task<List<Course>> GetCourses();

        IEnumerable<Enrollments> GetEnrollmentsForCourse(int courseID);
    }

}
