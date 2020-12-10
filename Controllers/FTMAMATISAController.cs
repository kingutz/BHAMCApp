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
    public class FTMAMATISAController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FTMAMATISAController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: FTMAMATISA
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FTISAMAMA.ToListAsync());
            }
            else
            {
                return View(await _context.FTISAMAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FTISAMAMA.ToListAsync());
        }

        // GET: FTMAMATISA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMAMA = await _context.FTISAMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTISAMAMA == null)
            {
                return NotFound();
            }

            return View(fTISAMAMA);
        }

        // GET: FTMAMATISA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FTMAMATISA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q5,Q6,Q6_1,Q7,Q7_1,Q8," +
            "Q9,Q10,Q10_1,Q11,Q12,Q12_1,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24," +
            "ProblemsDiagnosis,ManagementFT,DateVisit12,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTISAMAMA fTISAMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTISAMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fTISAMAMA);
        }

        // GET: FTMAMATISA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMAMA = await _context.FTISAMAMA.FindAsync(id);
            if (fTISAMAMA == null)
            {
                return NotFound();
            }
            return View(fTISAMAMA);
        }

        // POST: FTMAMATISA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q5,Q6,Q6_1,Q7," +
            "Q7_1,Q8,Q9,Q10,Q10_1,Q11,Q12,Q12_1,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,ProblemsDiagnosis," +
            "ManagementFT,DateVisit12,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTISAMAMA fTISAMAMA)
        {
            if (id != fTISAMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTISAMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTISAMAMAExists(fTISAMAMA.ID))
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
            return View(fTISAMAMA);
        }

        // GET: FTMAMATISA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTISAMAMA = await _context.FTISAMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTISAMAMA == null)
            {
                return NotFound();
            }

            return View(fTISAMAMA);
        }

        // POST: FTMAMATISA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTISAMAMA = await _context.FTISAMAMA.FindAsync(id);
            _context.FTISAMAMA.Remove(fTISAMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTISAMAMAExists(int id)
        {
            return _context.FTISAMAMA.Any(e => e.ID == id);
        }
        public async Task<ActionResult> Fsita()

        {
            List<FTISAMAMA> fTISAMAMA = new List<FTISAMAMA>();
            fTISAMAMA = await _context.FTISAMAMA.ToListAsync();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("fTISAMAMA");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Date";
                worksheet.Cell(currentRow, 4).Value = "Q1";
                worksheet.Cell(currentRow, 5).Value = "Q1_1";
                worksheet.Cell(currentRow, 6).Value = "Q2";
                worksheet.Cell(currentRow, 7).Value = "Q2_1";
                worksheet.Cell(currentRow, 8).Value = "Q3";
                worksheet.Cell(currentRow, 9).Value = "Q3_1";
                worksheet.Cell(currentRow, 10).Value = "Q4";
                worksheet.Cell(currentRow, 11).Value = "Q5";
                worksheet.Cell(currentRow, 12).Value = "Q6";
                worksheet.Cell(currentRow, 13).Value = "Q6_1";
                worksheet.Cell(currentRow, 14).Value = "Q7";
                worksheet.Cell(currentRow, 15).Value = "Q7_1";
                worksheet.Cell(currentRow, 16).Value = "Q8";
                worksheet.Cell(currentRow, 17).Value = "Q9";
                worksheet.Cell(currentRow, 18).Value = "Q10";
                worksheet.Cell(currentRow, 19).Value = "Q10_1";
                worksheet.Cell(currentRow, 20).Value = "Q11";
                worksheet.Cell(currentRow, 21).Value = "Q12";
                worksheet.Cell(currentRow, 22).Value = "Q12_1";
                worksheet.Cell(currentRow, 23).Value = "Q13";
                worksheet.Cell(currentRow, 24).Value = "Q14";
                worksheet.Cell(currentRow, 25).Value = "Q15";
                worksheet.Cell(currentRow, 26).Value = "Q16";
                worksheet.Cell(currentRow, 27).Value = "Q17";
                worksheet.Cell(currentRow, 28).Value = "Q18";
                worksheet.Cell(currentRow, 29).Value = "Q19";
                worksheet.Cell(currentRow, 30).Value = "Q20";
                worksheet.Cell(currentRow, 31).Value = "Q21";
                worksheet.Cell(currentRow, 32).Value = "Q22";
                worksheet.Cell(currentRow, 33).Value = "Q23";
                worksheet.Cell(currentRow, 34).Value = "Q24";
                worksheet.Cell(currentRow, 35).Value = "ProblemsDiagnosis";
                worksheet.Cell(currentRow, 36).Value = "ManagementFT";
                worksheet.Cell(currentRow, 37).Value = "DateVisit12";
                worksheet.Cell(currentRow, 38).Value = "CreatedDate";


                foreach (var item in fTISAMAMA)
                {
                   

                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Date;
                    worksheet.Cell(currentRow, 4).Value = item.Q1;
                    worksheet.Cell(currentRow, 5).Value = item.Q1_1;
                    worksheet.Cell(currentRow, 6).Value = item.Q2;
                    worksheet.Cell(currentRow, 7).Value = item.Q2_1;
                    worksheet.Cell(currentRow, 8).Value = item.Q3;
                    worksheet.Cell(currentRow, 9).Value = item.Q3_1;
                    worksheet.Cell(currentRow, 10).Value = item.Q4;
                    worksheet.Cell(currentRow, 11).Value = item.Q5;
                    worksheet.Cell(currentRow, 12).Value = item.Q6;
                    worksheet.Cell(currentRow, 13).Value = item.Q6_1;
                    worksheet.Cell(currentRow, 14).Value = item.Q7;
                    worksheet.Cell(currentRow, 15).Value = item.Q7_1;
                    worksheet.Cell(currentRow, 16).Value = item.Q8;
                    worksheet.Cell(currentRow, 17).Value = item.Q9;
                    worksheet.Cell(currentRow, 18).Value = item.Q10;
                    worksheet.Cell(currentRow, 19).Value = item.Q10_1;
                    worksheet.Cell(currentRow, 20).Value = item.Q11;
                    worksheet.Cell(currentRow, 21).Value = item.Q12;
                    worksheet.Cell(currentRow, 22).Value = item.Q12_1;
                    worksheet.Cell(currentRow, 23).Value = item.Q13;
                    worksheet.Cell(currentRow, 24).Value = item.Q14;
                    worksheet.Cell(currentRow, 25).Value = item.Q15;
                    worksheet.Cell(currentRow, 26).Value = item.Q16;
                    worksheet.Cell(currentRow, 27).Value = item.Q17;
                    worksheet.Cell(currentRow, 28).Value = item.Q18;
                    worksheet.Cell(currentRow, 29).Value = item.Q19;
                    worksheet.Cell(currentRow, 30).Value = item.Q20;
                    worksheet.Cell(currentRow, 31).Value = item.Q21;
                    worksheet.Cell(currentRow, 32).Value = item.Q22;
                    worksheet.Cell(currentRow, 33).Value = item.Q23;
                    worksheet.Cell(currentRow, 34).Value = item.Q24;
                    worksheet.Cell(currentRow, 35).Value = item.ProblemsDiagnosis;
                    worksheet.Cell(currentRow, 36).Value = item.ManagementFT;
                    worksheet.Cell(currentRow, 37).Value = item.DateVisit12;
                    worksheet.Cell(currentRow, 38).Value = item.CreatedDate;

                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu_mtisa.xlsx");
                }
            }
        }
    }
}
