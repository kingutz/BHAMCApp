using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BHAMCApp.Data;
using BHAMCApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using BHAMCApp.Services;
using System.IO;
using ClosedXML.Excel;

namespace BHAMCApp.Controllers
{
    [Authorize(Roles = "admin,Datamanager")]
    public class F48MAMA48Controller : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public F48MAMA48Controller(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: F48MAMA48
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.F48MAMA.ToListAsync());
            }
            else
            {
                return View(await _context.F48MAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.F48MAMA.ToListAsync());
        }

        // GET: F48MAMA48/Details/5
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

        // GET: F48MAMA48/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F48MAMA48/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Date,MiakaMoshi,DateKuzaliwa,UmriMama,Q1,Q2,Q2_1,Q3,Q3_1" +
            ",Q4,Q4_1,Q5,Q6,Q7,Q8,Q8_1,Q8_2,Q9,Q9_1,Q9_2,Q9_3,Q10,Q11,Q11_1,Q12,Q13,Q13_1,Q13_2,Q13_3,Q14,Q15,Q16,Q16_1,Q17," +
            "Q17_1,Q18,Q19,Q19_1,Q19_2,Q20,Q20_1,Q20_2,Q20_2_1,Q20_3,Q20_3_1,Q21,Q22,Q22_1,Q23,Q24,Q25,Q25_1,Q26," +
            "Q27,Q27_1,Q27_2,Q27_3,Q28,Q28_1,Q29,Q30,Q31,Q31_1,Q31_2,Q31_3,Q31_4,Q31_5,Q32,Q32_1,Q32_2,Q32_3," +
            "Q32_4,Q32_5,Q32_6,Q33,Q33_1,Q34,Q35_1,Q35_2,Q35_3,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44," +
            "ProblemsDiagnosis,ManagementFT,DateVisit52,ID,CreatedByUser," +
            "CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F48MAMA f48MAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f48MAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f48MAMA);
        }

        // GET: F48MAMA48/Edit/5
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

        // POST: F48MAMA48/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Date,MiakaMoshi,DateKuzaliwa,UmriMama,Q1,Q2,Q2_1,Q3," +
            "Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q8_1,Q8_2,Q9,Q9_1,Q9_2,Q9_3,Q9_1,Q10,Q11,Q11_1,Q12,Q13,Q13_1,Q13_2,Q13_3,Q14,Q15,Q16,Q16_1,Q17," +
            "Q17_1,Q18,Q19,Q19_1,Q19_2,Q20,Q20_1,Q20_2,Q20_2_1,Q20_3,Q20_3_1,Q21,Q22,Q22_1,Q23,Q24,Q25,Q25_1,Q26,Q27," +
            "Q27_1,Q27_2,Q27_3,Q28,Q28_1,Q29,Q30,Q31,Q31_1,Q31_2,Q31_3,Q31_4,Q31_5,Q32,Q32_1,Q32_2,Q32_3,Q32_4,Q32_5," +
            "Q32_6,Q33,Q33_1,Q34,Q35_1,Q35_2,Q35_3,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44,ProblemsDiagnosis,ManagementFT," +
            "DateVisit52,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F48MAMA f48MAMA)
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

        // GET: F48MAMA48/Delete/5
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

        // POST: F48MAMA48/Delete/5
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
        public async Task<ActionResult> F44()

        {
            List<F48MAMA> f48MAMA = new List<F48MAMA>();
            f48MAMA = await _context.F48MAMA.ToListAsync();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("f48MAMA");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Date";
                worksheet.Cell(currentRow, 4).Value = "MiakaMoshi";
                worksheet.Cell(currentRow, 5).Value = "DateKuzaliwa";
                worksheet.Cell(currentRow, 6).Value = "UmriMama";
                worksheet.Cell(currentRow, 7).Value = "Q1";
                worksheet.Cell(currentRow, 8).Value = "Q2";
                worksheet.Cell(currentRow, 9).Value = "Q2_1";
                worksheet.Cell(currentRow, 10).Value = "Q3";
                worksheet.Cell(currentRow, 11).Value = "Q3_1";
                worksheet.Cell(currentRow, 12).Value = "Q4";
                worksheet.Cell(currentRow, 13).Value = "Q4_1";
                worksheet.Cell(currentRow, 14).Value = "Q5";
                worksheet.Cell(currentRow, 15).Value = "Q6";
                worksheet.Cell(currentRow, 16).Value = "Q7";
                worksheet.Cell(currentRow, 17).Value = "Q8";
                worksheet.Cell(currentRow, 18).Value = "Q8_1";
                worksheet.Cell(currentRow, 19).Value = "Q8_2";
                worksheet.Cell(currentRow, 20).Value = "Q9";
                worksheet.Cell(currentRow, 21).Value = "Q9_1";
                worksheet.Cell(currentRow, 22).Value = "Q9_2";
                worksheet.Cell(currentRow, 23).Value = "Q9_3";
                worksheet.Cell(currentRow, 24).Value = "Q10";
                worksheet.Cell(currentRow, 25).Value = "Q11";
                worksheet.Cell(currentRow, 26).Value = "Q11_1";
                worksheet.Cell(currentRow, 27).Value = "Q12";
                worksheet.Cell(currentRow, 28).Value = "Q13";
                worksheet.Cell(currentRow, 29).Value = "Q13_1";
                worksheet.Cell(currentRow, 30).Value = "Q13_2";
                worksheet.Cell(currentRow, 31).Value = "Q13_3";
                worksheet.Cell(currentRow, 32).Value = "Q14";
                worksheet.Cell(currentRow, 33).Value = "Q15";
                worksheet.Cell(currentRow, 34).Value = "Q16";
                worksheet.Cell(currentRow, 35).Value = "Q16_1";
                worksheet.Cell(currentRow, 36).Value = "Q17";
                worksheet.Cell(currentRow, 37).Value = "Q17_1";
                worksheet.Cell(currentRow, 38).Value = "Q18";
                worksheet.Cell(currentRow, 39).Value = "Q19_1";
                worksheet.Cell(currentRow, 40).Value = "Q19_2";
                worksheet.Cell(currentRow, 41).Value = "Q20";
                worksheet.Cell(currentRow, 42).Value = "Q20_1";
                worksheet.Cell(currentRow, 43).Value = "Q20_2";
                worksheet.Cell(currentRow, 44).Value = "Q20_2_1";
                worksheet.Cell(currentRow, 45).Value = "Q20_3";
                worksheet.Cell(currentRow, 46).Value = "Q20_3_1";
                worksheet.Cell(currentRow, 47).Value = "Q21";
                worksheet.Cell(currentRow, 48).Value = "Q22";
                worksheet.Cell(currentRow, 49).Value = "Q22_1";
                worksheet.Cell(currentRow, 50).Value = "Q23";
                worksheet.Cell(currentRow, 51).Value = "Q24";
                worksheet.Cell(currentRow, 52).Value = "Q25";
                worksheet.Cell(currentRow, 53).Value = "Q25_1";
                worksheet.Cell(currentRow, 54).Value = "Q26";
                worksheet.Cell(currentRow, 55).Value = "Q27";
                worksheet.Cell(currentRow, 56).Value = "Q27_1";
                worksheet.Cell(currentRow, 57).Value = "Q27_2";
                worksheet.Cell(currentRow, 58).Value = "Q27_3";
                worksheet.Cell(currentRow, 59).Value = "Q28";
                worksheet.Cell(currentRow, 60).Value = "Q28_1";
                worksheet.Cell(currentRow, 61).Value = "Q29";
                worksheet.Cell(currentRow, 62).Value = "Q30";
                worksheet.Cell(currentRow, 63).Value = "Q31";
                worksheet.Cell(currentRow, 64).Value = "Q31_1";
                worksheet.Cell(currentRow, 65).Value = "Q31_2";
                worksheet.Cell(currentRow, 66).Value = "Q31_3";
                worksheet.Cell(currentRow, 67).Value = "Q31_4";
                worksheet.Cell(currentRow, 68).Value = "Q31_5";
                worksheet.Cell(currentRow, 69).Value = "Q32";
                worksheet.Cell(currentRow, 70).Value = "Q32_1";
                worksheet.Cell(currentRow, 71).Value = "Q32_2";
                worksheet.Cell(currentRow, 72).Value = "Q32_3";
                worksheet.Cell(currentRow, 73).Value = "Q32_4";
                worksheet.Cell(currentRow, 74).Value = "Q32_5";
                worksheet.Cell(currentRow, 75).Value = "Q32_6";
                worksheet.Cell(currentRow, 76).Value = "Q33";
                worksheet.Cell(currentRow, 77).Value = "Q33_1";
                worksheet.Cell(currentRow, 78).Value = "Q34";
                worksheet.Cell(currentRow, 79).Value = "Q35_1";
                worksheet.Cell(currentRow, 80).Value = "Q35_2";
                worksheet.Cell(currentRow, 81).Value = "Q35_3";
                worksheet.Cell(currentRow, 82).Value = "Q36";
                worksheet.Cell(currentRow, 83).Value = "Q37";
                worksheet.Cell(currentRow, 84).Value = "Q38";
                worksheet.Cell(currentRow, 85).Value = "Q39";
                worksheet.Cell(currentRow, 86).Value = "Q40";
                worksheet.Cell(currentRow, 87).Value = "Q41";
                worksheet.Cell(currentRow, 88).Value = "Q42";
                worksheet.Cell(currentRow, 89).Value = "Q43";
                worksheet.Cell(currentRow, 90).Value = "Q44";
                worksheet.Cell(currentRow, 91).Value = "ProblemsDiagnosis";
                worksheet.Cell(currentRow, 92).Value = "ManagementFT";
                worksheet.Cell(currentRow, 93).Value = "DateVisit52";
                worksheet.Cell(currentRow, 94).Value = "CreatedDate";


                foreach (var item in f48MAMA)
                {
                   

                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Date;
                    worksheet.Cell(currentRow, 4).Value = item.MiakaMoshi;
                    worksheet.Cell(currentRow, 5).Value = item.DateKuzaliwa;
                    worksheet.Cell(currentRow, 6).Value = item.UmriMama;
                    worksheet.Cell(currentRow, 7).Value = item.Q1;
                    worksheet.Cell(currentRow, 8).Value = item.Q2;
                    worksheet.Cell(currentRow, 9).Value = item.Q2_1;
                    worksheet.Cell(currentRow, 10).Value = item.Q3;
                    worksheet.Cell(currentRow, 11).Value = item.Q3_1;
                    worksheet.Cell(currentRow, 12).Value = item.Q4;
                    worksheet.Cell(currentRow, 13).Value = item.Q4_1;
                    worksheet.Cell(currentRow, 14).Value = item.Q5;
                     worksheet.Cell(currentRow, 15).Value = item.Q6;
                    worksheet.Cell(currentRow, 16).Value = item.Q7;
                    worksheet.Cell(currentRow, 17).Value = item.Q8;
                    worksheet.Cell(currentRow, 18).Value = item.Q8_1;
                    worksheet.Cell(currentRow, 19).Value = item.Q8_2;
                    worksheet.Cell(currentRow, 20).Value = item.Q9;
                    worksheet.Cell(currentRow, 21).Value = item.Q9_1;
                    worksheet.Cell(currentRow, 22).Value = item.Q9_2;
                    worksheet.Cell(currentRow, 23).Value = item.Q9_3;
                    worksheet.Cell(currentRow, 24).Value = item.Q10;
                     worksheet.Cell(currentRow, 25).Value = item.Q11;
                    worksheet.Cell(currentRow, 26).Value = item.Q11_1;
                    worksheet.Cell(currentRow, 27).Value = item.Q12;
                    worksheet.Cell(currentRow, 28).Value = item.Q13;
                    worksheet.Cell(currentRow, 29).Value = item.Q13_1;
                    worksheet.Cell(currentRow, 30).Value = item.Q13_2;
                    worksheet.Cell(currentRow, 31).Value = item.Q13_3;
                    worksheet.Cell(currentRow, 32).Value = item.Q14;
                    worksheet.Cell(currentRow, 33).Value = item.Q15;
                    worksheet.Cell(currentRow, 34).Value = item.Q16;
                    worksheet.Cell(currentRow, 35).Value = item.Q16_1;
                    worksheet.Cell(currentRow, 36).Value = item.Q17;
                    worksheet.Cell(currentRow, 37).Value = item.Q17_1;
                    worksheet.Cell(currentRow, 38).Value = item.Q18;
                    worksheet.Cell(currentRow, 39).Value = item.Q19_1;
                    worksheet.Cell(currentRow, 40).Value = item.Q19_2;
                     worksheet.Cell(currentRow, 41).Value = item.Q20;
                    worksheet.Cell(currentRow, 42).Value = item.Q20_1;
                    worksheet.Cell(currentRow, 43).Value = item.Q20_2;
                    worksheet.Cell(currentRow, 44).Value = item.Q20_2_1;
                    worksheet.Cell(currentRow, 45).Value = item.Q20_3;
                    worksheet.Cell(currentRow, 46).Value = item.Q20_3_1;
                    worksheet.Cell(currentRow, 47).Value = item.Q21;
                    worksheet.Cell(currentRow, 48).Value = item.Q22;
                    worksheet.Cell(currentRow, 49).Value = item.Q22_1;
                    worksheet.Cell(currentRow, 50).Value = item.Q23;
                    worksheet.Cell(currentRow, 51).Value = item.Q24;
                    worksheet.Cell(currentRow, 52).Value = item.Q25;
                    worksheet.Cell(currentRow, 53).Value = item.Q25_1;
                    worksheet.Cell(currentRow, 54).Value = item.Q26;
                    worksheet.Cell(currentRow, 55).Value = item.Q27;
                    worksheet.Cell(currentRow, 56).Value = item.Q27_1;
                    worksheet.Cell(currentRow, 57).Value = item.Q27_2;
                    worksheet.Cell(currentRow, 58).Value = item.Q27_3;
                    worksheet.Cell(currentRow, 59).Value = item.Q28;
                    worksheet.Cell(currentRow, 60).Value = item.Q28_1;
                    worksheet.Cell(currentRow, 61).Value = item.Q29;
                    worksheet.Cell(currentRow, 62).Value = item.Q30;
                    worksheet.Cell(currentRow, 63).Value = item.Q31;
                    worksheet.Cell(currentRow, 64).Value = item.Q31_1;
                    worksheet.Cell(currentRow, 65).Value = item.Q31_2;
                    worksheet.Cell(currentRow, 66).Value = item.Q31_3;
                    worksheet.Cell(currentRow, 67).Value = item.Q31_4;
                    worksheet.Cell(currentRow, 68).Value = item.Q31_5;
                    worksheet.Cell(currentRow, 69).Value = item.Q32;
                    worksheet.Cell(currentRow, 70).Value = item.Q32_1;
                    worksheet.Cell(currentRow, 71).Value = item.Q32_2;
                    worksheet.Cell(currentRow, 72).Value = item.Q32_3;
                    worksheet.Cell(currentRow, 73).Value = item.Q32_4;
                    worksheet.Cell(currentRow, 74).Value = item.Q32_5;
                    worksheet.Cell(currentRow, 75).Value = item.Q32_6;
                    worksheet.Cell(currentRow, 76).Value = item.Q33;
                    worksheet.Cell(currentRow, 77).Value = item.Q33_1;
                    worksheet.Cell(currentRow, 78).Value = item.Q34;
                    worksheet.Cell(currentRow, 79).Value = item.Q35_1;
                    worksheet.Cell(currentRow, 80).Value = item.Q35_2;
                    worksheet.Cell(currentRow, 81).Value = item.Q35_3;
                    worksheet.Cell(currentRow, 82).Value = item.Q36;
                    worksheet.Cell(currentRow, 83).Value = item.Q37;
                    worksheet.Cell(currentRow, 84).Value = item.Q38;
                    worksheet.Cell(currentRow, 85).Value = item.Q39;
                    worksheet.Cell(currentRow, 86).Value = item.Q40;
                    worksheet.Cell(currentRow, 87).Value = item.Q41;
                    worksheet.Cell(currentRow, 88).Value = item.Q42;
                    worksheet.Cell(currentRow, 89).Value = item.Q43;
                    worksheet.Cell(currentRow, 90).Value = item.Q44;
                    worksheet.Cell(currentRow, 91).Value = item.ProblemsDiagnosis;
                    worksheet.Cell(currentRow, 92).Value = item.ManagementFT;
                    worksheet.Cell(currentRow, 93).Value = item.DateVisit52;
                    worksheet.Cell(currentRow, 94).Value = item.CreatedDate;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu_m44.xlsx");
                }
            }
        }
    }
}
