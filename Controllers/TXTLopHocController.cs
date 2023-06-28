using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CayLapBu.Models;

namespace CayLapBu.Controllers
{
    public class TXTLopHocController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TXTLopHocController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTLopHoc
        public async Task<IActionResult> Index()
        {
              return _context.TXTLopHoc != null ? 
                          View(await _context.TXTLopHoc.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTLopHoc'  is null.");
        }

        // GET: TXTLopHoc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TXTLopHoc == null)
            {
                return NotFound();
            }

            var tXTLopHoc = await _context.TXTLopHoc
                .FirstOrDefaultAsync(m => m.MaLopHoc == id);
            if (tXTLopHoc == null)
            {
                return NotFound();
            }

            return View(tXTLopHoc);
        }

        // GET: TXTLopHoc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTLopHoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLopHoc,TenLophoc")] TXTLopHoc tXTLopHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTLopHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTLopHoc);
        }

        // GET: TXTLopHoc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TXTLopHoc == null)
            {
                return NotFound();
            }

            var tXTLopHoc = await _context.TXTLopHoc.FindAsync(id);
            if (tXTLopHoc == null)
            {
                return NotFound();
            }
            return View(tXTLopHoc);
        }

        // POST: TXTLopHoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MaLopHoc,TenLophoc")] TXTLopHoc tXTLopHoc)
        {
            if (id != tXTLopHoc.MaLopHoc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTLopHoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTLopHocExists(tXTLopHoc.MaLopHoc))
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
            return View(tXTLopHoc);
        }

        // GET: TXTLopHoc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TXTLopHoc == null)
            {
                return NotFound();
            }

            var tXTLopHoc = await _context.TXTLopHoc
                .FirstOrDefaultAsync(m => m.MaLopHoc == id);
            if (tXTLopHoc == null)
            {
                return NotFound();
            }

            return View(tXTLopHoc);
        }

        // POST: TXTLopHoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.TXTLopHoc == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTLopHoc'  is null.");
            }
            var tXTLopHoc = await _context.TXTLopHoc.FindAsync(id);
            if (tXTLopHoc != null)
            {
                _context.TXTLopHoc.Remove(tXTLopHoc);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTLopHocExists(int? id)
        {
          return (_context.TXTLopHoc?.Any(e => e.MaLopHoc == id)).GetValueOrDefault();
        }
    }
}
