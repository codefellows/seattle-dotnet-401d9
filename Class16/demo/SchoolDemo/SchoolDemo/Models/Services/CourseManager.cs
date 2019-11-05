using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Services
{
    public class CourseManager : ICourseManager
    {
        private SchoolDbContext _context;

        // Inject in our Database so that we can utulize it in our application
        public CourseManager(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task CreateCourse(Course course)
        {
            await _context.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourse(int id)
        {
            // get the course record in it's entirety
            Course course = await GetCourse(id);
            // remove the course from the DB
            _context.Courses.Remove(course);
            // save
            await _context.SaveChangesAsync();

        }

        public async Task<Course> GetCourse(int id) => await _context.Courses.FirstOrDefaultAsync(crs => crs.ID == id);

        public Task<List<Course>> GetCourses()
        {
            // Get all the courses from the Courses table in the DB and convert it to a list
            var courses = _context.Courses.ToListAsync();
            return courses;
        }

        public IEnumerable<Enrollments> GetEnrollmentsForCourse(int courseID)
        {
            // make a call out to the enrollments table to get all enrollments associateed
            // with the course. 

            // returning null to satisfy the requirements. 
            return null;
        }

        public async Task UpdateCourse(Course course)
        {
            // Find the record in the DB that matches the id and update it with the new information
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }
    }
}
