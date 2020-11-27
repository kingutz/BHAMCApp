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
    public class F48MTOTO48Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public F48MTOTO48Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: F48MTOTO48
        public async Task<IActionResult> Index()
        {
            return View(await _context.F48MTOTO.ToListAsync());
        }

        // GET: F48MTOTO48/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f48MTOTO = await _context.F48MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f48MTOTO == null)
            {
                return NotFound();
            }

            return View(f48MTOTO);
        }

        // GET: F48MTOTO48/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F48MTOTO48/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,M36,M40,M44,M48,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q4_1,Q5,Q5_1,Q5_2,Q6,Q7,Q8_1_a,Q8_1_b,Q8_1_c,Q8_1_d,Q8_1_e,Q8_1_f,Q8_2_a,Q8_2_b,Q8_2_c,Q8_2_d,Q8_3_a,Q8_3_b,Q8_3_c,Q8_3_d,Q8_3_e,Q8_3_f,Q8_3_g,Q8_3_h,Q8_3_i,Q18_4_a,Q8_4_b,Q8_4_c,Q8_4_d,Q8_5_a,Q8_5_b,Q8_5_c,Q8_5_d,Q8_5_e,Q8_5_f,Q8_5_g,Q8_5_h,Q8_5_i,Q9_1,Q9_2,Q9_3,Q9_4,Q9_5,Q10,Q10_1,Q11,Q12,Q12_1,Q13,Q14,Q15,Q16,Q16_a_1,Q16_a_2,Q16_a_3,Q16_a_4,Q16_a_5,Q16_b_1,Q16_b_2,Q16_b_3,Q16_b_4,Q16_b_5,Q16_c_1,Q16_c_2,Q16_c_3,Q16_c_4,Q16_c_5,Q17,Q17_1,Q18,Q18_1,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q16_a,Q17_a,ProblemsDsis,MedicationPres,DateVisit32,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F48MTOTO f48MTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f48MTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f48MTOTO);
        }

        // GET: F48MTOTO48/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f48MTOTO = await _context.F48MTOTO.FindAsync(id);
            if (f48MTOTO == null)
            {
                return NotFound();
            }
            return View(f48MTOTO);
        }

        // POST: F48MTOTO48/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,M36,M40,M44,M48,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q4_1,Q5,Q5_1,Q5_2,Q6,Q7,Q8_1_a,Q8_1_b,Q8_1_c,Q8_1_d,Q8_1_e,Q8_1_f,Q8_2_a,Q8_2_b,Q8_2_c,Q8_2_d,Q8_3_a,Q8_3_b,Q8_3_c,Q8_3_d,Q8_3_e,Q8_3_f,Q8_3_g,Q8_3_h,Q8_3_i,Q18_4_a,Q8_4_b,Q8_4_c,Q8_4_d,Q8_5_a,Q8_5_b,Q8_5_c,Q8_5_d,Q8_5_e,Q8_5_f,Q8_5_g,Q8_5_h,Q8_5_i,Q9_1,Q9_2,Q9_3,Q9_4,Q9_5,Q10,Q10_1,Q11,Q12,Q12_1,Q13,Q14,Q15,Q16,Q16_a_1,Q16_a_2,Q16_a_3,Q16_a_4,Q16_a_5,Q16_b_1,Q16_b_2,Q16_b_3,Q16_b_4,Q16_b_5,Q16_c_1,Q16_c_2,Q16_c_3,Q16_c_4,Q16_c_5,Q17,Q17_1,Q18,Q18_1,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q16_a,Q17_a,ProblemsDsis,MedicationPres,DateVisit32,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F48MTOTO f48MTOTO)
        {
            if (id != f48MTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f48MTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F48MTOTOExists(f48MTOTO.ID))
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
            return View(f48MTOTO);
        }

        // GET: F48MTOTO48/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f48MTOTO = await _context.F48MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f48MTOTO == null)
            {
                return NotFound();
            }

            return View(f48MTOTO);
        }

        // POST: F48MTOTO48/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f48MTOTO = await _context.F48MTOTO.FindAsync(id);
            _context.F48MTOTO.Remove(f48MTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F48MTOTOExists(int id)
        {
            return _context.F48MTOTO.Any(e => e.ID == id);
        }
    }
}
