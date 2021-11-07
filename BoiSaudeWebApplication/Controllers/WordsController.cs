using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoiSaudeWebApplication.Models;

namespace BoiSaudeWebApplication.Controllers
{
    public class WordsController : Controller
    {
        private readonly WordsContext _context;

        public WordsController(WordsContext context)
        {
            _context = context;
        }

        // GET: Words
        public async Task<IActionResult> Index()
        {
            return View(await _context.Words.ToListAsync());
        }


        // GET: Words/AddOrEdit
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Words());
            else
                return View(_context.Words.Find(id));
            
        }

        // POST: Words/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("WordsId,Description")] Words words)
        {
            if (ModelState.IsValid)
            {
                if (words.WordsId == 0)
                    _context.Add(words);
                else
                    _context.Update(words);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                
            }
            return View(words);
        }


        // GET: Words/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var words = await _context.Words.FindAsync(id);
            _context.Words.Remove(words);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
