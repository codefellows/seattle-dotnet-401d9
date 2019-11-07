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
    public class StudentsController : Controller
    {
        private readonly IStudentManager _student;

        public StudentsController(IStudentManager student)
        {
            _student = student;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            // return all the students and the number of courses they are enrolled in. 
            return View(await _student.GetStudents());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            Student student = await _student.GetStudentByIdAsync(id);

            var studentEnrollments = _student.GetStudentEnrollments(id);

            StudentEnrollmentsVM sevm = new StudentEnrollmentsVM();
            sevm.Student = student;
            sevm.Enrollments = studentEnrollments;

            if (student == null)
            {
                return NotFound();
            }

            return View(sevm);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Birthdate")] Student student)
        {
            if (ModelState.IsValid)
            {
                await _student.CreateStudentAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            Student student = await _student.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Birthdate")] Student student)
        {
            if (id != student.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _student.UpdateStudentAsync(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await StudentExists(student.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var student = await _student.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _student.DeleteStudentAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> StudentExists(int id)
        {
            Student student = await _student.GetStudentByIdAsync(id);
            if (student == null)
            {
                return false;
            }

            return true;
        }
    }
}
