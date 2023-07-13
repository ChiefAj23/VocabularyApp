using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VocabularyApp.Data;

namespace VocabularyApp.Controllers
{
    public class VocabularyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VocabularyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vocabulary
        public async Task<IActionResult> Index()
        {
              return _context.Vocabulary != null ? 
                          View(await _context.Vocabulary.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Vocabulary'  is null.");
        }

        // GET: Vocabulary/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vocabulary == null)
            {
                return NotFound();
            }

            var vocabulary = await _context.Vocabulary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vocabulary == null)
            {
                return NotFound();
            }

            return View(vocabulary);
        }

        // GET: Vocabulary/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vocabulary/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Word,Definition,Usage,RelatedWords")] Vocabulary vocabulary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vocabulary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vocabulary);
        }

        // GET: Vocabulary/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vocabulary == null)
            {
                return NotFound();
            }

            var vocabulary = await _context.Vocabulary.FindAsync(id);
            if (vocabulary == null)
            {
                return NotFound();
            }
            return View(vocabulary);
        }

        // POST: Vocabulary/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Word,Definition,Usage,RelatedWords")] Vocabulary vocabulary)
        {
            if (id != vocabulary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vocabulary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VocabularyExists(vocabulary.Id))
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
            return View(vocabulary);
        }

        // GET: Vocabulary/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vocabulary == null)
            {
                return NotFound();
            }

            var vocabulary = await _context.Vocabulary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vocabulary == null)
            {
                return NotFound();
            }

            return View(vocabulary);
        }

        // POST: Vocabulary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vocabulary == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Vocabulary'  is null.");
            }
            var vocabulary = await _context.Vocabulary.FindAsync(id);
            if (vocabulary != null)
            {
                _context.Vocabulary.Remove(vocabulary);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VocabularyExists(int id)
        {
          return (_context.Vocabulary?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
