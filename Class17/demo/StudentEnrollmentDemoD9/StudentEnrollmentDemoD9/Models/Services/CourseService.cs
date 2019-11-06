using Microsoft.EntityFrameworkCore;
using StudentEnrollmentDemoD9.Data;
using StudentEnrollmentDemoD9.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models.Services
{
    public class CourseService : ICourseManager
    {
        private SchoolDbContext _context;

        public CourseService(SchoolDbContext context)
        {
            _context = context;
        }
        public async Task CreateCourse(Course course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourse(int id)
        {
            Course course = await GetCourseById(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

        public async Task<Course> GetCourseById(int id) => await _context.Courses.FirstOrDefaultAsync(crs => crs.ID == id);

        public async Task<List<Course>> GetCourses()
        {
            List<Course> courses =  await _context.Courses.ToListAsync();
            return courses;
        }

        public IEnumerable<Enrollments> GetEnrollmentsByCourse(int courseID)
        {
            var enrollments = _context.Enrollments.Where(x => x.CourseId == courseID)
                                       .Include(e => e.Course)
                                       .Include(e => e.Student);
            return enrollments;
        }

        public async Task UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }
    }
}
