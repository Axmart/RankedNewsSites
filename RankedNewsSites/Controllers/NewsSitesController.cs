using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RankedNewsSites.Data;
using RankedNewsSites.Models;

namespace RankedNewsSites.Controllers
{
    public class NewsSitesController : Controller
    {
        private readonly RankedNewsSitesContext _context;

        public NewsSitesController(RankedNewsSitesContext context)
        {
            _context = context;
        }

        // GET: NewsSites
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewsSite.ToListAsync());
        }

        // GET: NewsSites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsSite = await _context.NewsSite
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsSite == null)
            {
                return NotFound();
            }

            return View(newsSite);
        }

        // GET: NewsSites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewsSites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Url,PictureSource,Points")] NewsSite newsSite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsSite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newsSite);
        }

        // GET: NewsSites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsSite = await _context.NewsSite.FindAsync(id);
            if (newsSite == null)
            {
                return NotFound();
            }
            return View(newsSite);
        }

        // POST: NewsSites/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Url,PictureSource,Points")] NewsSite newsSite)
        {
            if (id != newsSite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsSite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsSiteExists(newsSite.Id))
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
            return View(newsSite);
        }

        // GET: NewsSites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsSite = await _context.NewsSite
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsSite == null)
            {
                return NotFound();
            }

            return View(newsSite);
        }

        // POST: NewsSites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newsSite = await _context.NewsSite.FindAsync(id);
            _context.NewsSite.Remove(newsSite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsSiteExists(int id)
        {
            return _context.NewsSite.Any(e => e.Id == id);
        }
    }
}
