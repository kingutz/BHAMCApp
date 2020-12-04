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
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,M1,M3,M6,M9,M12,M15,M18,M24,M28,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q4_1,Q5,Q5_1,Q6,Q6_1,Q6_2,Q7,Q8,Q9_1,Q9_2,Q9_3,Q9_4,Q9_5,Q10_1_a,Q10_1_b,Q10_1_c,Q10_1_d,Q10_1_e,Q10_1_f,Q10_1_g,Q10_1_h,Q10_1_i,Q10_2_a,Q10_2_b,Q10_2_c,Q10_2_d,Q10_3_a,Q10_3_b,Q10_3_c,Q10_3_d,Q10_3_e,Q10_3_f,Q10_3_g,Q10_3_h,Q10_3_i,Q10_4_a,Q10_4_b,Q10_4_c,Q10_4_d,Q10_5_a,Q10_5_b,Q10_5_c,Q10_5_d,Q10_5_e,Q10_5_f,Q10_5_g,Q10_5_h,Q10_5_i,Q11,Q11_1,Q12,Q13,Q13_1,Q14,Q15,Q15_1,Q16,Q17_a_1,Q17_a_2,Q17_a_3,Q17_a_4,Q17_a_5,Q17_b_1,Q17_b_2,Q17_b_3,Q17_b_4,Q17_b_5,Q17_c_1,Q17_c_2,Q17_c_3,Q17_c_4,Q17_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q16_a,Q17_a,ProblemsDsis,MedicationPres,DateVisit32,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F28_44MTOTO f28_44MTOTO)
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
    }
}
