using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BOOK_GENIUS.Models;
using BookGenius.Persistencia;

namespace BOOK_GENIUS.Controllers
{
    public class EditorasController : Controller
    {
        private readonly OracleFIAPDbContext _context;

        public EditorasController(OracleFIAPDbContext context)
        {
            _context = context;
        }

        // GET: Editoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Editoras.ToListAsync());
        }

        // GET: Editoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoras = await _context.Editoras
                .FirstOrDefaultAsync(m => m.EditoraId == id);
            if (editoras == null)
            {
                return NotFound();
            }

            return View(editoras);
        }

        // GET: Editoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EditoraId,Nome,Pais")] Editoras editoras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editoras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editoras);
        }

        // GET: Editoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoras = await _context.Editoras.FindAsync(id);
            if (editoras == null)
            {
                return NotFound();
            }
            return View(editoras);
        }

        // POST: Editoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EditoraId,Nome,Pais")] Editoras editoras)
        {
            if (id != editoras.EditoraId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editoras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorasExists(editoras.EditoraId))
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
            return View(editoras);
        }

        // GET: Editoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoras = await _context.Editoras
                .FirstOrDefaultAsync(m => m.EditoraId == id);
            if (editoras == null)
            {
                return NotFound();
            }

            return View(editoras);
        }

        // POST: Editoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editoras = await _context.Editoras.FindAsync(id);
            if (editoras != null)
            {
                _context.Editoras.Remove(editoras);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorasExists(int id)
        {
            return _context.Editoras.Any(e => e.EditoraId == id);
        }
    }
}
