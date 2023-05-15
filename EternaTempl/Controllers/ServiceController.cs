using EternaTempl.DataAccessLayer;
using EternaTempl.ViewModels.Home;
using EternaTempl.ViewModels.ServiceViewM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTempl.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ServiceVM vm = new ServiceVM
            {
                Cards = await _context.Cards.Include(c => c.Randm).Where(c => c.IsDeleted == false).ToListAsync()
            };

            return View(vm);
        }
    }
}
