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
    public class TXTSinhVienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TXTSinhVienController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTSinhVien
        public async Task<IActionResult> Index()
        {
              return _context.TXTSinhVien != null ? 
                          View(await _context.TXTSinhVien.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTSinhVien'  is null.");
        }

        // GET: TXTSinhVien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TXTSinhVien == null)
            {
                return NotFound();
            }

            var tXTSinhVien = await _context.TXTSinhVien
                .FirstOrDefaultAsync(m => m.MaLop == id);
            if (tXTSinhVien == null)
            {
                return NotFound();
            }

            return View(tXTSinhVien);
        }

        // GET: TXTSinhVien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTSinhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLop,TenSV,MaSV")] TXTSinhVien tXTSinhVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTSinhVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTSinhVien);
        }

        // GET: TXTSinhVien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TXTSinhVien == null)
            {
                return NotFound();
            }

            var tXTSinhVien = await _context.TXTSinhVien.FindAsync(id);
            if (tXTSinhVien == null)
            {
                return NotFound();
            }
            return View(tXTSinhVien);
        }

        // POST: TXTSinhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MaLop,TenSV,MaSV")] TXTSinhVien tXTSinhVien)
        {
            if (id != tXTSinhVien.MaLop)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTSinhVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTSinhVienExists(tXTSinhVien.MaLop))
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
            return View(tXTSinhVien);
        }

        // GET: TXTSinhVien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TXTSinhVien == null)
            {
                return NotFound();
            }

            var tXTSinhVien = await _context.TXTSinhVien
                .FirstOrDefaultAsync(m => m.MaLop == id);
            if (tXTSinhVien == null)
            {
                return NotFound();
            }

            return View(tXTSinhVien);
        }

        // POST: TXTSinhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.TXTSinhVien == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTSinhVien'  is null.");
            }
            var tXTSinhVien = await _context.TXTSinhVien.FindAsync(id);
            if (tXTSinhVien != null)
            {
                _context.TXTSinhVien.Remove(tXTSinhVien);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTSinhVienExists(int? id)
        {
          return (_context.TXTSinhVien?.Any(e => e.MaLop == id)).GetValueOrDefault();
        }
    }
}
