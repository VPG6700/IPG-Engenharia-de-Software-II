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
    public class EscalonamentoHorariosController : Controller
    {
        private readonly EscalonamentoContext _context;

        public EscalonamentoHorariosController(EscalonamentoContext context)
        {
            _context = context;
        }

        // GET: EscalonamentoHorarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.EscalonamentoHorario.ToListAsync());
        }

        // GET: EscalonamentoHorarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escalonamentoHorario = await _context.EscalonamentoHorario
                .FirstOrDefaultAsync(m => m.EscalonamentoHorarioId == id);
            if (escalonamentoHorario == null)
            {
                return NotFound();
            }

            return View(escalonamentoHorario);
        }

        // GET: EscalonamentoHorarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EscalonamentoHorarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EscalonamentoHorarioId,Gerar,Visualizar,Imprimir")] EscalonamentoHorario escalonamentoHorario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(escalonamentoHorario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(escalonamentoHorario);
        }

        // GET: EscalonamentoHorarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escalonamentoHorario = await _context.EscalonamentoHorario.FindAsync(id);
            if (escalonamentoHorario == null)
            {
                return NotFound();
            }
            return View(escalonamentoHorario);
        }

        // POST: EscalonamentoHorarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EscalonamentoHorarioId,Gerar,Visualizar,Imprimir")] EscalonamentoHorario escalonamentoHorario)
        {
            if (id != escalonamentoHorario.EscalonamentoHorarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(escalonamentoHorario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EscalonamentoHorarioExists(escalonamentoHorario.EscalonamentoHorarioId))
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
            return View(escalonamentoHorario);
        }

        // GET: EscalonamentoHorarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escalonamentoHorario = await _context.EscalonamentoHorario
                .FirstOrDefaultAsync(m => m.EscalonamentoHorarioId == id);
            if (escalonamentoHorario == null)
            {
                return NotFound();
            }

            return View(escalonamentoHorario);
        }

        // POST: EscalonamentoHorarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var escalonamentoHorario = await _context.EscalonamentoHorario.FindAsync(id);
            _context.EscalonamentoHorario.Remove(escalonamentoHorario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EscalonamentoHorarioExists(int id)
        {
            return _context.EscalonamentoHorario.Any(e => e.EscalonamentoHorarioId == id);
        }
    }
}
