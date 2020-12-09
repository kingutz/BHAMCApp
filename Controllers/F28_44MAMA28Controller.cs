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
    public class F28_44MAMA28Controller : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public F28_44MAMA28Controller(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: F28_44MAMA28
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.F28_44MAMA.ToListAsync());
            }
            else
            {
                return View(await _context.F28_44MAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.F28_44MAMA.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("IDNumber,Date,DateKuzaliwa,UmriMama,Q1,Q2,Q3,Q3_1,Q4," +
            "Q5,Q5_1,Q6,Q7," +
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
        public async Task<ActionResult> F28_44()

        {
            List<F28_44MAMA> f44MAMA = new List<F28_44MAMA>();
            f44MAMA = await _context.F28_44MAMA.ToListAsync();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("f44MAMA");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Date";
                worksheet.Cell(currentRow, 4).Value = "DateKuzaliwa";
                worksheet.Cell(currentRow, 5).Value = "UmriMama";
                worksheet.Cell(currentRow, 6).Value = "Q1";
                worksheet.Cell(currentRow, 7).Value = "Q2";
                worksheet.Cell(currentRow, 8).Value = "Q3";
                worksheet.Cell(currentRow, 9).Value = "Q3_1";
                worksheet.Cell(currentRow, 10).Value = "Q4";
                worksheet.Cell(currentRow, 11).Value = "Q5";
                worksheet.Cell(currentRow, 12).Value = "Q5_1";
                worksheet.Cell(currentRow, 13).Value = "Q6";
                worksheet.Cell(currentRow, 14).Value = "Q7";
                worksheet.Cell(currentRow, 15).Value = "Q7_1";
                worksheet.Cell(currentRow, 16).Value = "Q7_2";
                worksheet.Cell(currentRow, 17).Value = "Q8";
                worksheet.Cell(currentRow, 18).Value = "Q9";
                worksheet.Cell(currentRow, 19).Value = "Q10";
                worksheet.Cell(currentRow, 20).Value = "Q10_1";
                worksheet.Cell(currentRow, 21).Value = "Q11";
                worksheet.Cell(currentRow, 22).Value = "Q12";
                worksheet.Cell(currentRow, 23).Value = "Q13";
                worksheet.Cell(currentRow, 24).Value = "Q13_1";
                worksheet.Cell(currentRow, 25).Value = "Q13_2";
                worksheet.Cell(currentRow, 26).Value = "Q13_3";
                worksheet.Cell(currentRow, 27).Value = "Q14_1";
                worksheet.Cell(currentRow, 28).Value = "Q14_2";
                worksheet.Cell(currentRow, 29).Value = "Q14_3";
                worksheet.Cell(currentRow, 30).Value = "Q14_4";
                worksheet.Cell(currentRow, 31).Value = "Q14_5";
                worksheet.Cell(currentRow, 32).Value = "Q14_6";
                worksheet.Cell(currentRow, 33).Value = "Q15";
                worksheet.Cell(currentRow, 34).Value = "Q15_1";
                worksheet.Cell(currentRow, 35).Value = "Q16";
                worksheet.Cell(currentRow, 36).Value = "Q16_1";
                worksheet.Cell(currentRow, 37).Value = "Q16_2";
                worksheet.Cell(currentRow, 38).Value = "Q17";
                worksheet.Cell(currentRow, 39).Value = "Q18";
                worksheet.Cell(currentRow, 40).Value = "Q19_1";
                worksheet.Cell(currentRow, 41).Value = "Q19_2";
                worksheet.Cell(currentRow, 42).Value = "Q19_3";
                worksheet.Cell(currentRow, 43).Value = "Q20";
                worksheet.Cell(currentRow, 44).Value = "Q21";
                worksheet.Cell(currentRow, 45).Value = "Q22";
                worksheet.Cell(currentRow, 46).Value = "Q23";
                worksheet.Cell(currentRow, 47).Value = "Q24";
                worksheet.Cell(currentRow, 48).Value = "Q25";
                worksheet.Cell(currentRow, 49).Value = "Q26";
                worksheet.Cell(currentRow, 50).Value = "Q27";
                worksheet.Cell(currentRow, 51).Value = "Q28";
                worksheet.Cell(currentRow, 52).Value = "Q29";
                worksheet.Cell(currentRow, 53).Value = "Q30";
                worksheet.Cell(currentRow, 54).Value = "ProblemsDiagnosis";
                worksheet.Cell(currentRow, 55).Value = "ManagementFT";
                worksheet.Cell(currentRow, 56).Value = "DateVisit32";
                worksheet.Cell(currentRow, 57).Value = "CreatedDate";


                foreach (var item in f44MAMA)
                {

              
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Date;
                    worksheet.Cell(currentRow, 4).Value = item.DateKuzaliwa;
                    worksheet.Cell(currentRow, 5).Value = item.UmriMama;
                    worksheet.Cell(currentRow, 6).Value = item.Q1;
                    worksheet.Cell(currentRow, 7).Value = item.Q2;
                    worksheet.Cell(currentRow, 8).Value = item.Q3;
                    worksheet.Cell(currentRow, 9).Value = item.Q3_1;
                    worksheet.Cell(currentRow, 10).Value = item.Q4;
                    worksheet.Cell(currentRow, 11).Value = item.Q5;
                    worksheet.Cell(currentRow, 12).Value = item.Q5_1;
                    worksheet.Cell(currentRow, 13).Value = item.Q6;
                    worksheet.Cell(currentRow, 14).Value = item.Q7;
                    worksheet.Cell(currentRow, 15).Value = item.Q7_1;
                    worksheet.Cell(currentRow, 16).Value = item.Q7_2;
                    worksheet.Cell(currentRow, 17).Value = item.Q8;
                    worksheet.Cell(currentRow, 18).Value = item.Q9;
                    worksheet.Cell(currentRow, 19).Value = item.Q10;
                    worksheet.Cell(currentRow, 20).Value = item.Q10_1;
                    worksheet.Cell(currentRow, 21).Value = item.Q11;
                    worksheet.Cell(currentRow, 22).Value = item.Q12;
                    worksheet.Cell(currentRow, 23).Value = item.Q13;
                    worksheet.Cell(currentRow, 24).Value = item.Q13_1;
                    worksheet.Cell(currentRow, 25).Value = item.Q13_2;
                    worksheet.Cell(currentRow, 26).Value = item.Q13_3;
                    worksheet.Cell(currentRow, 27).Value = item.Q14_1;
                    worksheet.Cell(currentRow, 28).Value = item.Q14_2;
                    worksheet.Cell(currentRow, 29).Value = item.Q14_3;
                    worksheet.Cell(currentRow, 30).Value = item.Q14_4;
                    worksheet.Cell(currentRow, 31).Value = item.Q14_5;
                    worksheet.Cell(currentRow, 32).Value = item.Q14_6;
                    worksheet.Cell(currentRow, 33).Value = item.Q15;
                    worksheet.Cell(currentRow, 34).Value = item.Q15_1;
                    worksheet.Cell(currentRow, 35).Value = item.Q16;
                    worksheet.Cell(currentRow, 36).Value = item.Q16_1;
                    worksheet.Cell(currentRow, 37).Value = item.Q16_2;
                    worksheet.Cell(currentRow, 38).Value = item.Q17;
                    worksheet.Cell(currentRow, 39).Value = item.Q18;
                    worksheet.Cell(currentRow, 40).Value = item.Q19_1;
                    worksheet.Cell(currentRow, 41).Value = item.Q19_2;
                    worksheet.Cell(currentRow, 42).Value = item.Q19_3;
                    worksheet.Cell(currentRow, 43).Value = item.Q20;
                    worksheet.Cell(currentRow, 44).Value = item.Q21;
                    worksheet.Cell(currentRow, 45).Value = item.Q22;
                    worksheet.Cell(currentRow, 46).Value = item.Q23;
                    worksheet.Cell(currentRow, 47).Value = item.Q24;
                    worksheet.Cell(currentRow, 48).Value = item.Q25;
                    worksheet.Cell(currentRow, 49).Value = item.Q26;
                    worksheet.Cell(currentRow, 50).Value = item.Q27;
                    worksheet.Cell(currentRow, 51).Value = item.Q28;
                    worksheet.Cell(currentRow, 52).Value = item.Q29;
                    worksheet.Cell(currentRow, 53).Value = item.Q30;
                    worksheet.Cell(currentRow, 54).Value = item.ProblemsDiagnosis;
                    worksheet.Cell(currentRow, 55).Value = item.ManagementFT;
                    worksheet.Cell(currentRow, 56).Value = item.DateVisit32;
                    worksheet.Cell(currentRow, 57).Value = item.CreatedDate;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu_m28_44.xlsx");
                }
            }
        }
    }
}
