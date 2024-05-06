using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDBContext _context;

        public MovieController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n=>n.Cinema).ToListAsync();
            return View(allMovies);
        }
    }
}
