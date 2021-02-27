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
    public class CampusController : Controller
    {
        private readonly BusinessContext _context;

        public CampusController(BusinessContext context)
        {
            _context = context;
        }

        // GET: Campus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campus.ToListAsync());
        }
        //Campuses for a specific LocalBusiness 
        //(i don't know if campuses is correctly spell)
        public async Task<IActionResult> CampList(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campuses = await _context.Campus
                .Where(m => m.LocalBusinessId == id).ToListAsync();
            if (campuses == null)
            {
                return NotFound();
            }
            ViewBag.LBId= id;
            return View(campuses);
        }

        // GET: Campus/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campus = await _context.Campus
                .FirstOrDefaultAsync(m => m.ID == id);
            if (campus == null)
            {
                return NotFound();
            }

            return View(campus);
        }

        // GET: Campus/Create
        public IActionResult Create()
        {
            ViewBag.LocalBusinessId = GetLocalBusinessIds();
            return View();
        }

        // POST: Campus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,City,Adress,CreationDate,LocalBusinessId")] Campus campus)
        {
            if (ModelState.IsValid)
            {
                //verification of repeated id
                foreach(Campus c in _context.Campus){
                    if(c.ID == campus.ID){
                        //In case of a repeated Id viewbag needs to be reloaded
                        ViewBag.LocalBusinessId = GetLocalBusinessIds();
                        ViewBag.IdAlreadyExists="ID ya existe, porfavor intente otro ID";
                        return View();
                    }
                }
                //no repeated id and model is valid
                ViewBag.IdAlreadyExists="";
                _context.Add(campus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campus);
        }

        // GET: Campus/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campus = await _context.Campus.FindAsync(id);
            if (campus == null)
            {
                return NotFound();
            }
            ViewBag.LocalBusinessId = GetLocalBusinessIds();
            return View(campus);
        }

        // POST: Campus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name,City,Adress,CreationDate,LocalBusinessId")] Campus campus)
        {
            if (id != campus.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampusExists(campus.ID))
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
            return View(campus);
        }

        // GET: Campus/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campus = await _context.Campus
                .FirstOrDefaultAsync(m => m.ID == id);
            if (campus == null)
            {
                return NotFound();
            }

            return View(campus);
        }

        // POST: Campus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var campus = await _context.Campus.FindAsync(id);
            _context.Campus.Remove(campus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampusExists(string id)
        {
            return _context.Campus.Any(e => e.ID == id);
        }
        ///<summary>
        ///Genera la lista de IDs para los negocios locales
        ///que sera usada en lsa vistas de edicion y creacion
        ///</summary>
        ///<param name="z">parametro de regreso</param>
        ///<returns>lista de regreso</returns>
        
        private dynamic GetLocalBusinessIds()
        {
            IList<String> LocalBusinessIds = new List<String>();
            string emp = "";
            LocalBusinessIds.Add(emp);
            foreach (LocalBusiness b in _context.LocalBusiness)
            {
                LocalBusinessIds.Add(b.Id);
            }
            dynamic z = LocalBusinessIds.Select(x =>
                new SelectListItem()
                {
                    Text = x.ToString()
                }
            );
            return(z);
        }
    }
}
