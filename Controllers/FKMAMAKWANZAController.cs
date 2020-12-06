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
    public class FKMAMAKWANZAController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FKMAMAKWANZAController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: FKMAMAKWANZA
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FKMAMA.ToListAsync());
            }
            else
            {
                return View(await _context.FKMAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FKMAMA.ToListAsync());
        }

        // GET: FKMAMAKWANZA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMAMA = await _context.FKMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMAMA == null)
            {
                return NotFound();
            }

            return View(fKMAMA);
        }

        // GET: FKMAMAKWANZA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FKMAMAKWANZA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,OthersQ1,Q2,Q3,Q4,ItajeQ4,Q5,Q5_1,Q6,Q7,Q8,Q9," +
            "Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,ProblemsDiagnosis,ManagementFK,DateVisit3," +
            "ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMAMA fKMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fKMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fKMAMA);
        }

        // GET: FKMAMAKWANZA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMAMA = await _context.FKMAMA.FindAsync(id);
            if (fKMAMA == null)
            {
                return NotFound();
            }
            return View(fKMAMA);
        }

        // POST: FKMAMAKWANZA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,OthersQ1,Q2,Q3,Q4,ItajeQ4,Q5,Q5_1,Q6,Q7," +
            "Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,ProblemsDiagnosis,ManagementFK," +
            "DateVisit3,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMAMA fKMAMA)
        {
            if (id != fKMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fKMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FKMAMAExists(fKMAMA.ID))
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
            return View(fKMAMA);
        }

        // GET: FKMAMAKWANZA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMAMA = await _context.FKMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMAMA == null)
            {
                return NotFound();
            }

            return View(fKMAMA);
        }

        // POST: FKMAMAKWANZA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fKMAMA = await _context.FKMAMA.FindAsync(id);
            _context.FKMAMA.Remove(fKMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FKMAMAExists(int id)
        {
            return _context.FKMAMA.Any(e => e.ID == id);
        }
    }
}
