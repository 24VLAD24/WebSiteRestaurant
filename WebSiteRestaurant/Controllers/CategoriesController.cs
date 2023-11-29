using Humanizer.Localisation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSiteRestaurant.Models;
using WebSiteRestaurant.Models.Data;
using WebSiteRestaurant.ViewModels.Categories;

namespace WebSiteRestaurant.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly AppCtx _context;
        private readonly UserManager<User> _userManager;

        public CategoriesController(AppCtx context,
            UserManager<User> user)
        {
            _context = context;
            _userManager = user;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {

            var appCtx = _context.Categories
                .OrderBy(f => f.CategoryName);

              return _context.Categories != null ? 
                          View(await _context.Categories.ToListAsync()) :
                          Problem("Entity set 'AppCtx.Categories'  is null.");
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCategoriesViewModel model)
        {

            if (_context.Categories
                .Where(f => f.CategoryName == model.CategoryName)
                .FirstOrDefault() != null)
            {
                ModelState.AddModelError("", "Введеная категория уже существует");
            }

            if (ModelState.IsValid)
            {
                Category category= new()
                {
                    CategoryName = model.CategoryName
                };

                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            
            if (category == null)
            {
                return NotFound();
            }

            EditCategoriesViewModel model = new()
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };

            return View(model);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, EditCategoriesViewModel model)
        {

            Category category = await _context.Categories.FindAsync(id);

            if (id != category.Id)
            {
                return NotFound();
            }

            if (_context.Categories
              .Where(f => f.CategoryName == model.CategoryName)
              .FirstOrDefault() != null)
            {
                ModelState.AddModelError("", "Введеная категория уже существует");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    category.CategoryName = model.CategoryName;
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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

            return View(model);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'AppCtx.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(byte id)
        {
          return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
