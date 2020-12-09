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
    public class FKMMAMAMBILIController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FKMMAMAMBILIController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: FKMMAMAMBILI
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FKMMAMA.ToListAsync());
            }
            else
            {
                return View(await _context.FKMMAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FKMMAMA.ToListAsync());
        }

        // GET: FKMMAMAMBILI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMAMA = await _context.FKMMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMMAMA == null)
            {
                return NotFound();
            }

            return View(fKMMAMA);
        }

        // GET: FKMMAMAMBILI/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FKMMAMAMBILI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q5,Q6,Q7,Q7_1,Q8," +
            "Q9,Q9_1,Q10,Q11,Q11_1,Q13,Q14,Q15,Q16,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMMAMA fKMMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fKMMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fKMMAMA);
        }

        // GET: FKMMAMAMBILI/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMAMA = await _context.FKMMAMA.FindAsync(id);
            if (fKMMAMA == null)
            {
                return NotFound();
            }
            return View(fKMMAMA);
        }

        // POST: FKMMAMAMBILI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q5,Q6,Q7,Q7_1,Q8," +
            "Q9,Q9_1,Q10,Q11,Q11_1,Q13,Q14,Q15,Q16,ID,CreatedByUser," +
            "CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMMAMA fKMMAMA)
        {
            if (id != fKMMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fKMMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FKMMAMAExists(fKMMAMA.ID))
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
            return View(fKMMAMA);
        }

        // GET: FKMMAMAMBILI/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMAMA = await _context.FKMMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMMAMA == null)
            {
                return NotFound();
            }

            return View(fKMMAMA);
        }

        // POST: FKMMAMAMBILI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fKMMAMA = await _context.FKMMAMA.FindAsync(id);
            _context.FKMMAMA.Remove(fKMMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FKMMAMAExists(int id)
        {
            return _context.FKMMAMA.Any(e => e.ID == id);
        }
        public async Task<ActionResult> Fkmbili()

        {
            List<FKMMAMA> fKMMAMA = new List<FKMMAMA>();
            fKMMAMA = await _context.FKMMAMA.ToListAsync();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("fKMMAMA");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Date";
                worksheet.Cell(currentRow, 4).Value = "Q1";
                worksheet.Cell(currentRow, 5).Value = "Q1_1";
                worksheet.Cell(currentRow, 6).Value = "Q2";
                worksheet.Cell(currentRow, 8).Value = "Q3";
                worksheet.Cell(currentRow, 9).Value = "Q3_1";
                worksheet.Cell(currentRow, 10).Value = "Q4";
                worksheet.Cell(currentRow, 11).Value = "Q5";
                worksheet.Cell(currentRow, 12).Value = "Q6";
                worksheet.Cell(currentRow, 13).Value = "Q7";
                worksheet.Cell(currentRow, 14).Value = "Q7_1";
                worksheet.Cell(currentRow, 15).Value = "Q8";
                worksheet.Cell(currentRow, 16).Value = "Q9";
                worksheet.Cell(currentRow, 17).Value = "Q9_1";
                worksheet.Cell(currentRow, 18).Value = "Q10";
                worksheet.Cell(currentRow, 19).Value = "Q11";
                worksheet.Cell(currentRow, 20).Value = "Q11_1";
                worksheet.Cell(currentRow, 21).Value = "Q13";
                worksheet.Cell(currentRow, 22).Value = "Q14";
                worksheet.Cell(currentRow, 23).Value = "Q15";
                worksheet.Cell(currentRow, 24).Value = "Q15";
                worksheet.Cell(currentRow, 25).Value = "Q16";
                worksheet.Cell(currentRow, 26).Value = "CreatedDate";


                foreach (var item in fKMMAMA)
                {

                 
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Date;
                    worksheet.Cell(currentRow, 4).Value = item.Q1;
                    worksheet.Cell(currentRow, 5).Value = item.Q1_1;
                    worksheet.Cell(currentRow, 6).Value = item.Q2;
                    worksheet.Cell(currentRow, 8).Value = item.Q3;
                    worksheet.Cell(currentRow, 9).Value = item.Q3_1;
                    worksheet.Cell(currentRow, 10).Value = item.Q4;
                    worksheet.Cell(currentRow, 11).Value = item.Q5;
                    worksheet.Cell(currentRow, 12).Value = item.Q6;
                    worksheet.Cell(currentRow, 13).Value = item.Q7;
                    worksheet.Cell(currentRow, 14).Value = item.Q7_1;
                    worksheet.Cell(currentRow, 15).Value = item.Q8;
                    worksheet.Cell(currentRow, 16).Value = item.Q9;
                    worksheet.Cell(currentRow, 17).Value = item.Q9_1;
                    worksheet.Cell(currentRow, 18).Value = item.Q10;
                    worksheet.Cell(currentRow, 19).Value = item.Q11;
                    worksheet.Cell(currentRow, 20).Value = item.Q11_1;
                    worksheet.Cell(currentRow, 21).Value = item.Q13;
                    worksheet.Cell(currentRow, 22).Value = item.Q14;
                    worksheet.Cell(currentRow, 23).Value = item.Q15;
                    worksheet.Cell(currentRow, 24).Value = item.Q15;
                    worksheet.Cell(currentRow, 25).Value = item.Q16;
                    worksheet.Cell(currentRow, 26).Value = item.CreatedDate;

                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu_mkmbili.xlsx");
                }
            }
        }
    }
}

