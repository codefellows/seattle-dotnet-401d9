using System;
using Xunit;
using StudentEnrollmentDemoD9.Models;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentDemoD9.Data;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetStudentName()
        {
            Student student = new Student();
            student.FirstName = "Amanda";
            student.LastName = "Iverson";

            Assert.Equal("Amanda Iverson", student.FullName);
            Assert.Equal("Amanda", student.FirstName);
            Assert.Equal("Iverson", student.LastName);
        }

        [Fact]
        public void CanChangeStudentName()
        {

            Student student = new Student();
            student.FirstName = "Josie";
            student.FirstName = "Belle";

            Assert.Equal("Belle", student.FirstName);
        }

        [Fact]
        public void CanGetCoursePrice()
        {
            Course course = new Course()
            {
                CourseCode = "my-course-code",
                Price = 10m,
                Technology = Technology.Java
            };

            Assert.Equal(10m, course.Price);

        }


        [Fact]
        public async void SaveStudentInDb()
        {
            // Arrange

            DbContextOptions<SchoolDbContext> options = new DbContextOptionsBuilder<SchoolDbContext>()
                .UseInMemoryDatabase("SavingStudentInDb")
                .Options;

            // Act

            using (SchoolDbContext context = new SchoolDbContext(options))
            {
                Course course = new Course();
                course.CourseCode = "Amanda's Super Cool Course";
                course.Technology = Technology.DotNet;
                course.Price = 1000m;

                context.Courses.Add(course);
                await context.SaveChangesAsync();

                Course result = await context.Courses.FirstOrDefaultAsync(x => x.CourseCode == course.CourseCode);

                Assert.Equal(1000m, result.Price);
                
            }

            // Assert
        }
    }
}
