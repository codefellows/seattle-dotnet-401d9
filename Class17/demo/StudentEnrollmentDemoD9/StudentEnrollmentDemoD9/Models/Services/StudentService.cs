using Microsoft.EntityFrameworkCore;
using StudentEnrollmentDemoD9.Data;
using StudentEnrollmentDemoD9.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models.Services
{
    public class StudentService : IStudentManager
    {
        private SchoolDbContext _context;

        public StudentService(SchoolDbContext context)
        {
            _context = context;
        }
        public async Task CreateStudentAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(int id)
        {
            Student student = await GetStudentByIdAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task EnrollInCourse(int studentID, int courseId)
        {
            Enrollments enrollments = new Enrollments();
            enrollments.CourseId = courseId;
            enrollments.StudentId = studentID;

            _context.Enrollments.Add(enrollments);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id) =>
            await _context.Students.FirstOrDefaultAsync(stu => stu.ID == id);

        public IEnumerable<Enrollments> GetStudentEnrollments(int studentId)
        {
            var enrollments = _context.Enrollments.Where(stu => stu.StudentId == studentId)
                                      .Include(x => x.Course)
                                      .Include(x => x.Student);

            return enrollments;            

        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task UnEnrollInCourse(int studentID, int courseId)
        {
            Enrollments enrollments = new Enrollments();
            enrollments.StudentId = studentID;
            enrollments.CourseId = courseId;
            _context.Enrollments.Remove(enrollments);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStudentAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }
    }
}
