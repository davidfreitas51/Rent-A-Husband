using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentAHusband.Data;
using RentAHusband.Models;

namespace RentAHusband.Controllers
{
    public class MaridoDeAluguelController : Controller
    {
        private readonly RentAHusbandContext _context;

        public MaridoDeAluguelController(RentAHusbandContext context)
        {
            _context = context;
        }

        // GET: MaridoDeAluguels
        public async Task<IActionResult> Index()
        {
            return View(await _context.MaridoDeAluguel.ToListAsync());
        }

        // GET: MaridoDeAluguels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maridoDeAluguel = await _context.MaridoDeAluguel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maridoDeAluguel == null)
            {
                return NotFound();
            }

            return View(maridoDeAluguel);
        }

        // GET: MaridoDeAluguels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaridoDeAluguels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Especialidade,Telefone,Cidade,Estado")] MaridoDeAluguel maridoDeAluguel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maridoDeAluguel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maridoDeAluguel);
        }

        // GET: MaridoDeAluguels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maridoDeAluguel = await _context.MaridoDeAluguel.FindAsync(id);
            if (maridoDeAluguel == null)
            {
                return NotFound();
            }
            return View(maridoDeAluguel);
        }

        // POST: MaridoDeAluguels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Especialidade,Telefone,Cidade,Estado")] MaridoDeAluguel maridoDeAluguel)
        {
            if (id != maridoDeAluguel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maridoDeAluguel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaridoDeAluguelExists(maridoDeAluguel.Id))
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
            return View(maridoDeAluguel);
        }

        // GET: MaridoDeAluguels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maridoDeAluguel = await _context.MaridoDeAluguel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maridoDeAluguel == null)
            {
                return NotFound();
            }

            return View(maridoDeAluguel);
        }

        // POST: MaridoDeAluguels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maridoDeAluguel = await _context.MaridoDeAluguel.FindAsync(id);
            if (maridoDeAluguel != null)
            {
                _context.MaridoDeAluguel.Remove(maridoDeAluguel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaridoDeAluguelExists(int id)
        {
            return _context.MaridoDeAluguel.Any(e => e.Id == id);
        }
    }
}
