using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Models.Interfaces
{
    public interface IStudentManager
    {
        // Create a student
        Task CreateStudentAsync(Student student);

        // get a ind. student
        Task<Student> GetStudentByIdAsync(int id);

        // get ALL students

        Task<IEnumerable<Student>> GetStudents();

        // update a student
        Task UpdateStudentAsync(Student student);

        // delete a student
        Task DeleteStudentAsync(int id);
        IEnumerable<Enrollments> GetStudentEnrollments(int studentId);
        Task EnrollInCourse(int studentID, int courseId);

        Task UnEnrollInCourse(int studentID, int coursed);


    }
}
