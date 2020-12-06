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
    public class FSMAMASITAController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FSMAMASITAController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: FSMAMASITA
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FSMAMA.ToListAsync());
            }
            else
            {
                return View(await _context.FSMAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FSMAMA.ToListAsync());
        }

        // GET: FSMAMASITA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fSMAMA = await _context.FSMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fSMAMA == null)
            {
                return NotFound();
            }

            return View(fSMAMA);
        }

        // GET: FSMAMASITA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FSMAMASITA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q6_1,Q7,Q8," +
            "Q8_1,Q9,Q10,Q11,Q12,Q12_1,Q13,Q14,Q14_1,Q15,Q16,ProblemsDiagnosis,Q17,ManagementFT,DateVisit9," +
            "ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FSMAMA fSMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fSMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fSMAMA);
        }

        // GET: FSMAMASITA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fSMAMA = await _context.FSMAMA.FindAsync(id);
            if (fSMAMA == null)
            {
                return NotFound();
            }
            return View(fSMAMA);
        }

        // POST: FSMAMASITA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q2_1,Q3,Q3_1,Q4,Q4_1,Q5,Q6,Q6_1,Q7," +
            "Q8,Q8_1,Q9,Q10,Q11,Q12,Q12_1,Q13,Q14,Q14_1,Q15,Q16,ProblemsDiagnosis,Q17,ManagementFT,DateVisit9,ID," +
            "CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FSMAMA fSMAMA)
        {
            if (id != fSMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fSMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FSMAMAExists(fSMAMA.ID))
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
            return View(fSMAMA);
        }

        // GET: FSMAMASITA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fSMAMA = await _context.FSMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fSMAMA == null)
            {
                return NotFound();
            }

            return View(fSMAMA);
        }

        // POST: FSMAMASITA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fSMAMA = await _context.FSMAMA.FindAsync(id);
            _context.FSMAMA.Remove(fSMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FSMAMAExists(int id)
        {
            return _context.FSMAMA.Any(e => e.ID == id);
        }
    }
}
