using EternaTempl.DataAccessLayer;
using EternaTempl.Models;
using EternaTempl.ViewModels.PricingViewM;
using EternaTempl.ViewModels.ServiceViewM;
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
            List<Pricing> pricings = await _context.Pricings.Include(p => p.PricingServices.Where(ps => ps.IsDeleted == false)).Where(c => c.IsDeleted == false).ToListAsync();
            List<Service> services = await _context.Services.Where(s => s.IsDeleted == false).ToListAsync();

            PricingVM pricingvm = new PricingVM
            {
                Pricings = pricings,
                Services = services
            };

            return View(pricingvm);
        }
    }
}
