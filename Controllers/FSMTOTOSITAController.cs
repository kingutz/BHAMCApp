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
    public class FSMTOTOSITAController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FSMTOTOSITAController(ApplicationDbContext context,RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        // GET: FSMTOTOSITA
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FSMTOTO.ToListAsync());
            }
            else
            {
                return View(await _context.FSMTOTO.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FSMTOTO.ToListAsync());
        }

        // GET: FSMTOTOSITA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fSMTOTO = await _context.FSMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fSMTOTO == null)
            {
                return NotFound();
            }

            return View(fSMTOTO);
        }

        // GET: FSMTOTOSITA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FSMTOTOSITA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q2,Q3,Q4_1_a,Q4_1_b,Q4_1_c,Q4_1_e,Q4_2_a,Q4_2_b,Q4_2_c,Q4_2_e,Q4_3_a,Q4_3_b,Q4_3_c,Q4_3_e,Q4_4_a,Q4_4_b,Q4_4_c,Q4_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q6_5_a,Q6_5_b,Q6_5_c,Q6_5_e,Q7_5_a,Q7_5_b,Q7_5_c,Q7_5_e,Q8_5_a,Q8_5_b,Q8_5_c,Q8_5_e,Q9_5_a,Q9_5_b,Q9_5_c,Q9_5_e,Q10_5_a,Q10_5_b,Q10_5_c,Q10_5_e,Q5_1,Q5_1_a,Q6_2,Q6_2_a,Q6_3,Q6_3_a,Q6_4,Q6_4_a,Q6_5,Q6_5_aa,Q6_6,Q6_6_a,Q6_7,Q6_7_a,Q6_8,Q6_8_a,Q6,Q6_1,Q7_a_1,Q7_a_2,Q7_a_3,Q7_a_4,Q7_a_5,Q7_b_1,Q7_b_2,Q7_b_3,Q7_b_4,Q7_b_5,Q7_c_1,Q7_c_2,Q7_c_3,Q7_c_4,Q7_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FSMTOTO fSMTOTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fSMTOTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fSMTOTO);
        }

        // GET: FSMTOTOSITA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fSMTOTO = await _context.FSMTOTO.FindAsync(id);
            if (fSMTOTO == null)
            {
                return NotFound();
            }
            return View(fSMTOTO);
        }

        // POST: FSMTOTOSITA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q2,Q3,Q4_1_a,Q4_1_b,Q4_1_c,Q4_1_e,Q4_2_a,Q4_2_b,Q4_2_c,Q4_2_e,Q4_3_a,Q4_3_b,Q4_3_c,Q4_3_e,Q4_4_a,Q4_4_b,Q4_4_c,Q4_4_e,Q5_5_a,Q5_5_b,Q5_5_c,Q5_5_e,Q6_5_a,Q6_5_b,Q6_5_c,Q6_5_e,Q7_5_a,Q7_5_b,Q7_5_c,Q7_5_e,Q8_5_a,Q8_5_b,Q8_5_c,Q8_5_e,Q9_5_a,Q9_5_b,Q9_5_c,Q9_5_e,Q10_5_a,Q10_5_b,Q10_5_c,Q10_5_e,Q5_1,Q5_1_a,Q6_2,Q6_2_a,Q6_3,Q6_3_a,Q6_4,Q6_4_a,Q6_5,Q6_5_aa,Q6_6,Q6_6_a,Q6_7,Q6_7_a,Q6_8,Q6_8_a,Q6,Q6_1,Q7_a_1,Q7_a_2,Q7_a_3,Q7_a_4,Q7_a_5,Q7_b_1,Q7_b_2,Q7_b_3,Q7_b_4,Q7_b_5,Q7_c_1,Q7_c_2,Q7_c_3,Q7_c_4,Q7_c_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FSMTOTO fSMTOTO)
        {
            if (id != fSMTOTO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fSMTOTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FSMTOTOExists(fSMTOTO.ID))
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
            return View(fSMTOTO);
        }

        // GET: FSMTOTOSITA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fSMTOTO = await _context.FSMTOTO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fSMTOTO == null)
            {
                return NotFound();
            }

            return View(fSMTOTO);
        }

        // POST: FSMTOTOSITA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fSMTOTO = await _context.FSMTOTO.FindAsync(id);
            _context.FSMTOTO.Remove(fSMTOTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FSMTOTOExists(int id)
        {
            return _context.FSMTOTO.Any(e => e.ID == id);
        }
    }
}
