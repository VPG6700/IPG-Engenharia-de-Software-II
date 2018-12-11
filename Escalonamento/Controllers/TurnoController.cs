using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Escalonamento.Models;

namespace Escalonamento.Controllers
{
    public class TurnoController : Controller
    {
        private readonly EscalonamentoContext _context;

        public TurnoController(EscalonamentoContext context)
        {
            _context = context;
        }

        // GET: Turno
        public async Task<IActionResult> Index()
        {
            return View(await _context.Turno.ToListAsync());
        }

        // GET: Turno/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnos = await _context.Turno
                .FirstOrDefaultAsync(m => m.TurnoId == id);
            if (turnos == null)
            {
                return NotFound();
            }

            return View(turnos);
        }

        // GET: Turno/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Turno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TurnoId,Nome,HoraInicio,HoraFim")] Turno turnos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(turnos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(turnos);
        }

        // GET: Turno/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnos = await _context.Turno.FindAsync(id);
            if (turnos == null)
            {
                return NotFound();
            }
            return View(turnos);
        }

        // POST: Turno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TurnoId,Nome,HoraInicio,HoraFim")] Turno turnos)
        {
            if (id != turnos.TurnoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turnos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurnosExists(turnos.TurnoId))
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
            return View(turnos);
        }

        // GET: Turno/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnos = await _context.Turno
                .FirstOrDefaultAsync(m => m.TurnoId == id);
            if (turnos == null)
            {
                return NotFound();
            }

            return View(turnos);
        }

        // POST: Turno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var turnos = await _context.Turno.FindAsync(id);
            _context.Turno.Remove(turnos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurnosExists(int id)
        {
            return _context.Turno.Any(e => e.TurnoId == id);
        }
    }
}
