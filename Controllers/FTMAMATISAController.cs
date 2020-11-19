using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BHAMCApp.Data;
using BHAMCApp.Models;

namespace BHAMCApp.Controllers
{
    public class FTMAMATISAController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FTMAMATISAController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FTMAMATISA
        public async Task<IActionResult> Index()
        {
            return View(await _context.FTISAMAMA.ToListAsync());
        }

        // GET: FTMAMATISA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMAMA = await _context.FTISAMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTISAMAMA == null)
            {
                return NotFound();
            }

            return View(fTISAMAMA);
        }

        // GET: FTMAMATISA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FTMAMATISA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q5,Q6,Q6_1,Q7,Q7_1,Q8,Q9,Q10,Q11,Q12,Q12_1,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,ProblemsDiagnosis,ManagementFT,DateVisit12,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTISAMAMA fTISAMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTISAMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fTISAMAMA);
        }

        // GET: FTMAMATISA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMAMA = await _context.FTISAMAMA.FindAsync(id);
            if (fTISAMAMA == null)
            {
                return NotFound();
            }
            return View(fTISAMAMA);
        }

        // POST: FTMAMATISA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q5,Q6,Q6_1,Q7,Q7_1,Q8,Q9,Q10,Q11,Q12,Q12_1,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,ProblemsDiagnosis,ManagementFT,DateVisit12,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTISAMAMA fTISAMAMA)
        {
            if (id != fTISAMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTISAMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTISAMAMAExists(fTISAMAMA.ID))
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
            return View(fTISAMAMA);
        }

        // GET: FTMAMATISA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMAMA = await _context.FTISAMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTISAMAMA == null)
            {
                return NotFound();
            }

            return View(fTISAMAMA);
        }

        // POST: FTMAMATISA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTISAMAMA = await _context.FTISAMAMA.FindAsync(id);
            _context.FTISAMAMA.Remove(fTISAMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTISAMAMAExists(int id)
        {
            return _context.FTISAMAMA.Any(e => e.ID == id);
        }
    }
}
