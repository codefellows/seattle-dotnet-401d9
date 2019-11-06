using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentDemoD9.Data;
using StudentEnrollmentDemoD9.Models;
using StudentEnrollmentDemoD9.Models.Interfaces;
using StudentEnrollmentDemoD9.Models.ViewModels;

namespace StudentEnrollmentDemoD9.Controllers
{
    public class EnrollmentsController : Controller
    {
        private readonly ICourseManager _courses;
        private readonly IStudentManager _students;

        public EnrollmentsController(ICourseManager courses, IStudentManager students)
        {
            _courses = courses;
            _students = students;
        }

        // Enrollments doesn't need an index Action because there is no need to have a full landing page of just course and student associations. 


        // GET: Enrollments/Details/5
        public async Task<IActionResult> CourseDetails(int id)
        {
            var enrollments = _courses.GetEnrollmentsByCourse(id);


            if (enrollments == null)
            {
                return NotFound();
            }


            StudentCourseVM ecvm = new StudentCourseVM();

            ecvm.Course = await _courses.GetCourseById(id);
            ecvm.Enrollments = enrollments;

            return View(ecvm);
        }

        //// GET: Enrollments/Create
        public async Task<IActionResult> Create()
        {
            ViewData["CourseId"] = new SelectList(await _courses.GetCourses(), "ID", "CourseCode");
            ViewData["StudentId"] = new SelectList(await _students.GetStudents(), "ID", "FullName");
            return View();
        }

        //// POST: Enrollments/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,StudentId")] Enrollments enrollments)
        {
            if (ModelState.IsValid)
            {
                await _students.EnrollInCourse(enrollments.StudentId, enrollments.CourseId);
                return RedirectToAction(nameof(Index), "Students");
            }
            ViewData["CourseId"] = new SelectList(await _courses.GetCourses(), "ID", "CourseCode", enrollments.CourseId);
            ViewData["StudentId"] = new SelectList(await _students.GetStudents(), "ID", "FullName", enrollments.StudentId);
            return View(enrollments);
        }

        // Enrollments doesn't need to be edited. Only removed. 
        // Review the students/details.cshtml view page to see how i am unenrolling a student from a course


        //// GET: Enrollments/Delete/5
        
        public async Task<IActionResult> Delete(int id, int studentID)
        {
            if (id <= 0 || studentID <= 0)
            {
                return NotFound();
            }

            await _students.UnEnrollInCourse(studentID, id);

            return RedirectToAction(nameof(Index), "Students", studentID);
        }
    }
}
