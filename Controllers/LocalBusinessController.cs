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
    public class LocalBusinessController : Controller
    {
        private readonly BusinessContext _context;

        public LocalBusinessController(BusinessContext context)
        {
            _context = context;
        }

        // GET: LocalBusiness
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocalBusiness.ToListAsync());
        }

        public async Task<IActionResult> BuList(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localBusiness = await _context.LocalBusiness.Where(m => m.BusinessId == id).ToListAsync();
            if (localBusiness == null)
            {
                return NotFound();
            }

            return View(localBusiness);
        }

        // GET: LocalBusiness/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localBusiness = await _context.LocalBusiness
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localBusiness == null)
            {
                return NotFound();
            }

            return View(localBusiness);
        }

        // GET: LocalBusiness/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocalBusiness/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CommercialName,LegalName,Country,Region,City,CreationDate,BusinessId")] LocalBusiness localBusiness)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localBusiness);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localBusiness);
        }

        // GET: LocalBusiness/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localBusiness = await _context.LocalBusiness.FindAsync(id);
            if (localBusiness == null)
            {
                return NotFound();
            }

            IList<String> BusinessIds= new List<String>();

            foreach (Business b in _context.Business){
                BusinessIds.Add(b.Id);
            }

            ViewBag.BusinessId= BusinessIds.Select(x=>
                new SelectListItem(){
                    Text = x.ToString()
                }
            );
            return View(localBusiness);
        }

        // POST: LocalBusiness/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,CommercialName,LegalName,Country,Region,City,CreationDate,BusinessId")] LocalBusiness localBusiness)
        {
            if (id != localBusiness.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localBusiness);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalBusinessExists(localBusiness.Id))
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
            return View(localBusiness);
        }

        // GET: LocalBusiness/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localBusiness = await _context.LocalBusiness
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localBusiness == null)
            {
                return NotFound();
            }

            return View(localBusiness);
        }

        // POST: LocalBusiness/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var localBusiness = await _context.LocalBusiness.FindAsync(id);
            _context.LocalBusiness.Remove(localBusiness);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalBusinessExists(string id)
        {
            return _context.LocalBusiness.Any(e => e.Id == id);
        }
    }
}
