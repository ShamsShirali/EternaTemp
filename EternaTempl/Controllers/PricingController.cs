using EternaTempl.DataAccessLayer;
using EternaTempl.ViewModels.Pricing;
using EternaTempl.ViewModels.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTempl.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            PricingVM vm = new PricingVM
            {
                PricingServices = await _context.PricingServices.Include(c => c.Service).Include(c => c.Pricing).Where(c => c.IsDeleted == false).ToListAsync(),
            };

            return View(vm);
        }
    }
}
