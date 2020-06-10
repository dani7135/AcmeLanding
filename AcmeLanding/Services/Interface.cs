using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeLanding.Services
{
    interface Interface
    {
    }
    public interface ISerialNumber
    {
        bool SerialNumberVali(int number);
    }
    public interface IAgeValidate
    {
         bool IsValid(int age);
      //  string FormatErrorMessage(string name);
    }
}

/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcmeLanding.Data;
using ClassLibrary;

namespace AcmeLanding.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly Data.Acme_CorporationContext _context;

        public SubmissionsController(Data.Acme_CorporationContext context)
        {
            _context = context;
        }

        // GET: Submissions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Submission_Model.ToListAsync());
        }

        // GET: Submissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission_Model = await _context.Submission_Model
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submission_Model == null)
            {
                return NotFound();
            }

            return View(submission_Model);
        }

        // GET: Submissions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Submissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Age,FirstName,LastName,Email,SerialNumber")] Submission_Model submission_Model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(submission_Model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(submission_Model);
        }

        // GET: Submissions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission_Model = await _context.Submission_Model.FindAsync(id);
            if (submission_Model == null)
            {
                return NotFound();
            }
            return View(submission_Model);
        }

        // POST: Submissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Age,FirstName,LastName,Email,SerialNumber")] Submission_Model submission_Model)
        {
            if (id != submission_Model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(submission_Model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Submission_ModelExists(submission_Model.Id))
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
            return View(submission_Model);
        }

        // GET: Submissions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission_Model = await _context.Submission_Model
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submission_Model == null)
            {
                return NotFound();
            }

            return View(submission_Model);
        }

        // POST: Submissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var submission_Model = await _context.Submission_Model.FindAsync(id);
            _context.Submission_Model.Remove(submission_Model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Submission_ModelExists(int id)
        {
            return _context.Submission_Model.Any(e => e.Id == id);
        }
    }
}
*/
