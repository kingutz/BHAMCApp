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
        public async Task<IActionResult> Create([Bind("IDNumber,Tarehe,SexMt,TareheKuzaliwa,UmriMtotoMiezi,Q1,Q1_1,Q2,Q3,Q1_1_a,Q1_1_b,Q1_1_c,Q2_2_a,Q2_2_b,Q2_2_c,Q3_3_a,Q3_3_b,Q3_3_c,Q4_4_a,Q4_4_b,Q4_4_c,Q5_5_a,Q5_5_b,Q5_5_c,Q6_5_a,Q6_5_b,Q6_5_c,Q7_5_a,Q7_5_b,Q7_5_c,Q8_5_a,Q8_5_b,Q8_5_c,Q4_1,Q4_1_a,Q4_2,Q4_2_a,Q4_3,Q4_3_a,Q4_4,Q4_4_aa,Q4_5,Q4_5_aa,Q4_6,Q4_6_a,Q4_7,Q4_7_a,Q4_8,Q4_8_a,Q5,Q5_1,Q6_a_1,Q6_a_2,Q6_a_3,Q6_a_4,Q6_a_5,Q6_b_1,Q6_b_2,Q6_b_3,Q6_b_4,Q6_b_5,Q6_c_1,Q6_c_2,Q6_c_3,Q6_c_4,Q6_c_5,Q6_d_1,Q6_d_2,Q6_d_3,Q6_d_4,Q6_d_5,Q10_a,Q10_b,Q10_c,Q10_d,Q10_e,Q11_a,Q11_b,Q11_c,Q12_a,Q12_b,Q12_c,Q13_a,Q13_b,Q13_c,Q13_d,Q13_e,Q13_f,Q14_a,Q14_b,Q14_c,Q14_d,Q14_e,Q14_f,Q14_g,Q15_a,Q15_b,Q15_c,Q15_d,Q15_e,Q15_f,Q15_g,Q15_h,Q16_a,Q16_b,Q16_c,Q17_a,Q17_b,Q17_c,ProblemsDsis,MedicationPres,Date6Month,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMMTOTO fKMMTOTO)
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
    }
}
