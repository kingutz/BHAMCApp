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
    public class FKMMAMAMBILIController : Controller
    {
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ApplicationDbContext _context;

        public FKMMAMAMBILIController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger,
            ICurrentUserService currentUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _currentUserService = currentUserService;
        }

        // GET: FKMMAMAMBILI
        public async Task<IActionResult> Index()
        {
            bool isAdmin = User.IsInRole("admin");
            if (isAdmin)
            {
                return View(await _context.FKMMAMA.ToListAsync());
            }
            else
            {
                return View(await _context.FKMMAMA.Where(p => p.CreatedByUser == _currentUserService.GetCurrentUsername()).ToListAsync());

            }
            //return View(await _context.FKMMAMA.ToListAsync());
        }

        // GET: FKMMAMAMBILI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMAMA = await _context.FKMMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMMAMA == null)
            {
                return NotFound();
            }

            return View(fKMMAMA);
        }

        // GET: FKMMAMAMBILI/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FKMMAMAMBILI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,IDNumber,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q5,Q6,Q7,Q7_1,Q8," +
            "Q9,Q9_1,Q10,Q11,Q11_1,Q13,Q14,Q15,Q16,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMMAMA fKMMAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fKMMAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fKMMAMA);
        }

        // GET: FKMMAMAMBILI/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMAMA = await _context.FKMMAMA.FindAsync(id);
            if (fKMMAMA == null)
            {
                return NotFound();
            }
            return View(fKMMAMA);
        }

        // POST: FKMMAMAMBILI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,IDNumber,Q1,Q1_1,Q2,Q3,Q3_1,Q4,Q5,Q6,Q7,Q7_1,Q8," +
            "Q9,Q9_1,Q10,Q11,Q11_1,Q13,Q14,Q15,Q16,ID,CreatedByUser," +
            "CreatedDate,ModifiedByUser,ModifiedDate,Edited")] FKMMAMA fKMMAMA)
        {
            if (id != fKMMAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fKMMAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FKMMAMAExists(fKMMAMA.ID))
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
            return View(fKMMAMA);
        }

        // GET: FKMMAMAMBILI/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fKMMAMA = await _context.FKMMAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fKMMAMA == null)
            {
                return NotFound();
            }

            return View(fKMMAMA);
        }

        // POST: FKMMAMAMBILI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fKMMAMA = await _context.FKMMAMA.FindAsync(id);
            _context.FKMMAMA.Remove(fKMMAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FKMMAMAExists(int id)
        {
            return _context.FKMMAMA.Any(e => e.ID == id);
        }
    }
}
