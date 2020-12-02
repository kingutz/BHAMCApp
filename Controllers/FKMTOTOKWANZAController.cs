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
        

        public FKMTOTOKWANZAController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
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
    }
}
