using Microsoft.EntityFrameworkCore;
using StudentEnrollmentDemoD9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentDemoD9.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set composite keys
            modelBuilder.Entity<Enrollments>().HasKey(enrollment =>
            new { enrollment.StudentId, enrollment.CourseId });

            // Seeding data
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    CourseCode = "Seattle-Dotnet-401d9",
                    Price = 100m,
                    Technology = Technology.DotNet
                },
                new Course
                {
                    ID = 2,
                    CourseCode = "Java",
                    Price = 110m,
                    Technology = Technology.Java
                },
                new Course
                {
                    ID = 3,
                    CourseCode = "Vim",
                    Price = 150m,
                    Technology = Technology.Python
                }
                );

            // second table like so:
            //modelBuilder.Entity<Student>().HasData();

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Transcripts> Transcripts { get; set; }



    }
}
