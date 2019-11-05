using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models;

namespace SchoolDemo.Controllers
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
            var schoolDbContext = _context.Transcripts_1.Include(t => t.Course).Include(t => t.Student);
            return View(await schoolDbContext.ToListAsync());
        }

        // GET: Transcripts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts_1
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "CourseCode");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "FullName");
            return View();
        }

        // POST: Transcripts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentID,CourseID,Grade,Passed")] Transcripts transcripts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transcripts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "ID", transcripts.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "ID", transcripts.StudentID);
            return View(transcripts);
        }

        // GET: Transcripts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts_1.FindAsync(id);
            if (transcripts == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "ID", transcripts.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "ID", transcripts.StudentID);
            return View(transcripts);
        }

        // POST: Transcripts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentID,CourseID,Grade,Passed")] Transcripts transcripts)
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "ID", transcripts.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "ID", transcripts.StudentID);
            return View(transcripts);
        }

        // GET: Transcripts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts_1
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
            var transcripts = await _context.Transcripts_1.FindAsync(id);
            _context.Transcripts_1.Remove(transcripts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranscriptsExists(int id)
        {
            return _context.Transcripts_1.Any(e => e.ID == id);
        }
    }
}
