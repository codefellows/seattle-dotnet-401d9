using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
    interface IStudentManager
    {
        // Create
        Task CreateStudent(Student student);

        // Read
        Task<Student> GetStudent(int id);

        // Update
        Task UpdateStudent(Student student);

        // Delete
        Task DeleteStudent(int id);

        Task<List<Student>> GetStudents();

        IEnumerable<Enrollments> GetStudentEnrollments(int studentID);

        Task<List<Transcripts>> GetStudentTranscripts(int studentID);

    }
}
