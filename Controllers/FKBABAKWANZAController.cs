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
    public class FKBABAKWANZAController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FKBABAKWANZAController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FKBABAs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FKBABA.ToListAsync());
        }

        // GET: FKBABAs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKBABA = await _context.FKBABA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKBABA == null)
            {
                return NotFound();
            }

            return View(fKBABA);
        }

        // GET: FKBABAs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FKBABAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10_1,Q10_2,Q10_3,Q10_4,ProblemsDiagnosis,ManagementFT,DateFollowup,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKBABA fKBABA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fKBABA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fKBABA);
        }

        // GET: FKBABAs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKBABA = await _context.FKBABA.FindAsync(id);
            if (fKBABA == null)
            {
                return NotFound();
            }
            return View(fKBABA);
        }

        // POST: FKBABAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10_1,Q10_2,Q10_3,Q10_4,ProblemsDiagnosis,ManagementFT,DateFollowup,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKBABA fKBABA)
        {
            if (id != fKBABA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fKBABA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FKBABAExists(fKBABA.ID))
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
            return View(fKBABA);
        }

        // GET: FKBABAs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKBABA = await _context.FKBABA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKBABA == null)
            {
                return NotFound();
            }

            return View(fKBABA);
        }

        // POST: FKBABAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fKBABA = await _context.FKBABA.FindAsync(id);
            _context.FKBABA.Remove(fKBABA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FKBABAExists(int id)
        {
            return _context.FKBABA.Any(e => e.ID == id);
        }
    }
}
