using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHAMCApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BHAMCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BHAMCApp.Controllers
{
	public class AdminController : Controller
	{

		private readonly ILogger<HomeController> _logger;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _context;

		public AdminController(ILogger<HomeController> logger, ApplicationDbContext context,
				UserManager<ApplicationUser> userManager,
				RoleManager<IdentityRole> roleManager
				)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_context = context;
			_logger = logger;
		}


		public ViewResult Index() => View(_roleManager.Roles);

		public async Task<IActionResult> UserIndex()
		{
			var user = new List<UserData>();

			try
			{
				var users = await _userManager.Users.ToListAsync();
				foreach (var item in users)
				{
					user.Add(new UserData()
					{
						Id = item.Id,
						Name = item.Name,
						UserName = item.UserName,
						Email = item.Email
					});
				}
			}
			catch (Exception ex)
			{
				_logger?.LogError(ex, ex.GetBaseException().Message);
			}

			return View(user);
		}

		[HttpGet]
		public async Task<IActionResult> Edit(string id)
		{
			var role = await _roleManager.FindByIdAsync(id);
			List<ApplicationUser> Members = new List<ApplicationUser>();
			List<ApplicationUser> NotMembers = new List<ApplicationUser>();

			foreach (var userapp in _userManager.Users)
			{
				var list = await _userManager.IsInRoleAsync(userapp, role.Name)
				? Members : NotMembers;
				list.Add(userapp);
			}
			return View(new RoleEdit
			{
				RoleName = role,
				MemberToRole = Members,
				NotMembersToRole = NotMembers
			});
		}
		[HttpPost]
		public async Task<IActionResult> Edit(UserToRole model)
		{
			IdentityResult result;
			if (ModelState.IsValid)
			{
				foreach (string userId in model.IdToAdd ?? new string[] { })
				{
					ApplicationUser user = await _userManager.FindByIdAsync(userId);
					if (user != null)
					{
						result = await _userManager.AddToRoleAsync(user, model.RoleName);
						if (!result.Succeeded)
						{
							AddErrorsFromResult(result);
						}
					}
				}

				foreach (string userId in model.IdToDelete ?? new string[] { })
				{
					ApplicationUser user = await _userManager.FindByIdAsync(userId);
					if (user != null)
					{
						result = await _userManager.RemoveFromRoleAsync(user,
						model.RoleName);
						if (!result.Succeeded)
						{
							AddErrorsFromResult(result);
						}
					}
				}
			}
			if (ModelState.IsValid)
			{
				return RedirectToAction(nameof(Edit));
			}
			else
			{
				return await Edit(model.RoleId);
			}
		}
		private void AddErrorsFromResult(IdentityResult result)
		{
			foreach (IdentityError error in result.Errors)
			{
				ModelState.AddModelError("", error.Description);
			}
		}
	}
}