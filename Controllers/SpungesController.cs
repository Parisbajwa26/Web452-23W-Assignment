using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spunges.Data;
using Spunges.Models;

namespace Spunges.Controllers
{
    public class SpungesController : Controller
    {
        private readonly SpungesContext _context;

        public SpungesController(SpungesContext context)
        {
            _context = context;
        }

        // GET: Spunges
        public async Task<IActionResult> Index()
        {
            return View(await _context.Spunge.ToListAsync());
        }

        // GET: Spunges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spunge = await _context.Spunge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spunge == null)
            {
                return NotFound();
            }

            return View(spunge);
        }

        // GET: Spunges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spunges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Material,Color,Shape,Rating,Price")] Spunge spunge)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spunge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spunge);
        }

        // GET: Spunges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spunge = await _context.Spunge.FindAsync(id);
            if (spunge == null)
            {
                return NotFound();
            }
            return View(spunge);
        }

        // POST: Spunges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Material,Color,Shape,Rating,Price")] Spunge spunge)
        {
            if (id != spunge.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spunge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpungeExists(spunge.Id))
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
            return View(spunge);
        }

        // GET: Spunges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spunge = await _context.Spunge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spunge == null)
            {
                return NotFound();
            }

            return View(spunge);
        }

        // POST: Spunges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spunge = await _context.Spunge.FindAsync(id);
            _context.Spunge.Remove(spunge);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpungeExists(int id)
        {
            return _context.Spunge.Any(e => e.Id == id);
        }
    }
}
