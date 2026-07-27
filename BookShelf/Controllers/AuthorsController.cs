using BookShelf.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Controllers
{
    public class AuthorsController : Controller
    {
        private ApplicationDbContext _dbContext;
        public AuthorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var authors = _dbContext.Authors.Include(a => a.Books).ToList();

            return View(authors);
        }
        public IActionResult Details(int id)
        {
            var author = _dbContext.Authors.Include(a => a.Books).FirstOrDefault(x => x.Id == id);
                        
            return View(author);
        }
    }
}
