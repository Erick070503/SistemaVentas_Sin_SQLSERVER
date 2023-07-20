using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DetalleventasController : Controller
    {
        private readonly WebApplication4Context _context;

        public DetalleventasController(WebApplication4Context context)
        {
            _context = context;
        }

        // GET: Detalleventas
        public async Task<IActionResult> Index()
        {
              return _context.Detalleventa != null ? 
                          View(await _context.Detalleventa.ToListAsync()) :
                          Problem("Entity set 'WebApplication4Context.Detalleventa'  is null.");
        }

        // GET: Detalleventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Detalleventa == null)
            {
                return NotFound();
            }

            var detalleventa = await _context.Detalleventa
                .FirstOrDefaultAsync(m => m.Idnumdocumento == id);
            if (detalleventa == null)
            {
                return NotFound();
            }

            return View(detalleventa);
        }

        // GET: Detalleventas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Detalleventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idnumdocumento,Serie,Idproducto,Cantidad,Precio")] Detalleventa detalleventa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleventa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detalleventa);
        }

        // GET: Detalleventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Detalleventa == null)
            {
                return NotFound();
            }

            var detalleventa = await _context.Detalleventa.FindAsync(id);
            if (detalleventa == null)
            {
                return NotFound();
            }
            return View(detalleventa);
        }

        // POST: Detalleventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idnumdocumento,Serie,Idproducto,Cantidad,Precio")] Detalleventa detalleventa)
        {
            if (id != detalleventa.Idnumdocumento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleventa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleventaExists(detalleventa.Idnumdocumento))
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
            return View(detalleventa);
        }

        // GET: Detalleventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Detalleventa == null)
            {
                return NotFound();
            }

            var detalleventa = await _context.Detalleventa
                .FirstOrDefaultAsync(m => m.Idnumdocumento == id);
            if (detalleventa == null)
            {
                return NotFound();
            }

            return View(detalleventa);
        }

        // POST: Detalleventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Detalleventa == null)
            {
                return Problem("Entity set 'WebApplication4Context.Detalleventa'  is null.");
            }
            var detalleventa = await _context.Detalleventa.FindAsync(id);
            if (detalleventa != null)
            {
                _context.Detalleventa.Remove(detalleventa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleventaExists(int id)
        {
          return (_context.Detalleventa?.Any(e => e.Idnumdocumento == id)).GetValueOrDefault();
        }
    }
}
