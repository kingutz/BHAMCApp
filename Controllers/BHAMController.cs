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
    public class BHAMController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BHAMController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BHAM
        public async Task<IActionResult> Index()
        {
            return View(await _context.BHAMCDATA.ToListAsync());
        }

        // GET: BHAM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bHAMCDATA = await _context.BHAMCDATA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bHAMCDATA == null)
            {
                return NotFound();
            }

            return View(bHAMCDATA);
        }

        // GET: BHAM/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BHAM/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Rid,Clinic,Gravida,Parity,Matatizo,Kama_ndiyo,Umri_wa_mimba,Tarehekuzalia,Miaka_Moshi,Jina_anayedodosa,Tarehe,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q7_1,Q8,Q9,Q10,Q10_1,Q11,Q11_1,Q12,Q13,Q14,Q15,Q16_1,Q16_2,Q16_3,Q16_4,Q16_5,Q16_6,Q17,Q18,Q19,Q20,Q21,Q21_1,Q22,Q23,Q23_1,Q23_2,Q24,Q24_1,Q25,Q26_1,Q26_1_1,Q26_2,Q26_2_1,Q26_3,Q26_3_1,Q26_4,Q26_4_1,Q27,Q27_1,Q28a,Q28b,Q28c,Q29,Q30,Q31,Q31_1,Q32,Q32_1,Q33,Q34,Q34b,Q35_0,Q35_1,Q35_2,Q35_3,Q35_4,Q35_5,Q35_6,Q35_7,Q35_8,Q35_9,Q35_10,Q35_11,Q36_1,Q36_2,Q36_3,Q36_4,Q36b_0,Q36b_1,Q36b_2,Q36b_3,Q36b_4,Q36b_5,Q36b_6,Q36b_7,Q36b_8,Q37_0,Q37_1,Q37_2,Q37_3,Q37_4,Q37_5,Q37_6,Q38_0,Q38_1,Q38_2,Q38_3,Q38_4,Q38_5,Q39,Q40_1,Q40_2,Q40_3,Q40_4,Q40_5,Q41,Q41b,Q42,Q43,Q44,Q44b,Q45,Q46_1,Q46_2,Q46_3,Q46_4,Q46_5,Q46_6,Q47_1,Q47_2,Q47_3,Q47_4,Q47_5,Q47_6,Q48_1,Q48_2,Q48_3,Q49,Q49b,Q50,Q50b,Q51,Q51_1,Q51b,Q52,Q52b,Q53,Q54,Q55,Q55_1,Q56,Q56_1,Q57,Q58,Q59,Q60,Q61,Q62,Q62_1,Q63,Q63_1,Q64,Q65,Q66,Q67,Q68,Q64_68,Q64_68_1,Q69,Q70,Q71,Q72,Q73,Q74,Q75,Q76,Q77,Q78,Q79,Q80,Q81,Q76_81,Q81b,Q81b_1,Q81b_2,Q82c,Q82d,Q82e,Q82f,Q82h,Q83,Q84,Q85,Q86,Q87,Q88,Q89,Q89_1,Q90,Q90_1,Q91,Q92_1,Q92_2,Q92_3,Q92_4,Q92_5,Q92_6,Q92_7,Q92_8,Q93,Q94_1,Q94_2,Q94_3,Q94_4,Q94_5,Q94_6,Q94_7,Q95,Q96,Q97_1,Q97_2,Q97_3,Q97_4,Q97_6,Q97_7,Q98,Q99,Q99_1,Q100_1,Q100_2,Q101,Q102,Q103,Q103_1,Q104,Q104_1,Q105,Q105_1,Q106,Q107,Q107b,Q108,Q109_0,Q109_1,Q109_2,Q109_3,Q109_4,Q109_5,Q109_6,Q110,Q111,Q112,Q113,Q113b,Q114_1,Q114_2,Q114_3,Q114_4,Q114_5,Q115_1,Q115_2,Q115_3,Q115_4,Q115_5,Q115_6,Q115_7,Q116,Q117,Q118,Q118_1,Q119,Q120,Q120b_1,Q120b_2,Q120b_3,Q120b_4,Q120b_5,Q120b_6,Q120c,PE1,PE2,PE3,PE4,PE5,PE6,PE7,PE8,PE9_1,PE9_2,PE9_3,PE10_1,PE10_2,PE10_3,PE11_1,PE11_2,PE11_3,PE12_1,PE12_2,PE12_3,PE12_4,PE13_1,PE13_2,PE13_3,PE13_4,PE13_5,PE14_1,PE14_2,PE14_3,PE14_4,PE14_5,PE15_0,PE15_1,PE15_2,PE15_3,PE15_4,PE16_1,PE16_2,PE16_3,PE17_0,PE17_1,PE17_2,PE17_3,PE17_4,PE18_1,PE18_2,PE18_3,PE18_4,PE18_5,PE18_6,PE19_1,PE19_2,PE19_3,PE19_4,PE20_1,PE20_2,PE21_1,PE21_2,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] BHAMCDATA bHAMCDATA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bHAMCDATA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bHAMCDATA);
        }

        // GET: BHAM/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bHAMCDATA = await _context.BHAMCDATA.FindAsync(id);
            if (bHAMCDATA == null)
            {
                return NotFound();
            }
            return View(bHAMCDATA);
        }

        // POST: BHAM/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Rid,Clinic,Gravida,Parity,Matatizo,Kama_ndiyo,Umri_wa_mimba,Tarehekuzalia,Miaka_Moshi,Jina_anayedodosa,Tarehe,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q7_1,Q8,Q9,Q10,Q10_1,Q11,Q11_1,Q12,Q13,Q14,Q15,Q16_1,Q16_2,Q16_3,Q16_4,Q16_5,Q16_6,Q17,Q18,Q19,Q20,Q21,Q21_1,Q22,Q23,Q23_1,Q23_2,Q24,Q24_1,Q25,Q26_1,Q26_1_1,Q26_2,Q26_2_1,Q26_3,Q26_3_1,Q26_4,Q26_4_1,Q27,Q27_1,Q28a,Q28b,Q28c,Q29,Q30,Q31,Q31_1,Q32,Q32_1,Q33,Q34,Q34b,Q35_0,Q35_1,Q35_2,Q35_3,Q35_4,Q35_5,Q35_6,Q35_7,Q35_8,Q35_9,Q35_10,Q35_11,Q36_1,Q36_2,Q36_3,Q36_4,Q36b_0,Q36b_1,Q36b_2,Q36b_3,Q36b_4,Q36b_5,Q36b_6,Q36b_7,Q36b_8,Q37_0,Q37_1,Q37_2,Q37_3,Q37_4,Q37_5,Q37_6,Q38_0,Q38_1,Q38_2,Q38_3,Q38_4,Q38_5,Q39,Q40_1,Q40_2,Q40_3,Q40_4,Q40_5,Q41,Q41b,Q42,Q43,Q44,Q44b,Q45,Q46_1,Q46_2,Q46_3,Q46_4,Q46_5,Q46_6,Q47_1,Q47_2,Q47_3,Q47_4,Q47_5,Q47_6,Q48_1,Q48_2,Q48_3,Q49,Q49b,Q50,Q50b,Q51,Q51_1,Q51b,Q52,Q52b,Q53,Q54,Q55,Q55_1,Q56,Q56_1,Q57,Q58,Q59,Q60,Q61,Q62,Q62_1,Q63,Q63_1,Q64,Q65,Q66,Q67,Q68,Q64_68,Q64_68_1,Q69,Q70,Q71,Q72,Q73,Q74,Q75,Q76,Q77,Q78,Q79,Q80,Q81,Q76_81,Q81b,Q81b_1,Q81b_2,Q82c,Q82d,Q82e,Q82f,Q82h,Q83,Q84,Q85,Q86,Q87,Q88,Q89,Q89_1,Q90,Q90_1,Q91,Q92_1,Q92_2,Q92_3,Q92_4,Q92_5,Q92_6,Q92_7,Q92_8,Q93,Q94_1,Q94_2,Q94_3,Q94_4,Q94_5,Q94_6,Q94_7,Q95,Q96,Q97_1,Q97_2,Q97_3,Q97_4,Q97_6,Q97_7,Q98,Q99,Q99_1,Q100_1,Q100_2,Q101,Q102,Q103,Q103_1,Q104,Q104_1,Q105,Q105_1,Q106,Q107,Q107b,Q108,Q109_0,Q109_1,Q109_2,Q109_3,Q109_4,Q109_5,Q109_6,Q110,Q111,Q112,Q113,Q113b,Q114_1,Q114_2,Q114_3,Q114_4,Q114_5,Q115_1,Q115_2,Q115_3,Q115_4,Q115_5,Q115_6,Q115_7,Q116,Q117,Q118,Q118_1,Q119,Q120,Q120b_1,Q120b_2,Q120b_3,Q120b_4,Q120b_5,Q120b_6,Q120c,PE1,PE2,PE3,PE4,PE5,PE6,PE7,PE8,PE9_1,PE9_2,PE9_3,PE10_1,PE10_2,PE10_3,PE11_1,PE11_2,PE11_3,PE12_1,PE12_2,PE12_3,PE12_4,PE13_1,PE13_2,PE13_3,PE13_4,PE13_5,PE14_1,PE14_2,PE14_3,PE14_4,PE14_5,PE15_0,PE15_1,PE15_2,PE15_3,PE15_4,PE16_1,PE16_2,PE16_3,PE17_0,PE17_1,PE17_2,PE17_3,PE17_4,PE18_1,PE18_2,PE18_3,PE18_4,PE18_5,PE18_6,PE19_1,PE19_2,PE19_3,PE19_4,PE20_1,PE20_2,PE21_1,PE21_2,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] BHAMCDATA bHAMCDATA)
        {
            if (id != bHAMCDATA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bHAMCDATA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BHAMCDATAExists(bHAMCDATA.ID))
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
            return View(bHAMCDATA);
        }

        // GET: BHAM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bHAMCDATA = await _context.BHAMCDATA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bHAMCDATA == null)
            {
                return NotFound();
            }

            return View(bHAMCDATA);
        }

        // POST: BHAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bHAMCDATA = await _context.BHAMCDATA.FindAsync(id);
            _context.BHAMCDATA.Remove(bHAMCDATA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BHAMCDATAExists(int id)
        {
            return _context.BHAMCDATA.Any(e => e.ID == id);
        }
    }
}
