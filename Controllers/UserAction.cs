using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHAMCApp.Data;
using BHAMCApp.Models;
using BHAMCApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BHAMCApp.Controllers
{
    public class UserAction : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ApplicationDbContext> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICurrentUserService _currentUserService;

        public UserAction(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
           UserManager<ApplicationUser> userManager, ILogger<ApplicationDbContext> logger, ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _currentUserService = currentUserService;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bhamc.ToListAsync());
        }

        public async Task<IActionResult> UserDetails(string userid)
        {
            var bhauser = await _context.Bhamc.Where(u => u.CreatedByUser == userid).ToListAsync();
            return View(bhauser);
        }


        // GET: Pmtct/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            

            var pmtctData = await _context.Bhamc
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pmtctData == null)
            {
                return NotFound();
            }

            return View(pmtctData);
        }

        public IActionResult Create()
        {
            var cout = new List<UserMgt>();

            var h = _context.Bhamc.GroupBy(i => i.CreatedByUser).Select(g => new
            {
                username = g.Key,
                edit = g.Sum(i => i.Edited ? 1 : 0),
                create = g.Count()
            }).OrderByDescending(p => p.create);


            //var a1 = _context.Pmt.Select(i => new { username = i.CreatedByUser,
            //  edit=i.Edited.Equals(true).ToString() , create = i.CreatedByUser.Count()});

            foreach (var ct in h)
            {
                cout.Add(new UserMgt
                {
                    UserName = ct.username,
                    Created = ct.create,
                    Edited = ct.edit

                });
            }

            return View(cout);
        }
    }
}
