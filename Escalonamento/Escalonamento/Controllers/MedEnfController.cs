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
    public class MedEnfController : Controller
    {
        private readonly EscalonamentoContext _context;

        public MedEnfController(EscalonamentoContext context)
        {
            _context = context;
        }

        // GET: MedEnf
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedEnf.ToListAsync());
        }

        // GET: MedEnf/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medEnf = await _context.MedEnf
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medEnf == null)
            {
                return NotFound();
            }

            return View(medEnf);
        }

        // GET: MedEnf/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedEnf/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNasc,Funcao,Telemovel,Observacoes")] MedEnf medEnf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medEnf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medEnf);
        }

        // GET: MedEnf/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medEnf = await _context.MedEnf.FindAsync(id);
            if (medEnf == null)
            {
                return NotFound();
            }
            return View(medEnf);
        }

        // POST: MedEnf/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNasc,Funcao,Telemovel,Observacoes")] MedEnf medEnf)
        {
            if (id != medEnf.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medEnf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedEnfExists(medEnf.Id))
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
            return View(medEnf);
        }

        // GET: MedEnf/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medEnf = await _context.MedEnf
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medEnf == null)
            {
                return NotFound();
            }

            return View(medEnf);
        }

        // POST: MedEnf/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medEnf = await _context.MedEnf.FindAsync(id);
            _context.MedEnf.Remove(medEnf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedEnfExists(int id)
        {
            return _context.MedEnf.Any(e => e.Id == id);
        }
    }
}
