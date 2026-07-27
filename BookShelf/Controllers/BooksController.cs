using BookShelf.Data;
using BookShelf.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext dbContext;
        public BooksController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var books = dbContext.Books.Include(b => b.Author).ToList();

            return View(books);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Authors = await dbContext.Authors
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                })
                .ToListAsync();
            return View();  
        }

        // POST: /Books/Create
        [HttpPost("Books/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            
            if (ModelState.IsValid)
            {
                ViewBag.Authors = await dbContext.Authors
                    .Select(a => new SelectListItem
                    {
                        Value = a.Id.ToString(),
                        Text = a.Name
                    })
                    .ToListAsync();

                return View(nameof(Create));
            }

            dbContext.Books.Add(book);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
            
        }
    }
}
