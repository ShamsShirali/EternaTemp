using EternaTempl.DataAccessLayer;
using EternaTempl.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTempl.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM
            {
                Features = await _context.Features.Include(c => c.Randm).Where(t => t.IsDeleted == false).ToListAsync(),
                Cards = await _context.Cards.Include(c => c.Randm).Where(c => c.IsDeleted == false).ToListAsync()
            };

            return View(vm);
        }
    }
}
