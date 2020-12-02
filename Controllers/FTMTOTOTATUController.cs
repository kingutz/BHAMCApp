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
    public class FTMTOTOTATUController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FTMTOTOTATUController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: FTMTOTOTATU
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FTMTOTO.ToListAsync());
            }
            else
            {
                return View(await _context.FTMTOTO.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FTMTOTO.ToListAsync());
        }

        // GET: FTMTOTOTATU/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTMTOTO = await _context.FTMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTMTOTO == null)
            {
                return NotFound();
            }

            return View(fTMTOTO);
        }

        // GET: FTMTOTOTATU/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FTMTOTOTATU/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q2,Q3,Q3_a,Q3_b,Q4,Q5_1_a,Q5_1_b,Q5_1_c,Q5_1_e,Q5_2_a,Q5_2_b,Q5_2_c,Q5_2_e,Q5_3_a,Q5_3_b,Q5_3_c,Q5_3_e,Q5_4_a,Q5_4_b,Q5_4_c,Q5_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q6_1,Q6_1_a,Q6_2,Q6_2_a,Q6_3,Q6_3_a,Q6_4,Q6_4_a,Q6_5,Q6_5_a,Q6_6,Q6_6_a,Q6_7,Q6_7_a,Q6_8,Q6_8_a,Q7,Q7_1,Q8,Q8_1,Q9_a_1,Q9_a_2,Q9_a_3,Q9_a_4,Q9_a_5,Q9_b_1,Q9_b_2,Q9_b_3,Q9_b_4,Q9_b_5,Q9_c_1,Q9_c_2,Q9_c_3,Q9_c_4,Q9_c_5,Q10,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date3Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTMTOTO fTMTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTMTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fTMTOTO);
        }

        // GET: FTMTOTOTATU/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTMTOTO = await _context.FTMTOTO.FindAsync(id);
            if (fTMTOTO == null)
            {
                return NotFound();
            }
            return View(fTMTOTO);
        }

        // POST: FTMTOTOTATU/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q2,Q3,Q3_a,Q3_b,Q4,Q5_1_a,Q5_1_b,Q5_1_c,Q5_1_e,Q5_2_a,Q5_2_b,Q5_2_c,Q5_2_e,Q5_3_a,Q5_3_b,Q5_3_c,Q5_3_e,Q5_4_a,Q5_4_b,Q5_4_c,Q5_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q6_1,Q6_1_a,Q6_2,Q6_2_a,Q6_3,Q6_3_a,Q6_4,Q6_4_a,Q6_5,Q6_5_a,Q6_6,Q6_6_a,Q6_7,Q6_7_a,Q6_8,Q6_8_a,Q7,Q7_1,Q8,Q8_1,Q9_a_1,Q9_a_2,Q9_a_3,Q9_a_4,Q9_a_5,Q9_b_1,Q9_b_2,Q9_b_3,Q9_b_4,Q9_b_5,Q9_c_1,Q9_c_2,Q9_c_3,Q9_c_4,Q9_c_5,Q10,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date3Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FTMTOTO fTMTOTO)
        {
            if (id != fTMTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTMTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTMTOTOExists(fTMTOTO.ID))
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
            return View(fTMTOTO);
        }

        // GET: FTMTOTOTATU/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTMTOTO = await _context.FTMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fTMTOTO == null)
            {
                return NotFound();
            }

            return View(fTMTOTO);
        }

        // POST: FTMTOTOTATU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTMTOTO = await _context.FTMTOTO.FindAsync(id);
            _context.FTMTOTO.Remove(fTMTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTMTOTOExists(int id)
        {
            return _context.FTMTOTO.Any(e => e.ID == id);
        }
    }
}
