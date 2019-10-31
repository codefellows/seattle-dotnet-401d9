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
            modelBuilder.Entity<Enrollments>().HasKey(enrollment =>
            new { enrollment.StudentId, enrollment.CourseId });
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Transcripts> Transcripts { get; set; }



    }
}
