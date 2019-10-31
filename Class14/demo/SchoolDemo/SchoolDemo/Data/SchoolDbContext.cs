using SchoolDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set the composite key bindings using the fluent API
            modelBuilder.Entity<Enrollments>().HasKey(enrollment => new { enrollment.CourseID, enrollment.StudentID });

            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                ID = 1,
                FirstName = "Jack",
                LastName = "Shepard",
                Birthdate = new DateTime(1988, 3, 23)
            },
            new Student
            {
                ID = 2,
                FirstName = "Kate",
                LastName = "Austin",
                Birthdate = new DateTime(1975, 7, 3)
            },
            new Student
            {
                ID = 3,
                FirstName = "Hugo",
                LastName = "Reyes",
                Birthdate = new DateTime(1990, 10, 11)
            },
            new Student
            {
                ID = 4,
                FirstName = "James",
                LastName = "Ford",
                Birthdate = new DateTime(1996, 2, 26)
            }

            );

            modelBuilder.Entity<Course>().HasData(
            new Course
            {
                ID = 1,
                CourseCode = "401-python",
                Price = 500m,
                Technology = Technology.Python
            },
            new Course
            {
                ID = 2,
                CourseCode = "401-dotnet",
                Price = 600m,
                Technology = Technology.CSharp
            },
            new Course
            {
                ID = 3,
                CourseCode = "401-java",
                Price = 600m,
                Technology = Technology.Java
            },
            new Course
            {
                ID = 4,
                CourseCode = "201-Fundamentals",
                Price = 600m,
                Technology = Technology.JavaScript
            }
            );

        }

        // Create Tables
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Transcripts { get; set; }
        public DbSet<SchoolDemo.Models.Transcripts> Transcripts_1 { get; set; }
    }
}
