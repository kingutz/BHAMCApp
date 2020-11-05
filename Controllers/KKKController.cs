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
    public class KKKController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KKKController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KKK
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bhamc.ToListAsync());
        }

        // GET: KKK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bhamc = await _context.Bhamc
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bhamc == null)
            {
                return NotFound();
            }

            return View(bhamc);
        }

        // GET: KKK/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KKK/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionnaireNo,AntenatalCare,GestationalAge,DateMenstruation," +
            "ExpectedDate,HospitalName,PostNatalCare,InterviewerName,InterviewDate,Q1,Q2,Q3,OthersQ3,Q4,OthersQ4,Q5," +
            "Q6,Q7,Q8,Q9,Q10,OthersQ10,Q11,Q12_1,Q12_2,Q12_3,Q12_4,Q12_5,Q12_6,Q12_7,Q13,OthersQ13,Q14,Q15,OthersQ15," +
            "Q16,Q17,Q18,OthersQ18,Q19,Q20,OthersQ20,Q21,Q22_1,Q22_2,Q22_3,Q22_4,OthersQ22_4,Q23,Q24,Q25,Q26,Q27,Q28," +
            "Q29,Q30,Q31,Q32,Q32_1,Q33,Q34,Q35,OthersQ35,Q36,OthersQ36,Q37,Q38,Q39,Q40,Q41,Q42,Q43_1,Q43_2,Q43_3,Q43_4," +
            "Q43_5,Q43_6,Q44,Q45,Q46,Q47,Q48,Q49,Q50,Q51,Q52,Q53,Q54,Q54_1,Q54_2,Q54_3,Q54_4,Q55,Q56,Q56_1,Q56_2,Q56_3," +
            "Q56_4,Q56_5,OthersQ56,Q58_1,Q58_2,Q58_3,Q58_4,Q59_1,Q59_2,Q59_3,Q59_4,Q59_5,Q59_6,Q60,Q60_1,Q60_2," +
            "Q60_3,Q61_1,Q61_2,Q61_3,Q61_4,Q61_5,Q61_6,Q62,Q63,Q64_1,Q64_2,Q64_3,Q64_4,Q64_5,Q65,Q66,Q67,OthersQ67," +
            "Q68,Q68Yes,Q69,Q70_1,Q70_2,Q70_3,Q70_4,OthersQ70_4,Q71,Q71_1,Q72,Q73,Q74,Q75,Q76,Q77,Q78,Q79,Q80,Q81_1," +
            "Q81_2,Q81_3,Q81_4,Q81_5,Q81_6,Q82_1,Q82_2,Q82_3,Q82_4,Q82_5,Q83,Q84,Q85,Q86,Q87,Q88,Q89,Q90,OthersQ90," +
            "Q91,Q92,OthersQ92,Q93,Q94,Q95,Q96,Q97,Q98_1,Q98_2,Q98_3,Q98_4,Q98_5,Q98_6,Q99_1,Q99_2,Q99_3,Q99_4,Q99_5," +
            "Q100_1_1,QEA100,QEC100,QECO100,Q100_5_1,Q100_6_1,QECOO100,Q102,Q103,ID,CreatedByUser,CreatedDate," +
            "ModifiedByUser,ModifiedDate,Edited")] Bhamc bhamc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bhamc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bhamc);
        }

        // GET: KKK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bhamc = await _context.Bhamc.FindAsync(id);
            if (bhamc == null)
            {
                return NotFound();
            }
            return View(bhamc);
        }

        // POST: KKK/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionnaireNo,AntenatalCare,GestationalAge," +
            "DateMenstruation,ExpectedDate,HospitalName,PostNatalCare,InterviewerName,InterviewDate,Q1,Q2," +
            "Q3,OthersQ3,Q4,OthersQ4,Q5,Q6,Q7,Q8,Q9,Q10,OthersQ10,Q11,Q12_1,Q12_2,Q12_3,Q12_4,Q12_5,Q12_6," +
            "Q12_7,Q13,OthersQ13,Q14,Q15,OthersQ15,Q16,Q17,Q18,OthersQ18,Q19,Q20,OthersQ20,Q21,Q22_1,Q22_2," +
            "Q22_3,Q22_4,OthersQ22_4,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,Q31,Q32,Q32_1,Q33,Q34,Q35,OthersQ35,Q36," +
            "OthersQ36,Q37,Q38,Q39,Q40,Q41,Q42,Q43_1,Q43_2,Q43_3,Q43_4,Q43_5,Q43_6,Q44,Q45,Q46,Q47,Q48,Q49,Q50," +
            "Q51,Q52,Q53,Q54,Q54_1,Q54_2,Q54_3,Q54_4,Q55,Q56,Q56_1,Q56_2,Q56_3,Q56_4,Q56_5,OthersQ56,Q58_1,Q58_2," +
            "Q58_3,Q58_4,Q59_1,Q59_2,Q59_3,Q59_4,Q59_5,Q59_6,Q60,Q60_1,Q60_2,Q60_3,Q61_1,Q61_2,Q61_3,Q61_4,Q61_5," +
            "Q61_6,Q62,Q63,Q64_1,Q64_2,Q64_3,Q64_4,Q64_5,Q65,Q66,Q67,OthersQ67,Q68,Q68Yes,Q69,Q70_1,Q70_2,Q70_3,Q70_4," +
            "OthersQ70_4,Q71,Q71_1,Q72,Q73,Q74,Q75,Q76,Q77,Q78,Q79,Q80,Q81_1,Q81_2,Q81_3,Q81_4,Q81_5,Q81_6,Q82_1,Q82_2," +
            "Q82_3,Q82_4,Q82_5,Q83,Q84,Q85,Q86,Q87,Q88,Q89,Q90,OthersQ90,Q91,Q92,OthersQ92,Q93,Q94,Q95,Q96,Q97,Q98_1," +
            "Q98_2,Q98_3,Q98_4,Q98_5,Q98_6,Q99_1,Q99_2,Q99_3,Q99_4,Q99_5,Q100_1_1,QEA100,QEC100,QECO100,Q100_5_1," +
            "Q100_6_1,QECOO100,Q102,Q103,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] Bhamc bhamc)
        {
            if (id != bhamc.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bhamc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BhamcExists(bhamc.ID))
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
            return View(bhamc);
        }

        // GET: KKK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bhamc = await _context.Bhamc
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bhamc == null)
            {
                return NotFound();
            }

            return View(bhamc);
        }

        // POST: KKK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bhamc = await _context.Bhamc.FindAsync(id);
            _context.Bhamc.Remove(bhamc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BhamcExists(int id)
        {
            return _context.Bhamc.Any(e => e.ID == id);
        }
    }
}
