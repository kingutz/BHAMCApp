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
    public class F28_44MAMA28Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public F28_44MAMA28Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: F28_44MAMA28
        public async Task<IActionResult> Index()
        {
            return View(await _context.F28_44MAMA.ToListAsync());
        }

        // GET: F28_44MAMA28/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f28_44MAMA = await _context.F28_44MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f28_44MAMA == null)
            {
                return NotFound();
            }

            return View(f28_44MAMA);
        }

        // GET: F28_44MAMA28/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F28_44MAMA28/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Date,DateKuzaliwa,UmriMama,Q1,Q2,Q3,Q3_1,Q4,Q5,Q5_1,Q6,Q7," +
            "Q7_1,Q7_2,Q8,Q9,Q10,Q10_1,Q11,Q12,Q13,Q13_1,Q13_2,Q13_3,Q14_1,Q14_2,Q14_3,Q14_4,Q14_5,Q14_6,Q15," +
            "Q15_1,Q16,Q16_1,Q16_2,Q17,Q18,Q19_1,Q19_2,Q19_3,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,ProblemsDiagnosis," +
            "ManagementFT,DateVisit32,ID,CreatedByUser,CreatedDate,ModifiedByUser," +
            "ModifiedDate,Edited")] F28_44MAMA f28_44MAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f28_44MAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f28_44MAMA);
        }

        // GET: F28_44MAMA28/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f28_44MAMA = await _context.F28_44MAMA.FindAsync(id);
            if (f28_44MAMA == null)
            {
                return NotFound();
            }
            return View(f28_44MAMA);
        }

        // POST: F28_44MAMA28/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Date,DateKuzaliwa,UmriMama,Q1,Q2,Q3,Q3_1,Q4,Q5,Q5_1," +
            "Q6,Q7,Q7_1,Q7_2,Q8,Q9,Q10,Q10_1,Q11,Q12,Q13,Q13_1,Q13_2,Q13_3,Q14_1,Q14_2,Q14_3,Q14_4,Q14_5,Q14_6,Q15," +
            "Q15_1,Q16,Q16_1,Q16_2,Q17,Q18,Q19_1,Q19_2,Q19_3,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,ProblemsDiagnosis," +
            "ManagementFT,DateVisit32,ID,CreatedByUser,CreatedDate,ModifiedByUser," +
            "ModifiedDate,Edited")] F28_44MAMA f28_44MAMA)
        {
            if (id != f28_44MAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f28_44MAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F28_44MAMAExists(f28_44MAMA.ID))
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
            return View(f28_44MAMA);
        }

        // GET: F28_44MAMA28/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f28_44MAMA = await _context.F28_44MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f28_44MAMA == null)
            {
                return NotFound();
            }

            return View(f28_44MAMA);
        }

        // POST: F28_44MAMA28/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f28_44MAMA = await _context.F28_44MAMA.FindAsync(id);
            _context.F28_44MAMA.Remove(f28_44MAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F28_44MAMAExists(int id)
        {
            return _context.F28_44MAMA.Any(e => e.ID == id);
        }
    }
}
