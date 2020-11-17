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
    public class FTMAMATATUController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FTMAMATATUController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FTMAMATATU
        public async Task<IActionResult> Index()
        {
            return View(await _context.FTMAMA.ToListAsync());
        }

        // GET: FTMAMATATU/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTMAMA = await _context.FTMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTMAMA == null)
            {
                return NotFound();
            }

            return View(fTMAMA);
        }

        // GET: FTMAMATATU/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FTMAMATATU/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q6_1,Q7,Q8,Q8_1,Q9,Q10,Q11,Q12,Q13,Q13_1,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,ProblemsDiagnosis,ManagementFT,DateVisit6,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTMAMA fTMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fTMAMA);
        }

        // GET: FTMAMATATU/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTMAMA = await _context.FTMAMA.FindAsync(id);
            if (fTMAMA == null)
            {
                return NotFound();
            }
            return View(fTMAMA);
        }

        // POST: FTMAMATATU/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q6_1,Q7,Q8,Q8_1,Q9,Q10,Q11,Q12,Q13,Q13_1,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,ProblemsDiagnosis,ManagementFT,DateVisit6,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTMAMA fTMAMA)
        {
            if (id != fTMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTMAMAExists(fTMAMA.ID))
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
            return View(fTMAMA);
        }

        // GET: FTMAMATATU/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTMAMA = await _context.FTMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTMAMA == null)
            {
                return NotFound();
            }

            return View(fTMAMA);
        }

        // POST: FTMAMATATU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTMAMA = await _context.FTMAMA.FindAsync(id);
            _context.FTMAMA.Remove(fTMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTMAMAExists(int id)
        {
            return _context.FTMAMA.Any(e => e.ID == id);
        }
    }
}
