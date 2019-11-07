using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentDemoD9.Data;
using StudentEnrollmentDemoD9.Models;

namespace StudentEnrollmentDemoD9.Controllers
{
    public class TranscriptsController : Controller
    {
        private readonly SchoolDbContext _context;

        public TranscriptsController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Transcripts
        public async Task<IActionResult> Index()
        {
            var schoolDbContext = _context.Transcripts.Include(t => t.Course).Include(t => t.Student);
            return View(await schoolDbContext.ToListAsync());
        }

        // GET: Transcripts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts
                .Include(t => t.Course)
                .Include(t => t.Student)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (transcripts == null)
            {
                return NotFound();
            }

            return View(transcripts);
        }

        // GET: Transcripts/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "ID", "CourseCode");
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "FullName");
            return View();
        }

        // POST: Transcripts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentId,CourseId,Grade,Passed")] Transcripts transcripts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transcripts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "ID", "ID", transcripts.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "FirstName", transcripts.StudentId);
            return View(transcripts);
        }

        // GET: Transcripts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts.FindAsync(id);
            if (transcripts == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "ID", "ID", transcripts.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "FirstName", transcripts.StudentId);
            return View(transcripts);
        }

        // POST: Transcripts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentId,CourseId,Grade,Passed")] Transcripts transcripts)
        {
            if (id != transcripts.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transcripts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TranscriptsExists(transcripts.ID))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "ID", "ID", transcripts.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "FirstName", transcripts.StudentId);
            return View(transcripts);
        }

        // GET: Transcripts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts
                .Include(t => t.Course)
                .Include(t => t.Student)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (transcripts == null)
            {
                return NotFound();
            }

            return View(transcripts);
        }

        // POST: Transcripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transcripts = await _context.Transcripts.FindAsync(id);
            _context.Transcripts.Remove(transcripts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranscriptsExists(int id)
        {
            return _context.Transcripts.Any(e => e.ID == id);
        }
    }
}
