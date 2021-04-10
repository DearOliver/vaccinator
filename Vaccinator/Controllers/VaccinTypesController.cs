using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vaccinator.Models;

namespace Vaccinator.Controllers
{
    public class VaccinTypesController : Controller
    {
        private readonly ContextBDD _context = new ContextBDD();

        // GET: VaccinTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VaccinType.ToListAsync());
        }

        // GET: VaccinTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccinType = await _context.VaccinType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaccinType == null)
            {
                return NotFound();
            }

            return View(vaccinType);
        }

        // GET: VaccinTypes/NonVaccinesThisYear/5
        public async Task<IActionResult> NonVaccinesThisYear(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccinType = await _context.VaccinType
                .FirstOrDefaultAsync(m => m.Id == id);

            if (vaccinType == null)
            {
                return NotFound();
            }

            ViewData["NomVaccin"] = vaccinType.Nom;

            var ListeVaccine = await _context.Personne.ToListAsync();

            foreach(Personne vaccine in ListeVaccine.ToList())
            {
                var ListeInjections = await _context.Injection.Include(i => i.Personne).Include(i => i.VaccinType).Where(i => i.Personne.Id == vaccine.Id).ToListAsync();

                foreach (Injection injection in ListeInjections)
                {
                    if (injection.VaccinType.Id == vaccinType.Id && injection.PriseDate.Year == DateTime.Today.Year)
                    {
                        ListeVaccine.Remove(vaccine);
                    }
                }
            }

            return View(ListeVaccine);
        }

        // GET: VaccinTypes/NonVaccines/5
        public async Task<IActionResult> NonVaccines(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccinType = await _context.VaccinType
                .FirstOrDefaultAsync(m => m.Id == id);

            if (vaccinType == null)
            {
                return NotFound();
            }

            ViewData["NomVaccin"] = vaccinType.Nom;

            var ListeVaccine = await _context.Personne.ToListAsync();

            foreach (Personne vaccine in ListeVaccine.ToList())
            {
                var ListeInjections = await _context.Injection.Include(i => i.Personne).Include(i => i.VaccinType).Where(i => i.Personne.Id == vaccine.Id).ToListAsync();

                foreach (Injection injection in ListeInjections)
                {
                    if (injection.VaccinType.Id == vaccinType.Id)
                    {
                        ListeVaccine.Remove(vaccine);
                    }
                }
            }

            return View(ListeVaccine);
        }

        // GET: VaccinTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VaccinTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Cible,DiscoveryYear")] VaccinType vaccinType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccinType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccinType);
        }

        // GET: VaccinTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccinType = await _context.VaccinType.FindAsync(id);
            if (vaccinType == null)
            {
                return NotFound();
            }
            return View(vaccinType);
        }

        // POST: VaccinTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Cible,DiscoveryYear")] VaccinType vaccinType)
        {
            if (id != vaccinType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaccinType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaccinTypeExists(vaccinType.Id))
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
            return View(vaccinType);
        }

        // GET: VaccinTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccinType = await _context.VaccinType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaccinType == null)
            {
                return NotFound();
            }

            return View(vaccinType);
        }

        // POST: VaccinTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaccinType = await _context.VaccinType.FindAsync(id);
            _context.VaccinType.Remove(vaccinType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaccinTypeExists(int id)
        {
            return _context.VaccinType.Any(e => e.Id == id);
        }
    }
}
