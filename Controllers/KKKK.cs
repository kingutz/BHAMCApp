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
    public class KKKK : Controller
    {
        private readonly ApplicationDbContext _context;

        public KKKK(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KKKK
        public async Task<IActionResult> Index()
        {
            return View(await _context.F48MAMA.ToListAsync());
        }

        // GET: KKKK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f48MAMA = await _context.F48MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f48MAMA == null)
            {
                return NotFound();
            }

            return View(f48MAMA);
        }

        // GET: KKKK/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KKKK/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Date,MiakaMoshi,DateKuzaliwa,UmriMama,Q1,Q2,Q2_1," +
            "Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q8_1,Q8_2,Q9,Q9_1,Q9_2,Q9_3,Q10,Q11,Q11_1,Q12,Q13,Q13_1,Q13_2,Q13_3,Q14" +
            ",Q15,Q16,Q16_1,Q17,Q17_1,Q18,Q19,Q19_1,Q19_2,Q20,Q20_1,Q20_2,Q20_2_1,Q20_3,Q20_3_1,Q21,Q22,Q22_1,Q23" +
            ",Q24,Q25,Q25_1,Q26,Q27,Q27_1,Q27_2,Q27_3,Q28,Q28_1,Q29,Q30,Q31,Q31_1,Q31_2,Q31_3,Q31_4,Q31_5,Q32," +
            "Q32_1,Q32_2,Q32_3,Q32_4,Q32_5,Q32_6,Q33,Q33_1,Q34,Q35_1,Q35_2,Q35_3,Q36,Q37,Q38,Q39,Q40,Q41,Q42," +
            "Q43,Q44,ProblemsDiagnosis,ManagementFT,DateVisit52,ID,CreatedByUser,CreatedDate,ModifiedByUser," +
            "ModifiedDate,Edited")] F48MAMA f48MAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f48MAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f48MAMA);
        }

        // GET: KKKK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f48MAMA = await _context.F48MAMA.FindAsync(id);
            if (f48MAMA == null)
            {
                return NotFound();
            }
            return View(f48MAMA);
        }

        // POST: KKKK/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Date,MiakaMoshi,DateKuzaliwa,UmriMama,Q1,Q2,Q2_1," +
            "Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q8_1,Q8_2,Q9,Q9_1,Q9_2,Q9_3,Q10,Q11,Q11_1,Q12,Q13,Q13_1,Q13_2,Q13_3,Q14,Q15," +
            "Q16,Q16_1,Q17,Q17_1,Q18,Q19,Q19_1,Q19_2,Q20,Q20_1,Q20_2,Q20_2_1,Q20_3,Q20_3_1,Q21,Q22,Q22_1,Q23,Q24,Q25," +
            "Q25_1,Q26,Q27,Q27_1,Q27_2,Q27_3,Q28,Q28_1,Q29,Q30,Q31,Q31_1,Q31_2,Q31_3,Q31_4,Q31_5,Q32,Q32_1,Q32_2,Q32_3," +
            "Q32_4,Q32_5,Q32_6,Q33,Q33_1,Q34,Q35_1,Q35_2,Q35_3,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44,ProblemsDiagnosis," +
            "ManagementFT,DateVisit52,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F48MAMA f48MAMA)
        {
            if (id != f48MAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f48MAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F48MAMAExists(f48MAMA.ID))
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
            return View(f48MAMA);
        }

        // GET: KKKK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f48MAMA = await _context.F48MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f48MAMA == null)
            {
                return NotFound();
            }

            return View(f48MAMA);
        }

        // POST: KKKK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f48MAMA = await _context.F48MAMA.FindAsync(id);
            _context.F48MAMA.Remove(f48MAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F48MAMAExists(int id)
        {
            return _context.F48MAMA.Any(e => e.ID == id);
        }
    }
}
