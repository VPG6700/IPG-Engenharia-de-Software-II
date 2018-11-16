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
    public class medicosController : Controller
    {
        private readonly EscalonamentoContext _context;

        public medicosController(EscalonamentoContext context)
        {
            _context = context;
        }

        // GET: medicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.medico.ToListAsync());
        }

        // GET: medicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.medico
                .FirstOrDefaultAsync(m => m.MedicoID == id);
            if (medico == null)
            {
                return NotFound();
            }

            return View(medico);
        }

        // GET: medicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: medicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicoID,Nome,NumMatricula,Disponibilidade")] medico medico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medico);
        }

        // GET: medicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.medico.FindAsync(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        // POST: medicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicoID,Nome,NumMatricula,Disponibilidade")] medico medico)
        {
            if (id != medico.MedicoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!medicoExists(medico.MedicoID))
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
            return View(medico);
        }

        // GET: medicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.medico
                .FirstOrDefaultAsync(m => m.MedicoID == id);
            if (medico == null)
            {
                return NotFound();
            }

            return View(medico);
        }

        // POST: medicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medico = await _context.medico.FindAsync(id);
            _context.medico.Remove(medico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool medicoExists(int id)
        {
            return _context.medico.Any(e => e.MedicoID == id);
        }
    }
}
