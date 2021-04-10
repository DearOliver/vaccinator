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
    public class InjectionsController : Controller
    {
        private readonly ContextBDD _context = new ContextBDD();

        // GET: Injections
        public async Task<IActionResult> Index()
        {
            return View(await _context.Injection.Include(i => i.Personne).Include(i => i.VaccinType).ToListAsync());
        }

        // GET: Injections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injection.Include(i => i.Personne).Include(i => i.VaccinType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }

            return View(injection);
        }

        // GET: Injections/Create
        public IActionResult Create()
        {
            ViewData["ListeVaccinType"] = new SelectList(_context.VaccinTypes, "Id", "Nom");
            ViewData["ListePersonne"] = new SelectList(_context.Personnes, "Id", "Nom");

            return View();
        }

        // POST: Injections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marque,Reference,PriseDate,RappelDate")] Injection injection, int VaccinType, int Personne)
        {
            var vaccinType = await _context.VaccinTypes.FindAsync(VaccinType);
            injection.VaccinType = vaccinType;

            var personne = await _context.Personnes.FindAsync(Personne);
            injection.Personne = personne;

            ModelState.Clear();
            TryValidateModel(injection);

            if (ModelState.IsValid)
            {
                _context.Add(injection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ListeVaccinType"] = new SelectList(_context.VaccinTypes, "Id", "Nom");
            ViewData["ListePersonne"] = new SelectList(_context.Personnes, "Id", "Nom");

            return View(injection);
        }

        // GET: Injections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injection.FindAsync(id);
            if (injection == null)
            {
                return NotFound();
            }

            ViewData["ListeVaccinType"] = new SelectList(_context.VaccinTypes, "Id", "Nom");
            ViewData["ListePersonne"] = new SelectList(_context.Personnes, "Id", "Nom");

            return View(injection);
        }

        // POST: Injections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marque,Reference,PriseDate,RappelDate")] Injection injection, int VaccinType, int Personne)
        {
            if (id != injection.Id)
            {
                return NotFound();
            }

            var vaccinType = await _context.VaccinTypes.FindAsync(VaccinType);
            injection.VaccinType = vaccinType;

            var personne = await _context.Personnes.FindAsync(Personne);
            injection.Personne = personne;

            ModelState.Clear();
            TryValidateModel(injection);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(injection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InjectionExists(injection.Id))
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

            ViewData["ListeVaccinType"] = new SelectList(_context.VaccinTypes, "Id", "Nom");
            ViewData["ListePersonne"] = new SelectList(_context.Personnes, "Id", "Nom");

            return View(injection);
        }

        // GET: Injections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injection.Include(i => i.Personne).Include(i => i.VaccinType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }

            return View(injection);
        }

        // POST: Injections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var injection = await _context.Injection.FindAsync(id);
            _context.Injection.Remove(injection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InjectionExists(int id)
        {
            return _context.Injection.Any(e => e.Id == id);
        }
    }
}
