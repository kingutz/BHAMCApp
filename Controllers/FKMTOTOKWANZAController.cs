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
    public class FKMTOTOKWANZAController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;
        

        public FKMTOTOKWANZAController(ApplicationDbContext context,RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: FKMTOTOKWANZA
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");

            if (isAdmin)
            {
                return View(await _context.FKMTOTO.ToListAsync());
            }
            else
            {
                return View(await _context.FKMTOTO.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
        }

        // GET: FKMTOTOKWANZA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMTOTO = await _context.FKMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMTOTO == null)
            {
                return NotFound();
            }

            return View(fKMTOTO);
        }

        // GET: FKMTOTOKWANZA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FKMTOTOKWANZA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tarehe,IDNumber,SexMt,TareheKuzaliwa,UmriMtotoMiezi," +
            "Q1,Q1_a,Q1_b,Q1_c,Q2,Q3,Q3_a,Q3_b,Q4,Q5_1_a,Q5_1_b,Q5_1_c,Q5_1_e,Q5_2_a,Q5_2_b,Q5_2_c,Q5_2_e," +
            "Q5_3_a,Q5_3_b,Q5_3_c,Q5_3_e,Q5_4_a,Q5_4_b,Q5_4_c,Q5_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q7_1,Q7_1_a," +
            "Q7_2,Q7_2_a,Q7_3,Q7_3_a,Q7_4,Q7_4_a,Q7_5,Q7_5_a,Q7_6,Q7_6_a,Q7_7,Q7_7_a,Q7_8,Q7_8_a,Q8,Q8_1,Q9," +
            "Q9_1,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d," +
            "Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g," +
            "Q15_h,Q16_a,Q16_b,Q16_c,ProblemsDsis,MedicationPres,Date3Month,ID,CreatedByUser,CreatedDate," +
            "ModifiedByUser,ModifiedDate,Edited")] FKMTOTO fKMTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fKMTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fKMTOTO);
        }

        // GET: FKMTOTOKWANZA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMTOTO = await _context.FKMTOTO.FindAsync(id);
            if (fKMTOTO == null)
            {
                return NotFound();
            }
            return View(fKMTOTO);
        }

        // POST: FKMTOTOKWANZA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Tarehe,IDNumber,SexMt,TareheKuzaliwa,UmriMtotoMiezi," +
            "Q1,Q1_a,Q1_b,Q1_c,Q2,Q3,Q3_a,Q3_b,Q4,Q5_1_a,Q5_1_b,Q5_1_c,Q5_1_e,Q5_2_a,Q5_2_b,Q5_2_c,Q5_2_e,Q5_3_a," +
            "Q5_3_b,Q5_3_c,Q5_3_e,Q5_4_a,Q5_4_b,Q5_4_c,Q5_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q7_1,Q7_1_a,Q7_2,Q7_2_a," +
            "Q7_3,Q7_3_a,Q7_4,Q7_4_a,Q7_5,Q7_5_a,Q7_6,Q7_6_a,Q7_7,Q7_7_a,Q7_8,Q7_8_a,Q8,Q8_1,Q9,Q9_1,Q10_a,Q10_b," +
            "Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b," +
            "Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c," +
            "ProblemsDsis,MedicationPres,Date3Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate," +
            "Edited")] FKMTOTO fKMTOTO)
        {
            if (id != fKMTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fKMTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FKMTOTOExists(fKMTOTO.ID))
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
            return View(fKMTOTO);
        }

        // GET: FKMTOTOKWANZA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMTOTO = await _context.FKMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMTOTO == null)
            {
                return NotFound();
            }

            return View(fKMTOTO);
        }

        // POST: FKMTOTOKWANZA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fKMTOTO = await _context.FKMTOTO.FindAsync(id);
            _context.FKMTOTO.Remove(fKMTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FKMTOTOExists(int id)
        {
            return _context.FKMTOTO.Any(e => e.ID == id);
        }
        

        public async Task<ActionResult> Fkwanza()

        {
            List<FKMTOTO> fKMTOTO = new List<FKMTOTO>();
            fKMTOTO = await _context.FKMTOTO.ToListAsync();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("fKMTOTO");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "SexMt";
                worksheet.Cell(currentRow, 4).Value = "UmriMtotoMiezi";
                worksheet.Cell(currentRow, 5).Value = "Q1";
                worksheet.Cell(currentRow, 6).Value = "Q1_a";
                worksheet.Cell(currentRow, 7).Value = "Q1_b";
                worksheet.Cell(currentRow, 8).Value = "Q1_c";
                worksheet.Cell(currentRow, 9).Value = "Q2";
                worksheet.Cell(currentRow, 10).Value = "Q3";
                worksheet.Cell(currentRow, 11).Value = "Q1";
                worksheet.Cell(currentRow, 12).Value = "Q2";
                worksheet.Cell(currentRow, 13).Value = "Q3";
                worksheet.Cell(currentRow, 14).Value = "Q3_a";
                worksheet.Cell(currentRow, 15).Value = "Q3_b";
                worksheet.Cell(currentRow, 16).Value = "Q4";
                worksheet.Cell(currentRow, 17).Value = "Q5_1_a";
                worksheet.Cell(currentRow, 18).Value = "Q5_1_b";
                worksheet.Cell(currentRow, 19).Value = "Q5_1_c";
                worksheet.Cell(currentRow, 20).Value = "Q5_1_e";
                worksheet.Cell(currentRow, 21).Value = "Q5_2_a";
                worksheet.Cell(currentRow, 22).Value = "Q5_2_b";
                worksheet.Cell(currentRow, 23).Value = "Q5_2_c";
                worksheet.Cell(currentRow, 24).Value = "Q5_2_e";
                worksheet.Cell(currentRow, 25).Value = "Q5_3_a";
                worksheet.Cell(currentRow, 26).Value = "Q5_3_b";
                worksheet.Cell(currentRow, 27).Value = "Q5_3_c";
                worksheet.Cell(currentRow, 28).Value = "Q5_3_e";
                worksheet.Cell(currentRow, 29).Value = "Q5_4_a";
                worksheet.Cell(currentRow, 30).Value = "Q5_4_b";
                worksheet.Cell(currentRow, 31).Value = "Q5_4_c";
                worksheet.Cell(currentRow, 32).Value = "Q5_4_e";
                worksheet.Cell(currentRow, 33).Value = "Q5_5_a";
                worksheet.Cell(currentRow, 34).Value = "Q5_5_b";
                worksheet.Cell(currentRow, 35).Value = "Q5_5_c";
                worksheet.Cell(currentRow, 36).Value = "Q5_5_e";
                worksheet.Cell(currentRow, 37).Value = "Q7_1";
                worksheet.Cell(currentRow, 38).Value = "Q7_1_a";
                worksheet.Cell(currentRow, 39).Value = "Q7_2";
                worksheet.Cell(currentRow, 40).Value = "Q7_2_a";
                worksheet.Cell(currentRow, 41).Value = "Q7_3";
                worksheet.Cell(currentRow, 42).Value = "Q7_3_a";
                worksheet.Cell(currentRow, 43).Value = "Q7_4";
                worksheet.Cell(currentRow, 44).Value = "Q7_4_a";
                worksheet.Cell(currentRow, 45).Value = "Q7_5";
                worksheet.Cell(currentRow, 46).Value = "Q7_5_a";
                worksheet.Cell(currentRow, 47).Value = "Q7_6";
                worksheet.Cell(currentRow, 48).Value = "Q7_6_a";
                worksheet.Cell(currentRow, 49).Value = "Q7_7";
                worksheet.Cell(currentRow, 50).Value = "Q7_7_a";
                worksheet.Cell(currentRow, 51).Value = "Q7_8";
                worksheet.Cell(currentRow, 52).Value = "Q7_8_a";
                worksheet.Cell(currentRow, 53).Value = "Q8";
                worksheet.Cell(currentRow, 54).Value = "Q8_1";
                worksheet.Cell(currentRow, 55).Value = "Q9";
                worksheet.Cell(currentRow, 56).Value = "Q9_1";
                worksheet.Cell(currentRow, 57).Value = "Q10_a";
                worksheet.Cell(currentRow, 58).Value = "Q10_b";
                worksheet.Cell(currentRow, 59).Value = "Q10_c";
                worksheet.Cell(currentRow, 60).Value = "Q10_d";
                worksheet.Cell(currentRow, 61).Value = "Q10_e";
                worksheet.Cell(currentRow, 62).Value = "Q11_a";
                worksheet.Cell(currentRow, 63).Value = "Q11_b";
                worksheet.Cell(currentRow, 64).Value = "Q11_c";
                worksheet.Cell(currentRow, 65).Value = "Q12_a";
                worksheet.Cell(currentRow, 66).Value = "Q12_b";
                worksheet.Cell(currentRow, 67).Value = "Q12_c";
                worksheet.Cell(currentRow, 68).Value = "Q13_a";
                worksheet.Cell(currentRow, 69).Value = "Q13_b";
                worksheet.Cell(currentRow, 70).Value = "Q13_c";
                worksheet.Cell(currentRow, 71).Value = "Q13_d";
                worksheet.Cell(currentRow, 72).Value = "Q13_e";
                worksheet.Cell(currentRow, 73).Value = "Q13_f";
                worksheet.Cell(currentRow, 74).Value = "Q14_a";
                worksheet.Cell(currentRow, 75).Value = "Q14_b";
                worksheet.Cell(currentRow, 76).Value = "Q14_c";
                worksheet.Cell(currentRow, 77).Value = "Q14_d";
                worksheet.Cell(currentRow, 78).Value = "Q14_e";
                worksheet.Cell(currentRow, 79).Value = "Q14_f";
                worksheet.Cell(currentRow, 80).Value = "Q14_g";
                worksheet.Cell(currentRow, 81).Value = "Q15_a";
                worksheet.Cell(currentRow, 82).Value = "Q15_b";
                worksheet.Cell(currentRow, 83).Value = "Q15_c";
                worksheet.Cell(currentRow, 84).Value = "Q15_d";
                worksheet.Cell(currentRow, 85).Value = "Q15_e";
                worksheet.Cell(currentRow, 86).Value = "Q15_f";
                worksheet.Cell(currentRow, 87).Value = "Q15_g";
                worksheet.Cell(currentRow, 88).Value = "Q15_h";
                worksheet.Cell(currentRow, 89).Value = "Q16_a";
                worksheet.Cell(currentRow, 90).Value = "Q16_b";
                worksheet.Cell(currentRow, 91).Value = "Q16_c";
                worksheet.Cell(currentRow, 92).Value = "ProblemsDsis";
                worksheet.Cell(currentRow, 93).Value = "MedicationPres";
                worksheet.Cell(currentRow, 94).Value = "Date3Month";
                worksheet.Cell(currentRow, 95).Value = "Tarehe";
                worksheet.Cell(currentRow, 96).Value = "CreatedDate";


                foreach (var item in fKMTOTO)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.SexMt;
                    worksheet.Cell(currentRow, 4).Value = item.UmriMtotoMiezi;
                    worksheet.Cell(currentRow, 5).Value = item.Q1;
                    worksheet.Cell(currentRow, 6).Value = item.Q1_a;
                    worksheet.Cell(currentRow, 7).Value = item.Q1_b;
                    worksheet.Cell(currentRow, 8).Value = item.Q1_c;
                    worksheet.Cell(currentRow, 9).Value = item.Q2;
                    worksheet.Cell(currentRow, 10).Value = item.Q3;
                    worksheet.Cell(currentRow, 11).Value = item.Q1;
                    worksheet.Cell(currentRow, 12).Value = item.Q2;
                    worksheet.Cell(currentRow, 13).Value = item.Q3;
                    worksheet.Cell(currentRow, 14).Value = item.Q3_a;
                    worksheet.Cell(currentRow, 15).Value = item.Q3_b;
                    worksheet.Cell(currentRow, 16).Value = item.Q4;
                    worksheet.Cell(currentRow, 17).Value = item.Q5_1_a;
                    worksheet.Cell(currentRow, 18).Value = item.Q5_1_b;
                    worksheet.Cell(currentRow, 19).Value = item.Q5_1_c;
                    worksheet.Cell(currentRow, 20).Value = item.Q5_1_e;
                    worksheet.Cell(currentRow, 21).Value = item.Q5_2_a;
                    worksheet.Cell(currentRow, 22).Value = item.Q5_2_b;
                    worksheet.Cell(currentRow, 23).Value = item.Q5_2_c;
                    worksheet.Cell(currentRow, 24).Value = item.Q5_2_e;
                    worksheet.Cell(currentRow, 25).Value = item.Q5_3_a;
                    worksheet.Cell(currentRow, 26).Value = item.Q5_3_b;
                    worksheet.Cell(currentRow, 27).Value = item.Q5_3_c;
                    worksheet.Cell(currentRow, 28).Value = item.Q5_3_e;
                    worksheet.Cell(currentRow, 29).Value = item.Q5_4_a;
                    worksheet.Cell(currentRow, 30).Value = item.Q5_4_b;
                    worksheet.Cell(currentRow, 31).Value = item.Q5_4_c;
                    worksheet.Cell(currentRow, 32).Value = item.Q5_4_e;
                    worksheet.Cell(currentRow, 33).Value = item.Q5_5_a;
                    worksheet.Cell(currentRow, 34).Value = item.Q5_5_b;
                    worksheet.Cell(currentRow, 35).Value = item.Q5_5_c;
                    worksheet.Cell(currentRow, 36).Value = item.Q5_5_e;
                    worksheet.Cell(currentRow, 37).Value = item.Q7_1;
                    worksheet.Cell(currentRow, 38).Value = item.Q7_1_a;
                    worksheet.Cell(currentRow, 39).Value = item.Q7_2;
                    worksheet.Cell(currentRow, 40).Value = item.Q7_2_a;
                    worksheet.Cell(currentRow, 41).Value = item.Q7_3;
                    worksheet.Cell(currentRow, 42).Value = item.Q7_3_a;
                    worksheet.Cell(currentRow, 43).Value = item.Q7_4;
                    worksheet.Cell(currentRow, 44).Value = item.Q7_4_a;
                    worksheet.Cell(currentRow, 45).Value = item.Q7_5;
                    worksheet.Cell(currentRow, 46).Value = item.Q7_5_a;
                    worksheet.Cell(currentRow, 47).Value = item.Q7_6;
                    worksheet.Cell(currentRow, 48).Value = item.Q7_6_a;
                    worksheet.Cell(currentRow, 49).Value = item.Q7_7;
                    worksheet.Cell(currentRow, 50).Value = item.Q7_7_a;
                    worksheet.Cell(currentRow, 51).Value = item.Q7_8;
                    worksheet.Cell(currentRow, 52).Value = item.Q7_8_a;
                    worksheet.Cell(currentRow, 53).Value = item.Q8;
                    worksheet.Cell(currentRow, 54).Value = item.Q8_1;
                    worksheet.Cell(currentRow, 55).Value = item.Q9;
                    worksheet.Cell(currentRow, 56).Value = item.Q9_1;
                    worksheet.Cell(currentRow, 57).Value = item.Q10_a;
                    worksheet.Cell(currentRow, 58).Value = item.Q10_b;
                    worksheet.Cell(currentRow, 59).Value = item.Q10_c;
                    worksheet.Cell(currentRow, 60).Value = item.Q10_d;
                    worksheet.Cell(currentRow, 61).Value = item.Q10_e;
                    worksheet.Cell(currentRow, 62).Value = item.Q11_a;
                    worksheet.Cell(currentRow, 63).Value = item.Q11_b;
                    worksheet.Cell(currentRow, 64).Value = item.Q11_c;
                    worksheet.Cell(currentRow, 65).Value = item.Q12_a;
                    worksheet.Cell(currentRow, 66).Value = item.Q12_b;
                    worksheet.Cell(currentRow, 67).Value = item.Q12_c;
                    worksheet.Cell(currentRow, 68).Value = item.Q13_a;
                    worksheet.Cell(currentRow, 69).Value = item.Q13_b;
                    worksheet.Cell(currentRow, 70).Value = item.Q13_c;
                    worksheet.Cell(currentRow, 71).Value = item.Q13_d;
                    worksheet.Cell(currentRow, 72).Value = item.Q13_e;
                    worksheet.Cell(currentRow, 73).Value = item.Q13_f;
                    worksheet.Cell(currentRow, 74).Value = item.Q14_a;
                    worksheet.Cell(currentRow, 75).Value = item.Q14_b;
                    worksheet.Cell(currentRow, 76).Value = item.Q14_c;
                    worksheet.Cell(currentRow, 77).Value = item.Q14_d;
                    worksheet.Cell(currentRow, 78).Value = item.Q14_e;
                    worksheet.Cell(currentRow, 79).Value = item.Q14_f;
                    worksheet.Cell(currentRow, 80).Value = item.Q14_g;
                    worksheet.Cell(currentRow, 81).Value = item.Q15_a;
                    worksheet.Cell(currentRow, 82).Value = item.Q15_b;
                    worksheet.Cell(currentRow, 83).Value = item.Q15_c;
                    worksheet.Cell(currentRow, 84).Value = item.Q15_d;
                    worksheet.Cell(currentRow, 85).Value = item.Q15_e;
                    worksheet.Cell(currentRow, 86).Value = item.Q15_f;
                    worksheet.Cell(currentRow, 87).Value = item.Q15_g;
                    worksheet.Cell(currentRow, 88).Value = item.Q15_h;
                    worksheet.Cell(currentRow, 89).Value = item.Q16_a;
                    worksheet.Cell(currentRow, 90).Value = item.Q16_b;
                    worksheet.Cell(currentRow, 91).Value = item.Q16_c;
                    worksheet.Cell(currentRow, 92).Value = item.ProblemsDsis;
                    worksheet.Cell(currentRow, 93).Value = item.MedicationPres;
                    worksheet.Cell(currentRow, 94).Value = item.Date3Month;
                    worksheet.Cell(currentRow, 95).Value = item.Tarehe;
                    worksheet.Cell(currentRow, 96).Value = item.CreatedDate;

                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomukwanza.xlsx");
                }
            }
        }
    }
}
