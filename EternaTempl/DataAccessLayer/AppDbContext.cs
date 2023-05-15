using EternaTempl.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaTempl.DataAccessLayer

{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Randm> Randms { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
