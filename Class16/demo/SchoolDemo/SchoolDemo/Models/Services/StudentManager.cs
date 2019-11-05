using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Services
{
    public class StudentManager : IStudentManager
    {
        private SchoolDbContext _context;

        public StudentManager(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudent(int id)
        {
            Student student = await GetStudent(id);

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(st => st.ID == id);
        }

        public IEnumerable<Enrollments> GetStudentEnrollments(int studentID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Transcripts>> GetStudentTranscripts(int studentID)
        {
            var studentTranscripts = await _context.Transcripts
            .Where(x => x.StudentID == studentID)
            .Include(c => c.Course)
            .Include(c => c.Student)
            .ToListAsync();

            return studentTranscripts;
        }

        public Task UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
