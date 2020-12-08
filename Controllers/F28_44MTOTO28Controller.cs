using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BHAMCApp.Data;
using BHAMCApp.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using BHAMCApp.Services;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using ClosedXML.Excel;

namespace BHAMCApp.Controllers
{
    [Authorize(Roles = "admin,Datamanager")]
    public class F28_44MTOTO28Controller : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public F28_44MTOTO28Controller(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: F28_44MTOTO28
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");

            if (isAdmin)
            {
                return View(await _context.F28_44MTOTO.ToListAsync());
            }
            else
            {
                return View(await _context.F28_44MTOTO.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.F28_44MTOTO.ToListAsync());
        }

        // GET: F28_44MTOTO28/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f28_44MTOTO = await _context.F28_44MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f28_44MTOTO == null)
            {
                return NotFound();
            }

            return View(f28_44MTOTO);
        }

        // GET: F28_44MTOTO28/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F28_44MTOTO28/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,M1,M3,M6,M9,M12,M15,M18,M24,M28,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q4_1,Q5,Q5_1,Q6,Q6_1,Q6_2,Q7,Q8,Q9_1,Q9_2,Q9_3,Q9_4,Q9_5,Q10_1_a,Q10_1_b,Q10_1_c,Q10_1_d,Q10_1_e,Q10_1_f,Q10_1_g,Q10_1_h,Q10_1_i,Q10_2_a,Q10_2_b,Q10_2_c,Q10_2_d,Q10_3_a,Q10_3_b,Q10_3_c,Q10_3_d,Q10_3_e,Q10_3_f,Q10_3_g,Q10_3_h,Q10_3_i,Q10_4_a,Q10_4_b,Q10_4_c,Q10_4_d,Q10_5_a,Q10_5_b,Q10_5_c,Q10_5_d,Q10_5_e,Q10_5_f,Q10_5_g,Q10_5_h,Q10_5_i,Q11,Q11_1,Q12,Q13,Q13_1,Q14,Q15,Q15_1,Q16,Q17_a_1,Q17_a_2,Q17_a_3,Q17_a_4,Q17_a_5,Q17_b_1,Q17_b_2,Q17_b_3,Q17_b_4,Q17_b_5,Q17_c_1,Q17_c_2,Q17_c_3,Q17_c_4,Q17_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q16_a,Q17_a,ProblemsDsis,MedicationPres,DateVisit32,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F28_44MTOTO f28_44MTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f28_44MTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f28_44MTOTO);
        }

        // GET: F28_44MTOTO28/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f28_44MTOTO = await _context.F28_44MTOTO.FindAsync(id);
            if (f28_44MTOTO == null)
            {
                return NotFound();
            }
            return View(f28_44MTOTO);
        }

        // POST: F28_44MTOTO28/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi," +
            "M1,M3,M6,M9,M12,M15,M18,M24,M28,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q4_1,Q5,Q5_1,Q6,Q6_1,Q6_2,Q7,Q8,Q9_1,Q9_2,Q9_3," +
            "Q9_4,Q9_5,Q10_1_a,Q10_1_b,Q10_1_c,Q10_1_d,Q10_1_e,Q10_1_f,Q10_1_g,Q10_1_h,Q10_1_i,Q10_2_a,Q10_2_b," +
            "Q10_2_c,Q10_2_d,Q10_3_a,Q10_3_b,Q10_3_c,Q10_3_d,Q10_3_e,Q10_3_f,Q10_3_g,Q10_3_h,Q10_3_i,Q10_4_a," +
            "Q10_4_b,Q10_4_c,Q10_4_d,Q10_5_a,Q10_5_b,Q10_5_c,Q10_5_d,Q10_5_e,Q10_5_f,Q10_5_g,Q10_5_h,Q10_5_i," +
            "Q11,Q11_1,Q12,Q13,Q13_1,Q14,Q15,Q15_1,Q16,Q17_a_1,Q17_a_2,Q17_a_3,Q17_a_4,Q17_a_5,Q17_b_1,Q17_b_2," +
            "Q17_b_3,Q17_b_4,Q17_b_5,Q17_c_1,Q17_c_2,Q17_c_3,Q17_c_4,Q17_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a," +
            "Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f," +
            "Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q16_a,Q17_a,ProblemsDsis,MedicationPres,DateVisit32,ID,CreatedByUser," +
            "CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F28_44MTOTO f28_44MTOTO)
        {
            if (id != f28_44MTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f28_44MTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F28_44MTOTOExists(f28_44MTOTO.ID))
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
            return View(f28_44MTOTO);
        }

        // GET: F28_44MTOTO28/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f28_44MTOTO = await _context.F28_44MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f28_44MTOTO == null)
            {
                return NotFound();
            }

            return View(f28_44MTOTO);
        }

        // POST: F28_44MTOTO28/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f28_44MTOTO = await _context.F28_44MTOTO.FindAsync(id);
            _context.F28_44MTOTO.Remove(f28_44MTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F28_44MTOTOExists(int id)
        {
            return _context.F28_44MTOTO.Any(e => e.ID == id);
        }
        public async Task<ActionResult> F28_44()
        {
            List<F28_44MTOTO> f28_44MTOTO = new List<F28_44MTOTO>();
            f28_44MTOTO = await _context.F28_44MTOTO.ToListAsync();
            using (var workbook = new XLWorkbook())
            {

                var worksheet = workbook.Worksheets.Add("f28_44MTOTO");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Tarehe";
                worksheet.Cell(currentRow, 4).Value = "SexMt";
                worksheet.Cell(currentRow, 5).Value = "TareheKuzaliwa";
                worksheet.Cell(currentRow, 6).Value = "UmriMtotoMiezi";
                worksheet.Cell(currentRow, 7).Value = "M1";
                worksheet.Cell(currentRow, 8).Value = "M3";
                worksheet.Cell(currentRow, 9).Value = "M6";
                worksheet.Cell(currentRow, 10).Value = "M9";
                worksheet.Cell(currentRow, 11).Value = "M12";
                worksheet.Cell(currentRow, 12).Value = "M15";
                worksheet.Cell(currentRow, 13).Value = "M18";
                worksheet.Cell(currentRow, 14).Value = "M24";
                worksheet.Cell(currentRow, 15).Value = "M28";
                worksheet.Cell(currentRow, 16).Value = "Q1";
                worksheet.Cell(currentRow, 17).Value = "Q1_1";
                worksheet.Cell(currentRow, 18).Value = "Q2";
                worksheet.Cell(currentRow, 19).Value = "Q3";
                worksheet.Cell(currentRow, 20).Value = "Q3_1";
                worksheet.Cell(currentRow, 21).Value = "Q4";
                worksheet.Cell(currentRow, 22).Value = "Q4_1";
                worksheet.Cell(currentRow, 23).Value = "Q5";
                worksheet.Cell(currentRow, 24).Value = "Q5_1";
                worksheet.Cell(currentRow, 25).Value = "Q6";
                worksheet.Cell(currentRow, 26).Value = "Q6_1";
                worksheet.Cell(currentRow, 27).Value = "Q6_2";
                worksheet.Cell(currentRow, 28).Value = "Q7";
                worksheet.Cell(currentRow, 29).Value = "Q8";
                worksheet.Cell(currentRow, 30).Value = "Q9_1";
                worksheet.Cell(currentRow, 31).Value = "Q9_2";
                worksheet.Cell(currentRow, 32).Value = "Q9_3";
                worksheet.Cell(currentRow, 33).Value = "Q9_4";
                worksheet.Cell(currentRow, 34).Value = "Q9_5";
                worksheet.Cell(currentRow, 35).Value = "Q10_1_a";
                worksheet.Cell(currentRow, 36).Value = "Q10_1_b";
                worksheet.Cell(currentRow, 37).Value = "Q10_1_c";
                worksheet.Cell(currentRow, 38).Value = "Q10_1_d";
                worksheet.Cell(currentRow, 39).Value = "Q10_1_e";
                worksheet.Cell(currentRow, 40).Value = "Q10_1_f";
                worksheet.Cell(currentRow, 41).Value = "Q10_1_g";
                worksheet.Cell(currentRow, 42).Value = "Q10_1_h";
                worksheet.Cell(currentRow, 43).Value = "Q10_1_i";
                worksheet.Cell(currentRow, 44).Value = "Q10_2_a";
                worksheet.Cell(currentRow, 45).Value = "Q10_2_b";
                worksheet.Cell(currentRow, 46).Value = "Q10_2_c";
                worksheet.Cell(currentRow, 47).Value = "Q10_2_d";
                worksheet.Cell(currentRow, 48).Value = "Q10_3_a";
                worksheet.Cell(currentRow, 49).Value = "Q10_3_b";
                worksheet.Cell(currentRow, 50).Value = "Q10_3_c";
                worksheet.Cell(currentRow, 51).Value = "Q10_3_d";
                worksheet.Cell(currentRow, 52).Value = "Q10_3_e";
                worksheet.Cell(currentRow, 53).Value = "Q10_3_f";
                worksheet.Cell(currentRow, 54).Value = "Q10_3_g";
                worksheet.Cell(currentRow, 55).Value = "Q10_3_h";
                worksheet.Cell(currentRow, 56).Value = "Q10_3_i";
                worksheet.Cell(currentRow, 57).Value = "Q10_4_a";
                worksheet.Cell(currentRow, 58).Value = "Q10_4_b";
                worksheet.Cell(currentRow, 59).Value = "Q10_4_c";
                worksheet.Cell(currentRow, 60).Value = "Q10_4_d";
                worksheet.Cell(currentRow, 61).Value = "Q10_5_a";
                worksheet.Cell(currentRow, 62).Value = "Q10_5_b";
                worksheet.Cell(currentRow, 63).Value = "Q10_5_c";
                worksheet.Cell(currentRow, 64).Value = "Q10_5_d";
                worksheet.Cell(currentRow, 65).Value = "Q10_5_e";
                worksheet.Cell(currentRow, 66).Value = "Q10_5_f";
                worksheet.Cell(currentRow, 67).Value = "Q10_5_g";
                worksheet.Cell(currentRow, 68).Value = "Q10_5_h";
                worksheet.Cell(currentRow, 69).Value = "Q10_5_i";
                worksheet.Cell(currentRow, 70).Value = "Q11";
                worksheet.Cell(currentRow, 71).Value = "Q11_1";
                worksheet.Cell(currentRow, 72).Value = "Q12";
                worksheet.Cell(currentRow, 73).Value = "Q13";
                worksheet.Cell(currentRow, 74).Value = "Q13_1";
                worksheet.Cell(currentRow, 75).Value = "Q14";
                worksheet.Cell(currentRow, 76).Value = "Q15";
                worksheet.Cell(currentRow, 77).Value = "Q15_1";
                worksheet.Cell(currentRow, 78).Value = "Q16";
                worksheet.Cell(currentRow, 79).Value = "Q17_a_1";
                worksheet.Cell(currentRow, 80).Value = "Q17_a_2";
                worksheet.Cell(currentRow, 81).Value = "Q17_a_3";
                worksheet.Cell(currentRow, 82).Value = "Q17_a_4";
                worksheet.Cell(currentRow, 83).Value = "Q17_a_5";
                worksheet.Cell(currentRow, 84).Value = "Q17_b_1";
                worksheet.Cell(currentRow, 85).Value = "Q17_b_2";
                worksheet.Cell(currentRow, 86).Value = "Q17_b_3";
                worksheet.Cell(currentRow, 87).Value = "Q17_b_4";
                worksheet.Cell(currentRow, 88).Value = "Q17_b_5";
                worksheet.Cell(currentRow, 89).Value = "Q17_c_1";
                worksheet.Cell(currentRow, 90).Value = "Q17_c_2";
                worksheet.Cell(currentRow, 91).Value = "Q17_c_3";
                worksheet.Cell(currentRow, 92).Value = "Q17_c_4";
                worksheet.Cell(currentRow, 93).Value = "Q17_c_5";
                worksheet.Cell(currentRow, 94).Value = "Q10_a";
                worksheet.Cell(currentRow, 95).Value = "Q10_b";
                worksheet.Cell(currentRow, 96).Value = "Q10_c";
                worksheet.Cell(currentRow, 97).Value = "Q10_d";
                worksheet.Cell(currentRow, 98).Value = "Q10_e";
                worksheet.Cell(currentRow, 99).Value = "Q11_a";
                worksheet.Cell(currentRow, 100).Value = "Q11_b";
                worksheet.Cell(currentRow, 101).Value = "Q11_c";
                worksheet.Cell(currentRow, 102).Value = "Q12_a";
                worksheet.Cell(currentRow, 103).Value = "Q12_b";
                worksheet.Cell(currentRow, 104).Value = "Q12_c";
                worksheet.Cell(currentRow, 105).Value = "Q13_a";
                worksheet.Cell(currentRow, 106).Value = "Q13_b";
                worksheet.Cell(currentRow, 107).Value = "Q13_c";
                worksheet.Cell(currentRow, 108).Value = "Q13_d";
                worksheet.Cell(currentRow, 109).Value = "Q13_e";
                worksheet.Cell(currentRow, 110).Value = "Q13_f";
                worksheet.Cell(currentRow, 111).Value = "Q14_a";
                worksheet.Cell(currentRow, 112).Value = "Q14_b";
                worksheet.Cell(currentRow, 113).Value = "Q14_c";
                worksheet.Cell(currentRow, 114).Value = "Q14_d";
                worksheet.Cell(currentRow, 115).Value = "Q14_e";
                worksheet.Cell(currentRow, 116).Value = "Q14_f";
                worksheet.Cell(currentRow, 117).Value = "Q14_g";
                worksheet.Cell(currentRow, 118).Value = "Q15_a";
                worksheet.Cell(currentRow, 119).Value = "Q15_b";
                worksheet.Cell(currentRow, 120).Value = "Q15_c";
                worksheet.Cell(currentRow, 121).Value = "Q15_d";
                worksheet.Cell(currentRow, 122).Value = "Q16_a";
                worksheet.Cell(currentRow, 123).Value = "Q17_a";
                worksheet.Cell(currentRow, 124).Value = "ProblemsDsis";
                worksheet.Cell(currentRow, 125).Value = "MedicationPres";
                worksheet.Cell(currentRow, 126).Value = "DateVisit32";
                worksheet.Cell(currentRow, 127).Value = "CreatedDate";

                foreach (var item in f28_44MTOTO)
                {

                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Tarehe;
                    worksheet.Cell(currentRow, 4).Value = item.SexMt;
                    worksheet.Cell(currentRow, 5).Value = item.TareheKuzaliwa;
                    worksheet.Cell(currentRow, 6).Value = item.UmriMtotoMiezi;
                    worksheet.Cell(currentRow, 7).Value = item.M1;
                    worksheet.Cell(currentRow, 8).Value = item.M3;
                    worksheet.Cell(currentRow, 9).Value = item.M6;
                    worksheet.Cell(currentRow, 10).Value = item.M9;
                    worksheet.Cell(currentRow, 11).Value = item.M12;
                    worksheet.Cell(currentRow, 12).Value = item.M15;
                    worksheet.Cell(currentRow, 13).Value = item.M18;
                    worksheet.Cell(currentRow, 14).Value = item.M24;
                    worksheet.Cell(currentRow, 15).Value = item.M28;
                    worksheet.Cell(currentRow, 16).Value = item.Q1;
                    worksheet.Cell(currentRow, 17).Value = item.Q1_1;
                    worksheet.Cell(currentRow, 18).Value = item.Q2;
                    worksheet.Cell(currentRow, 19).Value = item.Q3;
                    worksheet.Cell(currentRow, 20).Value = item.Q3_1;
                    worksheet.Cell(currentRow, 21).Value = item.Q4;
                    worksheet.Cell(currentRow, 22).Value = item.Q4_1;
                    worksheet.Cell(currentRow, 23).Value = item.Q5;
                    worksheet.Cell(currentRow, 24).Value = item.Q5_1;
                    worksheet.Cell(currentRow, 25).Value = item.Q6;
                    worksheet.Cell(currentRow, 26).Value = item.Q6_1;
                    worksheet.Cell(currentRow, 27).Value = item.Q6_2;
                    worksheet.Cell(currentRow, 28).Value = item.Q7;
                    worksheet.Cell(currentRow, 29).Value = item.Q8;
                    worksheet.Cell(currentRow, 30).Value = item.Q9_1;
                    worksheet.Cell(currentRow, 31).Value = item.Q9_2;
                    worksheet.Cell(currentRow, 32).Value = item.Q9_3;
                    worksheet.Cell(currentRow, 33).Value = item.Q9_4;
                    worksheet.Cell(currentRow, 34).Value = item.Q9_5;
                    worksheet.Cell(currentRow, 35).Value = item.Q10_1_a;
                    worksheet.Cell(currentRow, 36).Value = item.Q10_1_b;
                    worksheet.Cell(currentRow, 37).Value = item.Q10_1_c;
                    worksheet.Cell(currentRow, 38).Value = item.Q10_1_d;
                    worksheet.Cell(currentRow, 39).Value = item.Q10_1_e;
                    worksheet.Cell(currentRow, 40).Value = item.Q10_1_f;
                    worksheet.Cell(currentRow, 41).Value = item.Q10_1_g;
                    worksheet.Cell(currentRow, 42).Value = item.Q10_1_h;
                    worksheet.Cell(currentRow, 43).Value = item.Q10_1_i;
                    worksheet.Cell(currentRow, 44).Value = item.Q10_2_a;
                    worksheet.Cell(currentRow, 45).Value = item.Q10_2_b;
                    worksheet.Cell(currentRow, 46).Value = item.Q10_2_c;
                    worksheet.Cell(currentRow, 47).Value = item.Q10_2_d;
                    worksheet.Cell(currentRow, 48).Value = item.Q10_3_a;
                    worksheet.Cell(currentRow, 49).Value = item.Q10_3_b;
                    worksheet.Cell(currentRow, 50).Value = item.Q10_3_c;
                    worksheet.Cell(currentRow, 51).Value = item.Q10_3_d;
                    worksheet.Cell(currentRow, 52).Value = item.Q10_3_e;
                    worksheet.Cell(currentRow, 53).Value = item.Q10_3_f;
                    worksheet.Cell(currentRow, 54).Value = item.Q10_3_g;
                    worksheet.Cell(currentRow, 55).Value = item.Q10_3_h;
                    worksheet.Cell(currentRow, 56).Value = item.Q10_3_i;
                    worksheet.Cell(currentRow, 57).Value = item.Q10_4_a;
                    worksheet.Cell(currentRow, 58).Value = item.Q10_4_b;
                    worksheet.Cell(currentRow, 59).Value = item.Q10_4_c;
                    worksheet.Cell(currentRow, 60).Value = item.Q10_4_d;
                    worksheet.Cell(currentRow, 61).Value = item.Q10_5_a;
                    worksheet.Cell(currentRow, 62).Value = item.Q10_5_b;
                    worksheet.Cell(currentRow, 63).Value = item.Q10_5_c;
                    worksheet.Cell(currentRow, 64).Value = item.Q10_5_d;
                    worksheet.Cell(currentRow, 65).Value = item.Q10_5_e;
                    worksheet.Cell(currentRow, 66).Value = item.Q10_5_f;
                    worksheet.Cell(currentRow, 67).Value = item.Q10_5_g;
                    worksheet.Cell(currentRow, 68).Value = item.Q10_5_h;
                    worksheet.Cell(currentRow, 69).Value = item.Q10_5_i;
                    worksheet.Cell(currentRow, 70).Value = item.Q11;
                    worksheet.Cell(currentRow, 71).Value = item.Q11_1;
                    worksheet.Cell(currentRow, 72).Value = item.Q12;
                    worksheet.Cell(currentRow, 73).Value = item.Q13;
                    worksheet.Cell(currentRow, 74).Value = item.Q13_1;
                    worksheet.Cell(currentRow, 75).Value = item.Q14;
                    worksheet.Cell(currentRow, 76).Value = item.Q15;
                    worksheet.Cell(currentRow, 77).Value = item.Q15_1;
                    worksheet.Cell(currentRow, 78).Value = item.Q16;
                    worksheet.Cell(currentRow, 79).Value = item.Q17_a_1;
                    worksheet.Cell(currentRow, 80).Value = item.Q17_a_2;
                    worksheet.Cell(currentRow, 81).Value = item.Q17_a_3;
                    worksheet.Cell(currentRow, 82).Value = item.Q17_a_4;
                    worksheet.Cell(currentRow, 83).Value = item.Q17_a_5;
                    worksheet.Cell(currentRow, 84).Value = item.Q17_b_1;
                    worksheet.Cell(currentRow, 85).Value = item.Q17_b_2;
                    worksheet.Cell(currentRow, 86).Value = item.Q17_b_3;
                    worksheet.Cell(currentRow, 87).Value = item.Q17_b_4;
                    worksheet.Cell(currentRow, 88).Value = item.Q17_b_5;
                    worksheet.Cell(currentRow, 89).Value = item.Q17_c_1;
                    worksheet.Cell(currentRow, 90).Value = item.Q17_c_2;
                    worksheet.Cell(currentRow, 91).Value = item.Q17_c_3;
                    worksheet.Cell(currentRow, 92).Value = item.Q17_c_4;
                    worksheet.Cell(currentRow, 93).Value = item.Q17_c_5;
                    worksheet.Cell(currentRow, 94).Value = item.Q10_a;
                    worksheet.Cell(currentRow, 95).Value = item.Q10_b;
                    worksheet.Cell(currentRow, 96).Value = item.Q10_c;
                    worksheet.Cell(currentRow, 97).Value = item.Q10_d;
                    worksheet.Cell(currentRow, 98).Value = item.Q10_e;
                    worksheet.Cell(currentRow, 99).Value = item.Q11_a;
                    worksheet.Cell(currentRow, 100).Value = item.Q11_b;
                    worksheet.Cell(currentRow, 101).Value = item.Q11_c;
                    worksheet.Cell(currentRow, 102).Value = item.Q12_a;
                    worksheet.Cell(currentRow, 103).Value = item.Q12_b;
                    worksheet.Cell(currentRow, 104).Value = item.Q12_c;
                    worksheet.Cell(currentRow, 105).Value = item.Q13_a;
                    worksheet.Cell(currentRow, 106).Value = item.Q13_b;
                    worksheet.Cell(currentRow, 107).Value = item.Q13_c;
                    worksheet.Cell(currentRow, 108).Value = item.Q13_d;
                    worksheet.Cell(currentRow, 109).Value = item.Q13_e;
                    worksheet.Cell(currentRow, 110).Value = item.Q13_f;
                    worksheet.Cell(currentRow, 111).Value = item.Q14_a;
                    worksheet.Cell(currentRow, 112).Value = item.Q14_b;
                    worksheet.Cell(currentRow, 113).Value = item.Q14_c;
                    worksheet.Cell(currentRow, 114).Value = item.Q14_d;
                    worksheet.Cell(currentRow, 115).Value = item.Q14_e;
                    worksheet.Cell(currentRow, 116).Value = item.Q14_f;
                    worksheet.Cell(currentRow, 117).Value = item.Q14_g;
                    worksheet.Cell(currentRow, 118).Value = item.Q15_a;
                    worksheet.Cell(currentRow, 119).Value = item.Q15_b;
                    worksheet.Cell(currentRow, 120).Value = item.Q15_c;
                    worksheet.Cell(currentRow, 121).Value = item.Q15_d;
                    worksheet.Cell(currentRow, 122).Value = item.Q16_a;
                    worksheet.Cell(currentRow, 123).Value = item.Q17_a;
                    worksheet.Cell(currentRow, 124).Value = item.ProblemsDsis;
                    worksheet.Cell(currentRow, 125).Value = item.MedicationPres;
                    worksheet.Cell(currentRow, 126).Value = item.DateVisit32;
                    worksheet.Cell(currentRow, 127).Value = item.CreatedDate;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu28_44.xlsx");
                }
            }
        }
    }
}
