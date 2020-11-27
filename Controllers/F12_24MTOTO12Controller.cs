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
    public class F12_24MTOTO12Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public F12_24MTOTO12Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: F12_24MTOTO12
        public async Task<IActionResult> Index()
        {
            return View(await _context.F12_24MTOTO.ToListAsync());
        }

        // GET: F12_24MTOTO12/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f12_24MTOTO = await _context.F12_24MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f12_24MTOTO == null)
            {
                return NotFound();
            }

            return View(f12_24MTOTO);
        }

        // GET: F12_24MTOTO12/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F12_24MTOTO12/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q9_1_a,Q9_1_b,Q9_1_c,Q9_1_d,Q9_1_e,Q9_1_f,Q9_2_a,Q9_2_b,Q9_2_c,Q9_2_d,Q9_2_e,Q9_2_f,Q9_3_a,Q9_3_b,Q9_3_c,Q9_3_d,Q9_3_e,Q9_3_f,Q9_4_a,Q9_4_b,Q9_4_c,Q9_4_d,Q9_4_e,Q9_4_f,Q9_5_a,Q9_5_b,Q9_5_c,Q9_5_d,Q9_5_e,Q9_5_f,Q9_6_a,Q9_6_b,Q9_6_c,Q9_6_d,Q9_6_e,Q9_6_f,Q9_7_a,Q9_7_b,Q9_7_c,Q9_7_d,Q9_7_e,Q9_7_f,Q9_8_a,Q9_8_b,Q9_8_c,Q9_8_d,Q9_8_e,Q9_8_f,Q9_9_a,Q9_9_b,Q9_9_c,Q9_9_d,Q9_9_e,Q9_9_f,Q9_10_a,Q9_10_b,Q9_10_c,Q9_10_d,Q9_10_e,Q9_10_f,Q9_11_a,Q9_11_b,Q9_11_c,Q9_11_d,Q9_11_e,Q9_11_f,Q9_12_a,Q9_12_b,Q9_12_c,Q9_12_d,Q9_12_e,Q9_12_f,Q9_13_a,Q9_13_b,Q9_13_c,Q9_13_d,Q9_13_e,Q9_13_f,Q10,Q10_1,Q11,Q11_1,Q12,Q12_1,Q13_1,Q13_2,Q13_3,Q13_4,Q13_5,Q13_6,Q13_7,Q13_8,Q14_1,Q14_2,Q14_3,Q14_4,Q14_5,Q14_6,Q14_7,Q14_8,Q14_9,Q14_10,Q15_a_1,Q15_a_2,Q15_a_3,Q15_a_4,Q15_a_5,Q15_b_1,Q15_b_2,Q15_b_3,Q15_b_4,Q15_b_5,Q15_c_1,Q15_c_2,Q15_c_3,Q15_c_4,Q15_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,DateNext,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F12_24MTOTO f12_24MTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f12_24MTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f12_24MTOTO);
        }

        // GET: F12_24MTOTO12/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f12_24MTOTO = await _context.F12_24MTOTO.FindAsync(id);
            if (f12_24MTOTO == null)
            {
                return NotFound();
            }
            return View(f12_24MTOTO);
        }

        // POST: F12_24MTOTO12/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q9_1_a,Q9_1_b,Q9_1_c,Q9_1_d,Q9_1_e,Q9_1_f,Q9_2_a,Q9_2_b,Q9_2_c,Q9_2_d,Q9_2_e,Q9_2_f,Q9_3_a,Q9_3_b,Q9_3_c,Q9_3_d,Q9_3_e,Q9_3_f,Q9_4_a,Q9_4_b,Q9_4_c,Q9_4_d,Q9_4_e,Q9_4_f,Q9_5_a,Q9_5_b,Q9_5_c,Q9_5_d,Q9_5_e,Q9_5_f,Q9_6_a,Q9_6_b,Q9_6_c,Q9_6_d,Q9_6_e,Q9_6_f,Q9_7_a,Q9_7_b,Q9_7_c,Q9_7_d,Q9_7_e,Q9_7_f,Q9_8_a,Q9_8_b,Q9_8_c,Q9_8_d,Q9_8_e,Q9_8_f,Q9_9_a,Q9_9_b,Q9_9_c,Q9_9_d,Q9_9_e,Q9_9_f,Q9_10_a,Q9_10_b,Q9_10_c,Q9_10_d,Q9_10_e,Q9_10_f,Q9_11_a,Q9_11_b,Q9_11_c,Q9_11_d,Q9_11_e,Q9_11_f,Q9_12_a,Q9_12_b,Q9_12_c,Q9_12_d,Q9_12_e,Q9_12_f,Q9_13_a,Q9_13_b,Q9_13_c,Q9_13_d,Q9_13_e,Q9_13_f,Q10,Q10_1,Q11,Q11_1,Q12,Q12_1,Q13_1,Q13_2,Q13_3,Q13_4,Q13_5,Q13_6,Q13_7,Q13_8,Q14_1,Q14_2,Q14_3,Q14_4,Q14_5,Q14_6,Q14_7,Q14_8,Q14_9,Q14_10,Q15_a_1,Q15_a_2,Q15_a_3,Q15_a_4,Q15_a_5,Q15_b_1,Q15_b_2,Q15_b_3,Q15_b_4,Q15_b_5,Q15_c_1,Q15_c_2,Q15_c_3,Q15_c_4,Q15_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,DateNext,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F12_24MTOTO f12_24MTOTO)
        {
            if (id != f12_24MTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f12_24MTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F12_24MTOTOExists(f12_24MTOTO.ID))
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
            return View(f12_24MTOTO);
        }

        // GET: F12_24MTOTO12/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f12_24MTOTO = await _context.F12_24MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f12_24MTOTO == null)
            {
                return NotFound();
            }

            return View(f12_24MTOTO);
        }

        // POST: F12_24MTOTO12/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f12_24MTOTO = await _context.F12_24MTOTO.FindAsync(id);
            _context.F12_24MTOTO.Remove(f12_24MTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F12_24MTOTOExists(int id)
        {
            return _context.F12_24MTOTO.Any(e => e.ID == id);
        }
    }
}
