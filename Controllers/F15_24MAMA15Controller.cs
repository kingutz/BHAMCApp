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
    public class F15_24MAMA15Controller : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public F15_24MAMA15Controller(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: F15_24MAMA15
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.F15_24MAMA.ToListAsync());
            }
            else
            {
                return View(await _context.F15_24MAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.F15_24MAMA.ToListAsync());
        }

        // GET: F15_24MAMA15/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f15_24MAMA = await _context.F15_24MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f15_24MAMA == null)
            {
                return NotFound();
            }

            return View(f15_24MAMA);
        }

        // GET: F15_24MAMA15/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F15_24MAMA15/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Date,Q1,Q1_1,Q2,Q2_1,Q3,Q4,Q4_1,Q4_2,Q5,Q6,Q6_1,Q7," +
            "Q8,Q9,Q10,Q10_1,Q11,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F15_24MAMA f15_24MAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f15_24MAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f15_24MAMA);
        }

        // GET: F15_24MAMA15/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f15_24MAMA = await _context.F15_24MAMA.FindAsync(id);
            if (f15_24MAMA == null)
            {
                return NotFound();
            }
            return View(f15_24MAMA);
        }

        // POST: F15_24MAMA15/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Date,Q1,Q1_1,Q2,Q2_1,Q3,Q4,Q4_1,Q4_2,Q5,Q6," +
            "Q6_1,Q7,Q8,Q9,Q10,Q10_1,Q11,ID,CreatedByUser,CreatedDate," +
            "ModifiedByUser,ModifiedDate,Edited")] F15_24MAMA f15_24MAMA)
        {
            if (id != f15_24MAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f15_24MAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F15_24MAMAExists(f15_24MAMA.ID))
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
            return View(f15_24MAMA);
        }

        // GET: F15_24MAMA15/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f15_24MAMA = await _context.F15_24MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f15_24MAMA == null)
            {
                return NotFound();
            }

            return View(f15_24MAMA);
        }

        // POST: F15_24MAMA15/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f15_24MAMA = await _context.F15_24MAMA.FindAsync(id);
            _context.F15_24MAMA.Remove(f15_24MAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F15_24MAMAExists(int id)
        {
            return _context.F15_24MAMA.Any(e => e.ID == id);
        }
        public async Task<ActionResult> F15_24()

        {
            List<F15_24MAMA> f15MAMA = new List<F15_24MAMA>();
            f15MAMA = await _context.F15_24MAMA.ToListAsync();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("f15MAMA");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Date";
                worksheet.Cell(currentRow, 4).Value = "Q1";
                worksheet.Cell(currentRow, 5).Value = "Q1_1";
                worksheet.Cell(currentRow, 6).Value = "Q2";
                worksheet.Cell(currentRow, 7).Value = "Q2_1";
                worksheet.Cell(currentRow, 8).Value = "Q3";
                worksheet.Cell(currentRow, 9).Value = "Q4";
                worksheet.Cell(currentRow, 10).Value = "Q4_1";
                worksheet.Cell(currentRow, 11).Value = "Q4_2";
                worksheet.Cell(currentRow, 12).Value = "Q5";
                worksheet.Cell(currentRow, 13).Value = "Q6";
                worksheet.Cell(currentRow, 14).Value = "Q6_1";
                worksheet.Cell(currentRow, 15).Value = "Q7";
                worksheet.Cell(currentRow, 16).Value = "Q8";
                worksheet.Cell(currentRow, 17).Value = "Q9";
                worksheet.Cell(currentRow, 18).Value = "Q10";
                worksheet.Cell(currentRow, 19).Value = "Q10_1";
                worksheet.Cell(currentRow, 20).Value = "Q11";
                worksheet.Cell(currentRow, 21).Value = "CreatedDate";


                foreach (var item in f15MAMA)
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
                    worksheet.Cell(currentRow, 9).Value = item.Q4;
                    worksheet.Cell(currentRow, 10).Value = item.Q4_1;
                    worksheet.Cell(currentRow, 11).Value = item.Q4_2;
                    worksheet.Cell(currentRow, 12).Value = item.Q5;
                    worksheet.Cell(currentRow, 13).Value = item.Q6;
                    worksheet.Cell(currentRow, 14).Value = item.Q6_1;
                    worksheet.Cell(currentRow, 15).Value = item.Q7;
                    worksheet.Cell(currentRow, 16).Value = item.Q8;
                    worksheet.Cell(currentRow, 17).Value = item.Q9;
                    worksheet.Cell(currentRow, 18).Value = item.Q10;
                    worksheet.Cell(currentRow, 19).Value = item.Q10_1;
                    worksheet.Cell(currentRow, 20).Value = item.Q11;
                    worksheet.Cell(currentRow, 21).Value = item.CreatedDate;

                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu_m15_24.xlsx");
                }
            }
        }
    }
}
