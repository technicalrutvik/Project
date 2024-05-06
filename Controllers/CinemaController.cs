using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDBContext _context;

        public CinemaController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCienemas = await _context.Cinemas.ToListAsync();
            return View(allCienemas);
        }
    }
}
