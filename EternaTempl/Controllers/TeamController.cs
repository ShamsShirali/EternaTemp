using EternaTempl.DataAccessLayer;
using EternaTempl.ViewModels.Service;
using EternaTempl.ViewModels.Team;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTempl.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            TeamVM vm = new TeamVM
            {
                Trainers = await _context.Trainers.Include(c => c.Category).Where(c => c.IsDeleted == false).ToListAsync()
            };

            return View(vm);
        }
    }
}
