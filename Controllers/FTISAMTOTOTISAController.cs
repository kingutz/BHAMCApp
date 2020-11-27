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
    public class FTISAMTOTOTISAController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FTISAMTOTOTISAController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FTISAMTOTOTISA
        public async Task<IActionResult> Index()
        {
            return View(await _context.FTISAMTOTO.ToListAsync());
        }

        // GET: FTISAMTOTOTISA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMTOTO = await _context.FTISAMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTISAMTOTO == null)
            {
                return NotFound();
            }

            return View(fTISAMTOTO);
        }

        // GET: FTISAMTOTOTISA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FTISAMTOTOTISA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q1_1_a,Q1_1_b,Q1_1_c,Q1_1_e,Q2_2_a,Q2_2_b,Q2_2_c,Q2_2_e,Q3_3_a,Q3_3_b,Q3_3_c,Q3_3_e,Q4_4_a,Q4_4_b,Q4_4_c,Q4_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q6_5_a,Q6_5_b,Q6_5_c,Q6_5_e,Q7_5_a,Q7_5_b,Q7_5_c,Q7_5_e,Q8_5_a,Q8_5_b,Q8_5_c,Q8_5_e,Q4_1,Q4_1_a,Q4_2,Q4_2_a,Q4_3,Q4_3_a,Q4_4,Q4_4_aa,Q4_5,Q4_5_aa,Q4_6,Q4_6_a,Q4_7,Q4_7_a,Q4_8,Q4_8_a,Q5,Q5_1,Q6_a_1,Q6_a_2,Q6_a_3,Q6_a_4,Q6_a_5,Q6_b_1,Q6_b_2,Q6_b_3,Q6_b_4,Q6_b_5,Q6_c_1,Q6_c_2,Q6_c_3,Q6_c_4,Q6_c_5,Q6_d_1,Q6_d_2,Q6_d_3,Q6_d_4,Q6_d_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTISAMTOTO fTISAMTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTISAMTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fTISAMTOTO);
        }

        // GET: FTISAMTOTOTISA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMTOTO = await _context.FTISAMTOTO.FindAsync(id);
            if (fTISAMTOTO == null)
            {
                return NotFound();
            }
            return View(fTISAMTOTO);
        }

        // POST: FTISAMTOTOTISA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q1_1_a,Q1_1_b,Q1_1_c,Q1_1_e,Q2_2_a,Q2_2_b,Q2_2_c,Q2_2_e,Q3_3_a,Q3_3_b,Q3_3_c,Q3_3_e,Q4_4_a,Q4_4_b,Q4_4_c,Q4_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q6_5_a,Q6_5_b,Q6_5_c,Q6_5_e,Q7_5_a,Q7_5_b,Q7_5_c,Q7_5_e,Q8_5_a,Q8_5_b,Q8_5_c,Q8_5_e,Q4_1,Q4_1_a,Q4_2,Q4_2_a,Q4_3,Q4_3_a,Q4_4,Q4_4_aa,Q4_5,Q4_5_aa,Q4_6,Q4_6_a,Q4_7,Q4_7_a,Q4_8,Q4_8_a,Q5,Q5_1,Q6_a_1,Q6_a_2,Q6_a_3,Q6_a_4,Q6_a_5,Q6_b_1,Q6_b_2,Q6_b_3,Q6_b_4,Q6_b_5,Q6_c_1,Q6_c_2,Q6_c_3,Q6_c_4,Q6_c_5,Q6_d_1,Q6_d_2,Q6_d_3,Q6_d_4,Q6_d_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTISAMTOTO fTISAMTOTO)
        {
            if (id != fTISAMTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTISAMTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTISAMTOTOExists(fTISAMTOTO.ID))
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
            return View(fTISAMTOTO);
        }

        // GET: FTISAMTOTOTISA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMTOTO = await _context.FTISAMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTISAMTOTO == null)
            {
                return NotFound();
            }

            return View(fTISAMTOTO);
        }

        // POST: FTISAMTOTOTISA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTISAMTOTO = await _context.FTISAMTOTO.FindAsync(id);
            _context.FTISAMTOTO.Remove(fTISAMTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTISAMTOTOExists(int id)
        {
            return _context.FTISAMTOTO.Any(e => e.ID == id);
        }
    }
}
