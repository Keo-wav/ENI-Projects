﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;

namespace TPDojo1.Controllers
{
    public class WeaponsController : Controller
    {
        private readonly TPDojoContext _context;

        public WeaponsController(TPDojoContext context)
        {
            _context = context;
        }

        // GET: Weapons
        public async Task<IActionResult> Index()
        {
              return _context.Weapon != null ? 
                          View(await _context.Weapon.ToListAsync()) :
                          Problem("Entity set 'TPDojoContext.Weapon'  is null.");
        }

        // GET: Weapons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Weapon == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weapon == null)
            {
                return NotFound();
            }

            return View(weapon);
        }

        // GET: Weapons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Weapons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Damage")] Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weapon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weapon);
        }

        // GET: Weapons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Weapon == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapon.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }
            return View(weapon);
        }

        // POST: Weapons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Damage")] Weapon weapon)
        {
            if (id != weapon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weapon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeaponExists(weapon.Id))
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
            return View(weapon);
        }

        // GET: Weapons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Weapon == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weapon == null)
            {
                return NotFound();
            }

            return View(weapon);
        }

        // POST: Weapons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Weapon == null)
            {
                return Problem("Entity set 'TPDojoContext.Weapon'  is null.");
            }
            var weapon = await _context.Weapon.FindAsync(id);
            if (weapon != null)
            {
                _context.Weapon.Remove(weapon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeaponExists(int id)
        {
          return (_context.Weapon?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}