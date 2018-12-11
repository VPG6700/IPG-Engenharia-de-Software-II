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
    public class VeiculoController : Controller
    {
        private readonly EscalonamentoContext _context;

        public VeiculoController(EscalonamentoContext context)
        {
            _context = context;
        }

        // GET: Veiculo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Veiculos.ToListAsync());
        }

        // GET: Veiculo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculos = await _context.Veiculos
                .FirstOrDefaultAsync(m => m.VeiculosId == id);
            if (veiculos == null)
            {
                return NotFound();
            }

            return View(veiculos);
        }

        // GET: Veiculo/Create
        public IActionResult Create()
        {
            ViewData["Marca"] = new SelectList(_context.Marca, "MarcaId", "Nome");
            return View();
        }

        // POST: Veiculo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VeiculosId,MarcaId,NumMatricula,Disponibilidade")] Veiculos veiculos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veiculos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Marca"] = new SelectList(_context.Marca, "MarcaId", "Nome", veiculos.MarcaId);
            return View(veiculos);
        }

        // GET: Veiculo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculos = await _context.Veiculos.FindAsync(id);
            if (veiculos == null)
            {
                return NotFound();
            }
            ViewData["Marca"] = new SelectList(_context.Marca, "MarcaId", "Nome");
            return View(veiculos);
        }

        // POST: Veiculo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VeiculosId,MarcaId,NumMatricula,Disponibilidade")] Veiculos veiculos)
        {
            if (id != veiculos.VeiculosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veiculos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculosExists(veiculos.VeiculosId))
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
            ViewData["Marca"] = new SelectList(_context.Marca, "MarcaId", "Nome", veiculos.MarcaId);
            return View(veiculos);
        }

        // GET: Veiculo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculos = await _context.Veiculos
                .FirstOrDefaultAsync(m => m.VeiculosId == id);
            if (veiculos == null)
            {
                return NotFound();
            }

            return View(veiculos);
        }

        // POST: Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veiculos = await _context.Veiculos.FindAsync(id);
            _context.Veiculos.Remove(veiculos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculosExists(int id)
        {
            return _context.Veiculos.Any(e => e.VeiculosId == id);
        }
    }
}
