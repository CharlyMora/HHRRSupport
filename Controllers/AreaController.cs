using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HHRRSupport.Models;

namespace HHRRSupport.Controllers
{
    public class AreaController : Controller
    {
        private readonly BusinessContext _context;

        public AreaController(BusinessContext context)
        {
            _context = context;
        }

        // GET: Area
        public async Task<IActionResult> Index()
        {
            return View(await _context.Area.ToListAsync());
        }

        // GET: Area/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _context.Area
                .FirstOrDefaultAsync(m => m.ID == id);
            if (area == null)
            {
                return NotFound();
            }

            return View(area);
        }

        // GET: Area/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Area/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] Area area)
        {
            if (ModelState.IsValid)
            {
                _context.Add(area);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(area);
        }

        // GET: Area/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _context.Area.FindAsync(id);
            if (area == null)
            {
                return NotFound();
            }
            return View(area);
        }

        // POST: Area/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name,Description")] Area area)
        {
            if (id != area.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(area);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaExists(area.ID))
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
            return View(area);
        }

        // GET: Area/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _context.Area
                .FirstOrDefaultAsync(m => m.ID == id);
            if (area == null)
            {
                return NotFound();
            }

            return View(area);
        }

        // POST: Area/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var area = await _context.Area.FindAsync(id);
            _context.Area.Remove(area);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaExists(string id)
        {
            return _context.Area.Any(e => e.ID == id);
        }
    }
}
