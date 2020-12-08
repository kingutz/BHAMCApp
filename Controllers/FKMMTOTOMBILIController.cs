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
using ClosedXML.Excel;
using System.IO;

namespace BHAMCApp.Controllers
{
    [Authorize(Roles = "admin,Datamanager")]
    public class FKMMTOTOMBILIController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FKMMTOTOMBILIController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: FKMMTOTOMBILI
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");

            if (isAdmin)
            {
                return View(await _context.FKMMTOTO.ToListAsync());
            }
            else
            {
                return View(await _context.FKMMTOTO.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FKMMTOTO.ToListAsync());
        }

        // GET: FKMMTOTOMBILI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMTOTO = await _context.FKMMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMMTOTO == null)
            {
                return NotFound();
            }

            return View(fKMMTOTO);
        }

        // GET: FKMMTOTOMBILI/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FKMMTOTOMBILI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q3," +
            "Q1_1_a,Q1_1_b,Q1_1_c,Q2_2_a,Q2_2_b,Q2_2_c,Q3_3_a,Q3_3_b,Q3_3_c,Q4_4_a,Q4_4_b,Q4_4_c,Q5_5_a,Q5_5_b,Q5_5_c," +
            "Q6_5_a,Q6_5_b,Q6_5_c,Q7_5_a,Q7_5_b,Q7_5_c,Q8_5_a,Q8_5_b,Q8_5_c,Q4_1,Q4_1_a,Q4_2,Q4_2_a,Q4_3,Q4_3_a,Q4_4," +
            "Q4_4_aa,Q4_5,Q4_5_aa,Q4_6,Q4_6_a,Q4_7,Q4_7_a,Q4_8,Q4_8_a,Q5,Q5_1,Q6_a_1,Q6_a_2,Q6_a_3,Q6_a_4,Q6_a_5,Q6_b_1," +
            "Q6_b_2,Q6_b_3,Q6_b_4,Q6_b_5,Q6_c_1,Q6_c_2,Q6_c_3,Q6_c_4,Q6_c_5,Q6_d_1,Q6_d_2,Q6_d_3,Q6_d_4,Q6_d_5,Q10_a," +
            "Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b," +
            "Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a," +
            "Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser," +
            "ModifiedDate,Edited")] FKMMTOTO fKMMTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fKMMTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fKMMTOTO);
        }

        // GET: FKMMTOTOMBILI/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMTOTO = await _context.FKMMTOTO.FindAsync(id);
            if (fKMMTOTO == null)
            {
                return NotFound();
            }
            return View(fKMMTOTO);
        }

        // POST: FKMMTOTOMBILI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q3,Q1_1_a,Q1_1_b,Q1_1_c,Q2_2_a,Q2_2_b,Q2_2_c,Q3_3_a,Q3_3_b,Q3_3_c,Q4_4_a,Q4_4_b,Q4_4_c,Q5_5_a,Q5_5_b,Q5_5_c,Q6_5_a,Q6_5_b,Q6_5_c,Q7_5_a,Q7_5_b,Q7_5_c,Q8_5_a,Q8_5_b,Q8_5_c,Q4_1,Q4_1_a,Q4_2,Q4_2_a,Q4_3,Q4_3_a,Q4_4,Q4_4_aa,Q4_5,Q4_5_aa,Q4_6,Q4_6_a,Q4_7,Q4_7_a,Q4_8,Q4_8_a,Q5,Q5_1,Q6_a_1,Q6_a_2,Q6_a_3,Q6_a_4,Q6_a_5,Q6_b_1,Q6_b_2,Q6_b_3,Q6_b_4,Q6_b_5,Q6_c_1,Q6_c_2,Q6_c_3,Q6_c_4,Q6_c_5,Q6_d_1,Q6_d_2,Q6_d_3,Q6_d_4,Q6_d_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMMTOTO fKMMTOTO)
        {
            if (id != fKMMTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fKMMTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FKMMTOTOExists(fKMMTOTO.ID))
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
            return View(fKMMTOTO);
        }

        // GET: FKMMTOTOMBILI/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMTOTO = await _context.FKMMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMMTOTO == null)
            {
                return NotFound();
            }

            return View(fKMMTOTO);
        }

        // POST: FKMMTOTOMBILI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fKMMTOTO = await _context.FKMMTOTO.FindAsync(id);
            _context.FKMMTOTO.Remove(fKMMTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FKMMTOTOExists(int id)
        {
            return _context.FKMMTOTO.Any(e => e.ID == id);
        }
        public async Task<ActionResult> Fkmbili()
        {
            List<FKMMTOTO> fKMMTOTO = new List<FKMMTOTO>();
            fKMMTOTO = await _context.FKMMTOTO.ToListAsync();
            using (var workbook = new XLWorkbook())
            {

                var worksheet = workbook.Worksheets.Add("fKMMTOTO");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Tarehe";
                worksheet.Cell(currentRow, 4).Value = "SexMt";
                worksheet.Cell(currentRow, 5).Value = "TareheKuzaliwa";
                worksheet.Cell(currentRow, 6).Value = "UmriMtotoMiezi";
                worksheet.Cell(currentRow, 7).Value = "Q1";
                worksheet.Cell(currentRow, 8).Value = "Q2";
                worksheet.Cell(currentRow, 9).Value = "Q3";
                worksheet.Cell(currentRow, 10).Value = "Q1_1_a";
                worksheet.Cell(currentRow, 11).Value = "Q1_1_b";
                worksheet.Cell(currentRow, 12).Value = "Q1_1_c";
                worksheet.Cell(currentRow, 13).Value = "Q2_2_a";
                worksheet.Cell(currentRow, 14).Value = "Q2_2_b";
                worksheet.Cell(currentRow, 15).Value = "Q2_2_c";
                worksheet.Cell(currentRow, 17).Value = "Q3_3_a";
                worksheet.Cell(currentRow, 18).Value = "Q3_3_b";
                worksheet.Cell(currentRow, 19).Value = "Q3_3_c";
                worksheet.Cell(currentRow, 21).Value = "Q4_4_a";
                worksheet.Cell(currentRow, 22).Value = "Q4_4_b";
                worksheet.Cell(currentRow, 23).Value = "Q4_4_c";
                worksheet.Cell(currentRow, 24).Value = "Q5_5_a";
                worksheet.Cell(currentRow, 25).Value = "Q5_5_b";
                worksheet.Cell(currentRow, 26).Value = "Q5_5_c";
                worksheet.Cell(currentRow, 27).Value = "Q6_5_a";
                worksheet.Cell(currentRow, 28).Value = "Q6_5_b";
                worksheet.Cell(currentRow, 29).Value = "Q6_5_c";
                worksheet.Cell(currentRow, 30).Value = "Q7_5_a";
                worksheet.Cell(currentRow, 31).Value = "Q7_5_b";
                worksheet.Cell(currentRow, 32).Value = "Q7_5_c";
                worksheet.Cell(currentRow, 33).Value = "Q8_5_a";
                worksheet.Cell(currentRow, 34).Value = "Q8_5_b";
                worksheet.Cell(currentRow, 35).Value = "Q8_5_c";
                worksheet.Cell(currentRow, 36).Value = "Q4_1";
                worksheet.Cell(currentRow, 37).Value = "Q4_1_a";
                worksheet.Cell(currentRow, 38).Value = "Q4_2";
                worksheet.Cell(currentRow, 39).Value = "Q4_2_a";
                worksheet.Cell(currentRow, 40).Value = "Q4_3";
                worksheet.Cell(currentRow, 41).Value = "Q4_3_a";
                worksheet.Cell(currentRow, 42).Value = "Q4_4";
                worksheet.Cell(currentRow, 43).Value = "Q4_4_aa";
                worksheet.Cell(currentRow, 44).Value = "Q4_5";
                worksheet.Cell(currentRow, 45).Value = "Q4_5_aa";
                worksheet.Cell(currentRow, 46).Value = "Q4_6";
                worksheet.Cell(currentRow, 47).Value = "Q4_6_a";
                worksheet.Cell(currentRow, 48).Value = "Q4_7";
                worksheet.Cell(currentRow, 49).Value = "Q4_7_a";
                worksheet.Cell(currentRow, 50).Value = "Q4_8";
                worksheet.Cell(currentRow, 51).Value = "Q4_8_a";
                worksheet.Cell(currentRow, 52).Value = "Q5";
                worksheet.Cell(currentRow, 53).Value = "Q5_1";
                worksheet.Cell(currentRow, 54).Value = "Q6_a_1";
                worksheet.Cell(currentRow, 55).Value = "Q6_a_2";
                worksheet.Cell(currentRow, 56).Value = "Q6_a_3";
                worksheet.Cell(currentRow, 57).Value = "Q6_a_4";
                worksheet.Cell(currentRow, 58).Value = "Q6_a_5";
                worksheet.Cell(currentRow, 59).Value = "Q6_b_1";
                worksheet.Cell(currentRow, 60).Value = "Q6_b_2";
                worksheet.Cell(currentRow, 61).Value = "Q6_b_3";
                worksheet.Cell(currentRow, 62).Value = "Q6_b_4";
                worksheet.Cell(currentRow, 63).Value = "Q6_b_5";
                worksheet.Cell(currentRow, 64).Value = "Q6_c_1";
                worksheet.Cell(currentRow, 65).Value = "Q6_c_2";
                worksheet.Cell(currentRow, 66).Value = "Q6_c_3";
                worksheet.Cell(currentRow, 67).Value = "Q6_c_4";
                worksheet.Cell(currentRow, 68).Value = "Q6_c_5";
                worksheet.Cell(currentRow, 69).Value = "Q6_d_1";
                worksheet.Cell(currentRow, 70).Value = "Q6_d_2";
                worksheet.Cell(currentRow, 71).Value = "Q6_d_3";
                worksheet.Cell(currentRow, 72).Value = "Q6_d_4";
                worksheet.Cell(currentRow, 73).Value = "Q6_d_5";
                worksheet.Cell(currentRow, 74).Value = "Q10_a";
                worksheet.Cell(currentRow, 75).Value = "Q10_b";
                worksheet.Cell(currentRow, 76).Value = "Q10_c";
                worksheet.Cell(currentRow, 77).Value = "Q10_d";
                worksheet.Cell(currentRow, 78).Value = "Q10_e";
                worksheet.Cell(currentRow, 79).Value = "Q11_a";
                worksheet.Cell(currentRow, 80).Value = "Q11_b";
                worksheet.Cell(currentRow, 81).Value = "Q11_c";
                worksheet.Cell(currentRow, 82).Value = "Q12_a";
                worksheet.Cell(currentRow, 83).Value = "Q12_b";
                worksheet.Cell(currentRow, 84).Value = "Q12_c";
                worksheet.Cell(currentRow, 85).Value = "Q13_a";
                worksheet.Cell(currentRow, 86).Value = "Q13_b";
                worksheet.Cell(currentRow, 88).Value = "Q13_d";
                worksheet.Cell(currentRow, 89).Value = "Q13_e";
                worksheet.Cell(currentRow, 90).Value = "Q13_f";
                worksheet.Cell(currentRow, 91).Value = "Q14_a";
                worksheet.Cell(currentRow, 92).Value = "Q14_b";
                worksheet.Cell(currentRow, 93).Value = "Q14_c";
                worksheet.Cell(currentRow, 94).Value = "Q14_d";
                worksheet.Cell(currentRow, 95).Value = "Q14_e";
                worksheet.Cell(currentRow, 96).Value = "Q14_f";
                worksheet.Cell(currentRow, 97).Value = "Q14_g";
                worksheet.Cell(currentRow, 98).Value = "Q15_a";
                worksheet.Cell(currentRow, 99).Value = "Q15_b";
                worksheet.Cell(currentRow, 100).Value = "Q15_c";
                worksheet.Cell(currentRow, 101).Value = "Q15_d";
                worksheet.Cell(currentRow, 102).Value = "Q15_e";
                worksheet.Cell(currentRow, 103).Value = "Q15_f";
                worksheet.Cell(currentRow, 104).Value = "Q15_g";
                worksheet.Cell(currentRow, 105).Value = "Q15_h";
                worksheet.Cell(currentRow, 106).Value = "Q16_a";
                worksheet.Cell(currentRow, 107).Value = "Q16_b";
                worksheet.Cell(currentRow, 108).Value = "Q16_c";
                worksheet.Cell(currentRow, 109).Value = "Q17_a";
                worksheet.Cell(currentRow, 110).Value = "Q17_b";
                worksheet.Cell(currentRow, 111).Value = "Q17_c";
                worksheet.Cell(currentRow, 112).Value = "ProblemsDsis";
                worksheet.Cell(currentRow, 113).Value = "MedicationPres";
                worksheet.Cell(currentRow, 114).Value = "Date6Month";
                worksheet.Cell(currentRow, 115).Value = "CreatedDate";

                foreach (var item in fKMMTOTO)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Tarehe;
                    worksheet.Cell(currentRow, 4).Value = item.SexMt;
                    worksheet.Cell(currentRow, 5).Value = item.TareheKuzaliwa;
                    worksheet.Cell(currentRow, 6).Value = item.UmriMtotoMiezi;
                    worksheet.Cell(currentRow, 7).Value = item.Q1;
                    worksheet.Cell(currentRow, 8).Value = item.Q2;
                    worksheet.Cell(currentRow, 9).Value = item.Q3;
                    worksheet.Cell(currentRow, 10).Value = item.Q1_1_a;
                    worksheet.Cell(currentRow, 11).Value = item.Q1_1_b;
                    worksheet.Cell(currentRow, 12).Value = item.Q1_1_c;
                    worksheet.Cell(currentRow, 13).Value = item.Q2_2_a;
                    worksheet.Cell(currentRow, 14).Value = item.Q2_2_b;
                    worksheet.Cell(currentRow, 15).Value = item.Q2_2_c;
                    worksheet.Cell(currentRow, 17).Value = item.Q3_3_a;
                    worksheet.Cell(currentRow, 18).Value = item.Q3_3_b;
                    worksheet.Cell(currentRow, 19).Value = item.Q3_3_c;
                    worksheet.Cell(currentRow, 21).Value = item.Q4_4_a;
                    worksheet.Cell(currentRow, 22).Value = item.Q4_4_b;
                    worksheet.Cell(currentRow, 23).Value = item.Q4_4_c;
                    worksheet.Cell(currentRow, 24).Value = item.Q5_5_a;
                    worksheet.Cell(currentRow, 25).Value = item.Q5_5_b;
                    worksheet.Cell(currentRow, 26).Value = item.Q5_5_c;
                    worksheet.Cell(currentRow, 27).Value = item.Q6_5_a;
                    worksheet.Cell(currentRow, 28).Value = item.Q6_5_b;
                    worksheet.Cell(currentRow, 29).Value = item.Q6_5_c;
                    worksheet.Cell(currentRow, 30).Value = item.Q7_5_a;
                    worksheet.Cell(currentRow, 31).Value = item.Q7_5_b;
                    worksheet.Cell(currentRow, 32).Value = item.Q7_5_c;
                    worksheet.Cell(currentRow, 33).Value = item.Q8_5_a;
                    worksheet.Cell(currentRow, 34).Value = item.Q8_5_b;
                    worksheet.Cell(currentRow, 35).Value = item.Q8_5_c;
                    worksheet.Cell(currentRow, 36).Value = item.Q4_1;
                    worksheet.Cell(currentRow, 37).Value = item.Q4_1_a;
                    worksheet.Cell(currentRow, 38).Value = item.Q4_2;
                    worksheet.Cell(currentRow, 39).Value = item.Q4_2_a;
                    worksheet.Cell(currentRow, 40).Value = item.Q4_3;
                    worksheet.Cell(currentRow, 41).Value = item.Q4_3_a;
                    worksheet.Cell(currentRow, 42).Value = item.Q4_4;
                    worksheet.Cell(currentRow, 43).Value = item.Q4_4_aa;
                    worksheet.Cell(currentRow, 44).Value = item.Q4_5;
                    worksheet.Cell(currentRow, 45).Value = item.Q4_5_aa;
                    worksheet.Cell(currentRow, 46).Value = item.Q4_6;
                    worksheet.Cell(currentRow, 47).Value = item.Q4_6_a;
                    worksheet.Cell(currentRow, 48).Value = item.Q4_7;
                    worksheet.Cell(currentRow, 49).Value = item.Q4_7_a;
                    worksheet.Cell(currentRow, 50).Value = item.Q4_8;
                    worksheet.Cell(currentRow, 51).Value = item.Q4_8_a;
                    worksheet.Cell(currentRow, 52).Value = item.Q5;
                    worksheet.Cell(currentRow, 53).Value = item.Q5_1;
                    worksheet.Cell(currentRow, 54).Value = item.Q6_a_1;
                    worksheet.Cell(currentRow, 55).Value = item.Q6_a_2;
                    worksheet.Cell(currentRow, 56).Value = item.Q6_a_3;
                    worksheet.Cell(currentRow, 57).Value = item.Q6_a_4;
                    worksheet.Cell(currentRow, 58).Value = item.Q6_a_5;
                    worksheet.Cell(currentRow, 59).Value = item.Q6_b_1;
                    worksheet.Cell(currentRow, 60).Value = item.Q6_b_2;
                    worksheet.Cell(currentRow, 61).Value = item.Q6_b_3;
                    worksheet.Cell(currentRow, 62).Value = item.Q6_b_4;
                    worksheet.Cell(currentRow, 63).Value = item.Q6_b_5;
                    worksheet.Cell(currentRow, 64).Value = item.Q6_c_1;
                    worksheet.Cell(currentRow, 65).Value = item.Q6_c_2;
                    worksheet.Cell(currentRow, 66).Value = item.Q6_c_3;
                    worksheet.Cell(currentRow, 67).Value = item.Q6_c_4;
                    worksheet.Cell(currentRow, 68).Value = item.Q6_c_5;
                    worksheet.Cell(currentRow, 69).Value = item.Q6_d_1;
                    worksheet.Cell(currentRow, 70).Value = item.Q6_d_2;
                    worksheet.Cell(currentRow, 71).Value = item.Q6_d_3;
                    worksheet.Cell(currentRow, 72).Value = item.Q6_d_4;
                    worksheet.Cell(currentRow, 73).Value = item.Q6_d_5;
                    worksheet.Cell(currentRow, 74).Value = item.Q10_a;
                    worksheet.Cell(currentRow, 75).Value = item.Q10_b;
                    worksheet.Cell(currentRow, 76).Value = item.Q10_c;
                    worksheet.Cell(currentRow, 77).Value = item.Q10_d;
                    worksheet.Cell(currentRow, 78).Value = item.Q10_e;
                    worksheet.Cell(currentRow, 79).Value = item.Q11_a;
                    worksheet.Cell(currentRow, 80).Value = item.Q11_b;
                    worksheet.Cell(currentRow, 81).Value = item.Q11_c;
                    worksheet.Cell(currentRow, 82).Value = item.Q12_a;
                    worksheet.Cell(currentRow, 83).Value = item.Q12_b;
                    worksheet.Cell(currentRow, 84).Value = item.Q12_c;
                    worksheet.Cell(currentRow, 85).Value = item.Q13_a;
                    worksheet.Cell(currentRow, 86).Value = item.Q13_b;
                    worksheet.Cell(currentRow, 87).Value = item.Q13_c;
                    worksheet.Cell(currentRow, 88).Value = item.Q13_d;
                    worksheet.Cell(currentRow, 89).Value = item.Q13_e;
                    worksheet.Cell(currentRow, 90).Value = item.Q13_f;
                    worksheet.Cell(currentRow, 91).Value = item.Q14_a;
                    worksheet.Cell(currentRow, 92).Value = item.Q14_b;
                    worksheet.Cell(currentRow, 93).Value = item.Q14_c;
                    worksheet.Cell(currentRow, 94).Value = item.Q14_d;
                    worksheet.Cell(currentRow, 95).Value = item.Q14_e;
                    worksheet.Cell(currentRow, 96).Value = item.Q14_f;
                    worksheet.Cell(currentRow, 97).Value = item.Q14_g;
                    worksheet.Cell(currentRow, 98).Value = item.Q15_a;
                    worksheet.Cell(currentRow, 99).Value = item.Q15_b;
                    worksheet.Cell(currentRow, 100).Value = item.Q15_c;
                    worksheet.Cell(currentRow, 101).Value = item.Q15_d;
                    worksheet.Cell(currentRow, 102).Value = item.Q15_e;
                    worksheet.Cell(currentRow, 103).Value = item.Q15_f;
                    worksheet.Cell(currentRow, 104).Value = item.Q15_g;
                    worksheet.Cell(currentRow, 105).Value = item.Q15_h;
                    worksheet.Cell(currentRow, 106).Value = item.Q16_a;
                    worksheet.Cell(currentRow, 107).Value = item.Q16_b;
                    worksheet.Cell(currentRow, 108).Value = item.Q16_c;
                    worksheet.Cell(currentRow, 109).Value = item.Q17_a;
                    worksheet.Cell(currentRow, 110).Value = item.Q17_b;
                    worksheet.Cell(currentRow, 111).Value = item.Q17_c;
                    worksheet.Cell(currentRow, 112).Value = item.ProblemsDsis;
                    worksheet.Cell(currentRow, 113).Value = item.MedicationPres;
                    worksheet.Cell(currentRow, 114).Value = item.Date6Month;
                    worksheet.Cell(currentRow, 115).Value = item.CreatedDate;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomukuminambili.xlsx");
                }
            }
        }
    }
}
