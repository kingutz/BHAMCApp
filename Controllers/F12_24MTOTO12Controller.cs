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
    public class F12_24MTOTO12Controller : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public F12_24MTOTO12Controller(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: F12_24MTOTO12
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");

            if (isAdmin)
            {
                return View(await _context.F12_24MTOTO.ToListAsync());
            }
            else
            {
                return View(await _context.F12_24MTOTO.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.F12_24MTOTO.ToListAsync());
        }

        // GET: F12_24MTOTO12/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f12_24MTOTO = await _context.F12_24MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f12_24MTOTO == null)
            {
                return NotFound();
            }

            return View(f12_24MTOTO);
        }

        // GET: F12_24MTOTO12/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F12_24MTOTO12/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2," +
            "Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q9_1_a,Q9_1_b,Q9_1_c,Q9_1_d,Q9_1_e,Q9_1_f,Q9_2_a,Q9_2_b,Q9_2_c,Q9_2_d,Q9_2_e," +
            "Q9_2_f,Q9_3_a,Q9_3_b,Q9_3_c,Q9_3_d,Q9_3_e,Q9_3_f,Q9_4_a,Q9_4_b,Q9_4_c,Q9_4_d,Q9_4_e,Q9_4_f,Q9_5_a,Q9_5_b," +
            "Q9_5_c,Q9_5_d,Q9_5_e,Q9_5_f,Q9_6_a,Q9_6_b,Q9_6_c,Q9_6_d,Q9_6_e,Q9_6_f,Q9_7_a,Q9_7_b,Q9_7_c,Q9_7_d,Q9_7_e," +
            "Q9_7_f,Q9_8_a,Q9_8_b,Q9_8_c,Q9_8_d,Q9_8_e,Q9_8_f,Q9_9_a,Q9_9_b,Q9_9_c,Q9_9_d,Q9_9_e,Q9_9_f,Q9_10_a," +
            "Q9_10_b,Q9_10_c,Q9_10_d,Q9_10_e,Q9_10_f,Q9_11_a,Q9_11_b,Q9_11_c,Q9_11_d,Q9_11_e,Q9_11_f,Q9_12_a," +
            "Q9_12_b,Q9_12_c,Q9_12_d,Q9_12_e,Q9_12_f,Q9_13_a,Q9_13_b,Q9_13_c,Q9_13_d,Q9_13_e,Q9_13_f,Q10,Q10_1,Q11," +
            "Q11_1,Q12,Q12_1,Q13_1,Q13_2,Q13_3,Q13_4,Q13_5,Q13_6,Q13_7,Q13_8,Q14_1,Q14_2,Q14_3,Q14_4,Q14_5,Q14_6," +
            "Q14_7,Q14_8,Q14_9,Q14_10,Q15_a_1,Q15_a_2,Q15_a_3,Q15_a_4,Q15_a_5,Q15_b_1,Q15_b_2,Q15_b_3,Q15_b_4," +
            "Q15_b_5,Q15_c_1,Q15_c_2,Q15_c_3,Q15_c_4,Q15_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a," +
            "Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b," +
            "Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres," +
            "DateNext,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F12_24MTOTO f12_24MTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f12_24MTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f12_24MTOTO);
        }

        // GET: F12_24MTOTO12/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f12_24MTOTO = await _context.F12_24MTOTO.FindAsync(id);
            if (f12_24MTOTO == null)
            {
                return NotFound();
            }
            return View(f12_24MTOTO);
        }

        // POST: F12_24MTOTO12/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1," +
            "Q1_1,Q2,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q7,Q8,Q9_1_a,Q9_1_b,Q9_1_c,Q9_1_d,Q9_1_e,Q9_1_f,Q9_2_a,Q9_2_b,Q9_2_c," +
            "Q9_2_d,Q9_2_e,Q9_2_f,Q9_3_a,Q9_3_b,Q9_3_c,Q9_3_d,Q9_3_e,Q9_3_f,Q9_4_a,Q9_4_b,Q9_4_c,Q9_4_d,Q9_4_e," +
            "Q9_4_f,Q9_5_a,Q9_5_b,Q9_5_c,Q9_5_d,Q9_5_e,Q9_5_f,Q9_6_a,Q9_6_b,Q9_6_c,Q9_6_d,Q9_6_e,Q9_6_f,Q9_7_a," +
            "Q9_7_b,Q9_7_c,Q9_7_d,Q9_7_e,Q9_7_f,Q9_8_a,Q9_8_b,Q9_8_c,Q9_8_d,Q9_8_e,Q9_8_f,Q9_9_a,Q9_9_b,Q9_9_c," +
            "Q9_9_d,Q9_9_e,Q9_9_f,Q9_10_a,Q9_10_b,Q9_10_c,Q9_10_d,Q9_10_e,Q9_10_f,Q9_11_a,Q9_11_b,Q9_11_c,Q9_11_d," +
            "Q9_11_e,Q9_11_f,Q9_12_a,Q9_12_b,Q9_12_c,Q9_12_d,Q9_12_e,Q9_12_f,Q9_13_a,Q9_13_b,Q9_13_c,Q9_13_d," +
            "Q9_13_e,Q9_13_f,Q10,Q10_1,Q11,Q11_1,Q12,Q12_1,Q13_1,Q13_2,Q13_3,Q13_4,Q13_5,Q13_6,Q13_7,Q13_8,Q14_1," +
            "Q14_2,Q14_3,Q14_4,Q14_5,Q14_6,Q14_7,Q14_8,Q14_9,Q14_10,Q15_a_1,Q15_a_2,Q15_a_3,Q15_a_4,Q15_a_5,Q15_b_1," +
            "Q15_b_2,Q15_b_3,Q15_b_4,Q15_b_5,Q15_c_1,Q15_c_2,Q15_c_3,Q15_c_4,Q15_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e," +
            "Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e," +
            "Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c," +
            "ProblemsDsis,MedicationPres,DateNext,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F12_24MTOTO f12_24MTOTO)
        {
            if (id != f12_24MTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f12_24MTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F12_24MTOTOExists(f12_24MTOTO.ID))
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
            return View(f12_24MTOTO);
        }

        // GET: F12_24MTOTO12/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f12_24MTOTO = await _context.F12_24MTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f12_24MTOTO == null)
            {
                return NotFound();
            }

            return View(f12_24MTOTO);
        }

        // POST: F12_24MTOTO12/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f12_24MTOTO = await _context.F12_24MTOTO.FindAsync(id);
            _context.F12_24MTOTO.Remove(f12_24MTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F12_24MTOTOExists(int id)
        {
            return _context.F12_24MTOTO.Any(e => e.ID == id);
        }
        public async Task<ActionResult> F12_24()
        {
            List<F12_24MTOTO> f12_24MMTOTO = new List<F12_24MTOTO>();
            f12_24MMTOTO = await _context.F12_24MTOTO.ToListAsync();
            using (var workbook = new XLWorkbook())
            {

                var worksheet = workbook.Worksheets.Add("f12_24MMTOTO");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "IDNumber";
                worksheet.Cell(currentRow, 3).Value = "Tarehe";
                worksheet.Cell(currentRow, 4).Value = "SexMt";
                worksheet.Cell(currentRow, 5).Value = "TareheKuzaliwa";
                worksheet.Cell(currentRow, 6).Value = "UmriMtotoMiezi";
                worksheet.Cell(currentRow, 7).Value = "Q1";
                worksheet.Cell(currentRow, 8).Value = "Q1_1";
                worksheet.Cell(currentRow, 9).Value = "Q3";
                worksheet.Cell(currentRow, 10).Value = "Q3_1";
                worksheet.Cell(currentRow, 11).Value = "Q4";
                worksheet.Cell(currentRow, 12).Value = "Q4_1";
                worksheet.Cell(currentRow, 13).Value = "Q5";
                worksheet.Cell(currentRow, 14).Value = "Q6";
                worksheet.Cell(currentRow, 15).Value = "Q7";
                worksheet.Cell(currentRow, 16).Value = "Q8";
                worksheet.Cell(currentRow, 17).Value = "Q9_1_a";
                worksheet.Cell(currentRow, 18).Value = "Q9_1_b";
                worksheet.Cell(currentRow, 19).Value = "Q9_1_c";
                worksheet.Cell(currentRow, 20).Value = "Q9_1_d";
                worksheet.Cell(currentRow, 21).Value = "Q9_1_e";
                worksheet.Cell(currentRow, 22).Value = "Q9_1_f";
                worksheet.Cell(currentRow, 23).Value = "Q9_2_a";
                worksheet.Cell(currentRow, 24).Value = "Q9_2_b";
                worksheet.Cell(currentRow, 25).Value = "Q9_2_c";
                worksheet.Cell(currentRow, 26).Value = "Q9_2_d";
                worksheet.Cell(currentRow, 27).Value = "Q9_2_e";
                worksheet.Cell(currentRow, 28).Value = "Q9_2_f";
                worksheet.Cell(currentRow, 29).Value = "Q9_3_a";
                worksheet.Cell(currentRow, 30).Value = "Q9_3_b";
                worksheet.Cell(currentRow, 31).Value = "Q9_3_c";
                worksheet.Cell(currentRow, 32).Value = "Q9_3_d";
                worksheet.Cell(currentRow, 33).Value = "Q9_3_e";
                worksheet.Cell(currentRow, 34).Value = "Q9_3_f";
                worksheet.Cell(currentRow, 35).Value = "Q9_4_a";
                worksheet.Cell(currentRow, 36).Value = "Q9_4_b";
                worksheet.Cell(currentRow, 37).Value = "Q9_4_c";
                worksheet.Cell(currentRow, 38).Value = "Q9_4_d";
                worksheet.Cell(currentRow, 39).Value = "Q9_4_e";
                worksheet.Cell(currentRow, 40).Value = "Q9_4_f";
                worksheet.Cell(currentRow, 41).Value = "Q9_5_a";
                worksheet.Cell(currentRow, 42).Value = "Q9_5_b";
                worksheet.Cell(currentRow, 43).Value = "Q9_5_c";
                worksheet.Cell(currentRow, 44).Value = "Q9_5_d";
                worksheet.Cell(currentRow, 45).Value = "Q9_5_e";
                worksheet.Cell(currentRow, 46).Value = "Q9_5_f";
                worksheet.Cell(currentRow, 47).Value = "Q9_6_a";
                worksheet.Cell(currentRow, 48).Value = "Q9_6_b";
                worksheet.Cell(currentRow, 49).Value = "Q9_6_c";
                worksheet.Cell(currentRow, 50).Value = "Q9_6_d";
                worksheet.Cell(currentRow, 51).Value = "Q9_6_e";
                worksheet.Cell(currentRow, 52).Value = "Q9_6_f";
                worksheet.Cell(currentRow, 53).Value = "Q9_7_a";
                worksheet.Cell(currentRow, 54).Value = "Q9_7_b";
                worksheet.Cell(currentRow, 55).Value = "Q9_7_c";
                worksheet.Cell(currentRow, 56).Value = "Q9_7_d";
                worksheet.Cell(currentRow, 57).Value = "Q9_7_e";
                worksheet.Cell(currentRow, 58).Value = "Q9_7_f";
                worksheet.Cell(currentRow, 59).Value = "Q9_8_a";
                worksheet.Cell(currentRow, 60).Value = "Q9_8_b";
                worksheet.Cell(currentRow, 61).Value = "Q9_8_c";
                worksheet.Cell(currentRow, 62).Value = "Q9_8_d";
                worksheet.Cell(currentRow, 63).Value = "Q9_8_e";
                worksheet.Cell(currentRow, 64).Value = "Q9_8_f";
                worksheet.Cell(currentRow, 65).Value = "Q9_9_a";
                worksheet.Cell(currentRow, 66).Value = "Q9_9_b";
                worksheet.Cell(currentRow, 67).Value = "Q9_9_c";
                worksheet.Cell(currentRow, 68).Value = "Q9_9_d";
                worksheet.Cell(currentRow, 69).Value = "Q9_9_e";
                worksheet.Cell(currentRow, 70).Value = "Q9_9_f";
                worksheet.Cell(currentRow, 71).Value = "Q9_10_a";
                worksheet.Cell(currentRow, 72).Value = "Q9_10_b";
                worksheet.Cell(currentRow, 73).Value = "Q9_10_c";
                worksheet.Cell(currentRow, 74).Value = "Q9_10_d";
                worksheet.Cell(currentRow, 75).Value = "Q9_10_e";
                worksheet.Cell(currentRow, 76).Value = "Q9_10_f";
                worksheet.Cell(currentRow, 77).Value = "Q9_11_a";
                worksheet.Cell(currentRow, 78).Value = "Q9_11_b";
                worksheet.Cell(currentRow, 79).Value = "Q9_11_c";
                worksheet.Cell(currentRow, 80).Value = "Q9_11_d";
                worksheet.Cell(currentRow, 81).Value = "Q9_11_e";
                worksheet.Cell(currentRow, 82).Value = "Q9_11_f";
                worksheet.Cell(currentRow, 83).Value = "Q9_12_a";
                worksheet.Cell(currentRow, 84).Value = "Q9_12_b";
                worksheet.Cell(currentRow, 85).Value = "Q9_12_c";
                worksheet.Cell(currentRow, 86).Value = "Q9_12_d";
                worksheet.Cell(currentRow, 87).Value = "Q9_12_e";
                worksheet.Cell(currentRow, 88).Value = "Q9_12_f";
                worksheet.Cell(currentRow, 89).Value = "Q9_13_a";
                worksheet.Cell(currentRow, 90).Value = "Q9_13_b";
                worksheet.Cell(currentRow, 91).Value = "Q9_13_c";
                worksheet.Cell(currentRow, 92).Value = "Q9_13_d";
                worksheet.Cell(currentRow, 93).Value = "Q9_13_e";
                worksheet.Cell(currentRow, 94).Value = "Q9_13_f";
                worksheet.Cell(currentRow, 95).Value = "Q10";
                worksheet.Cell(currentRow, 96).Value = "Q10_1";
                worksheet.Cell(currentRow, 97).Value = "Q11";
                worksheet.Cell(currentRow, 98).Value = "Q11_1";
                worksheet.Cell(currentRow, 99).Value = "Q12";
                worksheet.Cell(currentRow, 100).Value = "Q12_1";
                worksheet.Cell(currentRow, 101).Value = "Q13_1";
                worksheet.Cell(currentRow, 102).Value = "Q13_2";
                worksheet.Cell(currentRow, 103).Value = "Q13_3";
                worksheet.Cell(currentRow, 104).Value = "Q13_4";
                worksheet.Cell(currentRow, 105).Value = "Q13_5";
                worksheet.Cell(currentRow, 106).Value = "Q13_6";
                worksheet.Cell(currentRow, 107).Value = "Q13_7";
                worksheet.Cell(currentRow, 108).Value = "Q13_8";
                worksheet.Cell(currentRow, 109).Value = "Q14_1";
                worksheet.Cell(currentRow, 110).Value = "Q14_2";
                worksheet.Cell(currentRow, 111).Value = "Q14_3";
                worksheet.Cell(currentRow, 112).Value = "Q14_4";
                worksheet.Cell(currentRow, 113).Value = "Q14_5";
                worksheet.Cell(currentRow, 114).Value = "Q14_6";
                worksheet.Cell(currentRow, 115).Value = "Q14_7";
                worksheet.Cell(currentRow, 116).Value = "Q14_8";
                worksheet.Cell(currentRow, 117).Value = "Q14_9";
                worksheet.Cell(currentRow, 118).Value = "Q14_10";
                worksheet.Cell(currentRow, 119).Value = "Q15_a_1";
                worksheet.Cell(currentRow, 120).Value = "Q15_a_2";
                worksheet.Cell(currentRow, 121).Value = "Q15_a_3";
                worksheet.Cell(currentRow, 122).Value = "Q15_a_4";
                worksheet.Cell(currentRow, 123).Value = "Q15_a_5";
                worksheet.Cell(currentRow, 124).Value = "Q15_b_1";
                worksheet.Cell(currentRow, 125).Value = "Q15_b_2";
                worksheet.Cell(currentRow, 126).Value = "Q15_b_3";
                worksheet.Cell(currentRow, 127).Value = "Q15_b_4";
                worksheet.Cell(currentRow, 128).Value = "Q15_b_5";
                worksheet.Cell(currentRow, 129).Value = "Q15_c_1";
                worksheet.Cell(currentRow, 130).Value = "Q15_c_2";
                worksheet.Cell(currentRow, 131).Value = "Q15_c_3";
                worksheet.Cell(currentRow, 132).Value = "Q15_c_4";
                worksheet.Cell(currentRow, 133).Value = "Q15_c_5";
                worksheet.Cell(currentRow, 134).Value = "Q10_a";
                worksheet.Cell(currentRow, 135).Value = "Q10_b";
                worksheet.Cell(currentRow, 136).Value = "Q10_c";
                worksheet.Cell(currentRow, 137).Value = "Q10_d";
                worksheet.Cell(currentRow, 138).Value = "Q10_e";
                worksheet.Cell(currentRow, 139).Value = "Q11_a";
                worksheet.Cell(currentRow, 140).Value = "Q11_b";
                worksheet.Cell(currentRow, 141).Value = "Q11_c";
                worksheet.Cell(currentRow, 142).Value = "Q12_a";
                worksheet.Cell(currentRow, 143).Value = "Q12_b";
                worksheet.Cell(currentRow, 144).Value = "Q12_c";
                worksheet.Cell(currentRow, 145).Value = "Q13_a";
                worksheet.Cell(currentRow, 146).Value = "Q13_b";
                worksheet.Cell(currentRow, 147).Value = "Q13_c";
                worksheet.Cell(currentRow, 148).Value = "Q13_d";
                worksheet.Cell(currentRow, 149).Value = "Q13_e";
                worksheet.Cell(currentRow, 150).Value = "Q13_f";
                worksheet.Cell(currentRow, 151).Value = "Q14_a";
                worksheet.Cell(currentRow, 152).Value = "Q14_b";
                worksheet.Cell(currentRow, 153).Value = "Q14_c";
                worksheet.Cell(currentRow, 154).Value = "Q14_d";
                worksheet.Cell(currentRow, 155).Value = "Q14_e";
                worksheet.Cell(currentRow, 156).Value = "Q14_f";
                worksheet.Cell(currentRow, 157).Value = "Q14_g";
                worksheet.Cell(currentRow, 158).Value = "Q15_a";
                worksheet.Cell(currentRow, 159).Value = "Q15_b";
                worksheet.Cell(currentRow, 160).Value = "Q15_c";
                worksheet.Cell(currentRow, 161).Value = "Q15_d";
                worksheet.Cell(currentRow, 162).Value = "Q15_e";
                worksheet.Cell(currentRow, 163).Value = "Q15_f";
                worksheet.Cell(currentRow, 164).Value = "Q15_g";
                worksheet.Cell(currentRow, 165).Value = "Q15_h";
                worksheet.Cell(currentRow, 166).Value = "Q16_a";
                worksheet.Cell(currentRow, 167).Value = "Q16_b";
                worksheet.Cell(currentRow, 168).Value = "Q16_c";
                worksheet.Cell(currentRow, 169).Value = "Q17_a";
                worksheet.Cell(currentRow, 170).Value = "Q17_b";
                worksheet.Cell(currentRow, 171).Value = "Q17_c";
                worksheet.Cell(currentRow, 172).Value = "ProblemsDsis";
                worksheet.Cell(currentRow, 173).Value = "MedicationPres";
                worksheet.Cell(currentRow, 174).Value = "DateNext";
                worksheet.Cell(currentRow, 175).Value = "CreatedDate";

                foreach (var item in f12_24MMTOTO)
                {

                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.ID;
                    worksheet.Cell(currentRow, 2).Value = item.IDNumber;
                    worksheet.Cell(currentRow, 3).Value = item.Tarehe;
                    worksheet.Cell(currentRow, 4).Value = item.SexMt;
                    worksheet.Cell(currentRow, 5).Value = item.TareheKuzaliwa;
                    worksheet.Cell(currentRow, 6).Value = item.UmriMtotoMiezi;
                    worksheet.Cell(currentRow, 7).Value = item.Q1;
                    worksheet.Cell(currentRow, 8).Value = item.Q1_1;
                    worksheet.Cell(currentRow, 9).Value = item.Q3;
                    worksheet.Cell(currentRow, 10).Value = item.Q3_1;
                    worksheet.Cell(currentRow, 11).Value = item.Q4;
                    worksheet.Cell(currentRow, 12).Value = item.Q4_1;
                    worksheet.Cell(currentRow, 13).Value = item.Q5;
                    worksheet.Cell(currentRow, 14).Value = item.Q6;
                    worksheet.Cell(currentRow, 15).Value = item.Q7;
                    worksheet.Cell(currentRow, 16).Value = item.Q8;
                    worksheet.Cell(currentRow, 17).Value = item.Q9_1_a;
                    worksheet.Cell(currentRow, 18).Value = item.Q9_1_b;
                    worksheet.Cell(currentRow, 19).Value = item.Q9_1_c;
                    worksheet.Cell(currentRow, 20).Value = item.Q9_1_d;
                    worksheet.Cell(currentRow, 21).Value = item.Q9_1_e;
                    worksheet.Cell(currentRow, 22).Value = item.Q9_1_f;
                    worksheet.Cell(currentRow, 23).Value = item.Q9_2_a;
                    worksheet.Cell(currentRow, 24).Value = item.Q9_2_b;
                    worksheet.Cell(currentRow, 25).Value = item.Q9_2_c;
                    worksheet.Cell(currentRow, 26).Value = item.Q9_2_d;
                    worksheet.Cell(currentRow, 27).Value = item.Q9_2_e;
                    worksheet.Cell(currentRow, 28).Value = item.Q9_2_f;
                    worksheet.Cell(currentRow, 29).Value = item.Q9_3_a;
                    worksheet.Cell(currentRow, 30).Value = item.Q9_3_b;
                    worksheet.Cell(currentRow, 31).Value = item.Q9_3_c;
                    worksheet.Cell(currentRow, 32).Value = item.Q9_3_d;
                    worksheet.Cell(currentRow, 33).Value = item.Q9_3_e;
                    worksheet.Cell(currentRow, 34).Value = item.Q9_3_f;
                    worksheet.Cell(currentRow, 35).Value = item.Q9_4_a;
                    worksheet.Cell(currentRow, 36).Value = item.Q9_4_b;
                    worksheet.Cell(currentRow, 37).Value = item.Q9_4_c;
                    worksheet.Cell(currentRow, 38).Value = item.Q9_4_d;
                    worksheet.Cell(currentRow, 39).Value = item.Q9_4_e;
                    worksheet.Cell(currentRow, 40).Value = item.Q9_4_f;
                    worksheet.Cell(currentRow, 41).Value = item.Q9_5_a;
                    worksheet.Cell(currentRow, 42).Value = item.Q9_5_b;
                    worksheet.Cell(currentRow, 43).Value = item.Q9_5_c;
                    worksheet.Cell(currentRow, 44).Value = item.Q9_5_d;
                    worksheet.Cell(currentRow, 45).Value = item.Q9_5_e;
                    worksheet.Cell(currentRow, 46).Value = item.Q9_5_f;
                    worksheet.Cell(currentRow, 47).Value = item.Q9_6_a;
                    worksheet.Cell(currentRow, 48).Value = item.Q9_6_b;
                    worksheet.Cell(currentRow, 49).Value = item.Q9_6_c;
                    worksheet.Cell(currentRow, 50).Value = item.Q9_6_d;
                    worksheet.Cell(currentRow, 51).Value = item.Q9_6_e;
                    worksheet.Cell(currentRow, 52).Value = item.Q9_6_f;
                    worksheet.Cell(currentRow, 53).Value = item.Q9_7_a;
                    worksheet.Cell(currentRow, 54).Value = item.Q9_7_b;
                    worksheet.Cell(currentRow, 55).Value = item.Q9_7_c;
                    worksheet.Cell(currentRow, 56).Value = item.Q9_7_d;
                    worksheet.Cell(currentRow, 57).Value = item.Q9_7_e;
                    worksheet.Cell(currentRow, 58).Value = item.Q9_7_f;
                    worksheet.Cell(currentRow, 59).Value = item.Q9_8_a;
                    worksheet.Cell(currentRow, 60).Value = item.Q9_8_b;
                    worksheet.Cell(currentRow, 61).Value = item.Q9_8_c;
                    worksheet.Cell(currentRow, 62).Value = item.Q9_8_d;
                    worksheet.Cell(currentRow, 63).Value = item.Q9_8_e;
                    worksheet.Cell(currentRow, 64).Value = item.Q9_8_f;
                    worksheet.Cell(currentRow, 65).Value = item.Q9_9_a;
                    worksheet.Cell(currentRow, 66).Value = item.Q9_9_b;
                    worksheet.Cell(currentRow, 67).Value = item.Q9_9_c;
                    worksheet.Cell(currentRow, 68).Value = item.Q9_9_d;
                    worksheet.Cell(currentRow, 69).Value = item.Q9_9_e;
                    worksheet.Cell(currentRow, 70).Value = item.Q9_9_f;
                    worksheet.Cell(currentRow, 71).Value = item.Q9_10_a;
                    worksheet.Cell(currentRow, 72).Value = item.Q9_10_b;
                    worksheet.Cell(currentRow, 73).Value = item.Q9_10_c;
                    worksheet.Cell(currentRow, 74).Value = item.Q9_10_d;
                    worksheet.Cell(currentRow, 75).Value = item.Q9_10_e;
                    worksheet.Cell(currentRow, 76).Value = item.Q9_10_f;
                    worksheet.Cell(currentRow, 77).Value = item.Q9_11_a;
                    worksheet.Cell(currentRow, 78).Value = item.Q9_11_b;
                    worksheet.Cell(currentRow, 79).Value = item.Q9_11_c;
                    worksheet.Cell(currentRow, 80).Value = item.Q9_11_d;
                    worksheet.Cell(currentRow, 81).Value = item.Q9_11_e;
                    worksheet.Cell(currentRow, 82).Value = item.Q9_11_f;
                    worksheet.Cell(currentRow, 83).Value = item.Q9_12_a;
                    worksheet.Cell(currentRow, 84).Value = item.Q9_12_b;
                    worksheet.Cell(currentRow, 85).Value = item.Q9_12_c;
                    worksheet.Cell(currentRow, 86).Value = item.Q9_12_d;
                    worksheet.Cell(currentRow, 87).Value = item.Q9_12_e;
                    worksheet.Cell(currentRow, 88).Value = item.Q9_12_f;
                    worksheet.Cell(currentRow, 89).Value = item.Q9_13_a;
                    worksheet.Cell(currentRow, 90).Value = item.Q9_13_b;
                    worksheet.Cell(currentRow, 91).Value = item.Q9_13_c;
                    worksheet.Cell(currentRow, 92).Value = item.Q9_13_d;
                    worksheet.Cell(currentRow, 93).Value = item.Q9_13_e;
                    worksheet.Cell(currentRow, 94).Value = item.Q9_13_f;
                    worksheet.Cell(currentRow, 95).Value = item.Q10;
                    worksheet.Cell(currentRow, 96).Value = item.Q10_1;
                    worksheet.Cell(currentRow, 97).Value = item.Q11;
                    worksheet.Cell(currentRow, 98).Value = item.Q11_1;
                    worksheet.Cell(currentRow, 99).Value = item.Q12;
                    worksheet.Cell(currentRow, 100).Value = item.Q12_1;
                    worksheet.Cell(currentRow, 101).Value = item.Q13_1;
                    worksheet.Cell(currentRow, 102).Value = item.Q13_2;
                    worksheet.Cell(currentRow, 103).Value = item.Q13_3;
                    worksheet.Cell(currentRow, 104).Value = item.Q13_4;
                    worksheet.Cell(currentRow, 105).Value = item.Q13_5;
                    worksheet.Cell(currentRow, 106).Value = item.Q13_6;
                    worksheet.Cell(currentRow, 107).Value = item.Q13_7;
                    worksheet.Cell(currentRow, 108).Value = item.Q13_8;
                    worksheet.Cell(currentRow, 109).Value = item.Q14_1;
                    worksheet.Cell(currentRow, 110).Value = item.Q14_2;
                    worksheet.Cell(currentRow, 111).Value = item.Q14_3;
                    worksheet.Cell(currentRow, 112).Value = item.Q14_4;
                    worksheet.Cell(currentRow, 113).Value = item.Q14_5;
                    worksheet.Cell(currentRow, 114).Value = item.Q14_6;
                    worksheet.Cell(currentRow, 115).Value = item.Q14_7;
                    worksheet.Cell(currentRow, 116).Value = item.Q14_8;
                    worksheet.Cell(currentRow, 117).Value = item.Q14_9;
                    worksheet.Cell(currentRow, 118).Value = item.Q14_10;
                    worksheet.Cell(currentRow, 119).Value = item.Q15_a_1;
                    worksheet.Cell(currentRow, 120).Value = item.Q15_a_2;
                    worksheet.Cell(currentRow, 121).Value = item.Q15_a_3;
                    worksheet.Cell(currentRow, 122).Value = item.Q15_a_4;
                    worksheet.Cell(currentRow, 123).Value = item.Q15_a_5;
                    worksheet.Cell(currentRow, 124).Value = item.Q15_b_1;
                    worksheet.Cell(currentRow, 125).Value = item.Q15_b_2;
                    worksheet.Cell(currentRow, 126).Value = item.Q15_b_3;
                    worksheet.Cell(currentRow, 127).Value = item.Q15_b_4;
                    worksheet.Cell(currentRow, 128).Value = item.Q15_b_5;
                    worksheet.Cell(currentRow, 129).Value = item.Q15_c_1;
                    worksheet.Cell(currentRow, 130).Value = item.Q15_c_2;
                    worksheet.Cell(currentRow, 131).Value = item.Q15_c_3;
                    worksheet.Cell(currentRow, 132).Value = item.Q15_c_4;
                    worksheet.Cell(currentRow, 133).Value = item.Q15_c_5;
                    worksheet.Cell(currentRow, 134).Value = item.Q10_a;
                    worksheet.Cell(currentRow, 135).Value = item.Q10_b;
                    worksheet.Cell(currentRow, 136).Value = item.Q10_c;
                    worksheet.Cell(currentRow, 137).Value = item.Q10_d;
                    worksheet.Cell(currentRow, 138).Value = item.Q10_e;
                    worksheet.Cell(currentRow, 139).Value = item.Q11_a;
                    worksheet.Cell(currentRow, 140).Value = item.Q11_b;
                    worksheet.Cell(currentRow, 141).Value = item.Q11_c;
                    worksheet.Cell(currentRow, 142).Value = item.Q12_a;
                    worksheet.Cell(currentRow, 143).Value = item.Q12_b;
                    worksheet.Cell(currentRow, 144).Value = item.Q12_c;
                    worksheet.Cell(currentRow, 145).Value = item.Q13_a;
                    worksheet.Cell(currentRow, 146).Value = item.Q13_b;
                    worksheet.Cell(currentRow, 147).Value = item.Q13_c;
                    worksheet.Cell(currentRow, 148).Value = item.Q13_d;
                    worksheet.Cell(currentRow, 149).Value = item.Q13_e;
                    worksheet.Cell(currentRow, 150).Value = item.Q13_f;
                    worksheet.Cell(currentRow, 151).Value = item.Q14_a;
                    worksheet.Cell(currentRow, 152).Value = item.Q14_b;
                    worksheet.Cell(currentRow, 153).Value = item.Q14_c;
                    worksheet.Cell(currentRow, 154).Value = item.Q14_d;
                    worksheet.Cell(currentRow, 155).Value = item.Q14_e;
                    worksheet.Cell(currentRow, 156).Value = item.Q14_f;
                    worksheet.Cell(currentRow, 157).Value = item.Q14_g;
                    worksheet.Cell(currentRow, 158).Value = item.Q15_a;
                    worksheet.Cell(currentRow, 159).Value = item.Q15_b;
                    worksheet.Cell(currentRow, 160).Value = item.Q15_c;
                    worksheet.Cell(currentRow, 161).Value = item.Q15_d;
                    worksheet.Cell(currentRow, 162).Value = item.Q15_e;
                    worksheet.Cell(currentRow, 163).Value = item.Q15_f;
                    worksheet.Cell(currentRow, 164).Value = item.Q15_g;
                    worksheet.Cell(currentRow, 165).Value = item.Q15_h;
                    worksheet.Cell(currentRow, 166).Value = item.Q16_a;
                    worksheet.Cell(currentRow, 167).Value = item.Q16_b;
                    worksheet.Cell(currentRow, 168).Value = item.Q16_c;
                    worksheet.Cell(currentRow, 169).Value = item.Q17_a;
                    worksheet.Cell(currentRow, 170).Value = item.Q17_b;
                    worksheet.Cell(currentRow, 171).Value = item.Q17_c;
                    worksheet.Cell(currentRow, 172).Value = item.ProblemsDsis;
                    worksheet.Cell(currentRow, 173).Value = item.MedicationPres;
                    worksheet.Cell(currentRow, 174).Value = item.DateNext;
                    worksheet.Cell(currentRow, 175).Value = item.CreatedDate;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlformats-officedocument.spreadsheetml.sheet"
                        , "fomu12_24.xlsx");
                }
            }
        }
    }
}

