using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models.Interfaces
{
    public interface ICourseManager
    {
        // Decide on behaviors that we want our interface for courses to have.

        // Create
        Task CreateCourse(Course course);

        // Get Course
        Task<Course> GetCourseById(int id);

        Task<List<Course>> GetCourses();

        // Update Course
        Task UpdateCourse(Course course);

        // Delete Course
        Task DeleteCourse(int id);
    }
}
