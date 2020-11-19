using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BHAMCApp.Data;
using BHAMCApp.Models;

namespace BHAMCApp.Controllers
{
    public class F15_24MAMA15Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public F15_24MAMA15Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: F15_24MAMA15
        public async Task<IActionResult> Index()
        {
            return View(await _context.F15_24MAMA.ToListAsync());
        }

        // GET: F15_24MAMA15/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f15_24MAMA = await _context.F15_24MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f15_24MAMA == null)
            {
                return NotFound();
            }

            return View(f15_24MAMA);
        }

        // GET: F15_24MAMA15/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: F15_24MAMA15/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNumber,Date,Q1,Q1_1,Q2,Q2_1,Q3,Q4,Q4_1,Q4_2,Q5,Q6,Q6_1,Q7,Q8,Q9,Q10,Q10_1,Q11,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F15_24MAMA f15_24MAMA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f15_24MAMA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(f15_24MAMA);
        }

        // GET: F15_24MAMA15/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f15_24MAMA = await _context.F15_24MAMA.FindAsync(id);
            if (f15_24MAMA == null)
            {
                return NotFound();
            }
            return View(f15_24MAMA);
        }

        // POST: F15_24MAMA15/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNumber,Date,Q1,Q1_1,Q2,Q2_1,Q3,Q4,Q4_1,Q4_2,Q5,Q6,Q6_1,Q7,Q8,Q9,Q10,Q10_1,Q11,ID,CreatedByUser,CreatedDate,ModifiedByUser,ModifiedDate,Edited")] F15_24MAMA f15_24MAMA)
        {
            if (id != f15_24MAMA.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f15_24MAMA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F15_24MAMAExists(f15_24MAMA.ID))
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
            return View(f15_24MAMA);
        }

        // GET: F15_24MAMA15/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f15_24MAMA = await _context.F15_24MAMA
                .FirstOrDefaultAsync(m => m.ID == id);
            if (f15_24MAMA == null)
            {
                return NotFound();
            }

            return View(f15_24MAMA);
        }

        // POST: F15_24MAMA15/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f15_24MAMA = await _context.F15_24MAMA.FindAsync(id);
            _context.F15_24MAMA.Remove(f15_24MAMA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F15_24MAMAExists(int id)
        {
            return _context.F15_24MAMA.Any(e => e.ID == id);
        }
    }
}
