using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;

namespace TPDojo1.Controllers
{
    public class SamuraisController : Controller
    {
        private readonly TPDojoContext _context;

        public SamuraisController(TPDojoContext context)
        {
            _context = context;
        }

        // GET: Samurais
        public async Task<IActionResult> Index()
        {
              return _context.Samurai != null ? 
                          View(await _context.Samurai.ToListAsync()) :
                          Problem("Entity set 'TPDojoContext.Samurai'  is null.");
        }

        // GET: Samurais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samurai == null)
            {
                return NotFound();
            }

            return View(samurai);
        }

        // GET: Samurais/Create
        public IActionResult Create()
        {
            var samuraiVM = new Samurai
            {
                
            };
            return View(samuraiVM);
        }

        // POST: Samurais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Strength")] Samurai samurai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(samurai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(samurai);
        }

        // GET: Samurais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai.FindAsync(id);
            if (samurai == null)
            {
                return NotFound();
            }
            return View(samurai);
        }

        // POST: Samurais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Strength")] Samurai samurai)
        {
            if (id != samurai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(samurai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SamuraiExists(samurai.Id))
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
            return View(samurai);
        }

        // GET: Samurais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samurai == null)
            {
                return NotFound();
            }

            return View(samurai);
        }

        // POST: Samurais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Samurai == null)
            {
                return Problem("Entity set 'TPDojoContext.Samurai'  is null.");
            }
            var samurai = await _context.Samurai.FindAsync(id);
            if (samurai != null)
            {
                _context.Samurai.Remove(samurai);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SamuraiExists(int id)
        {
          return (_context.Samurai?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
