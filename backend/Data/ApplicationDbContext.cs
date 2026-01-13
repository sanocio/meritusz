using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<InsuranceProduct> InsuranceProducts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Title = "Corporate Insurance", Description = "Comprehensive insurance solutions for businesses", IconClass = "fa-building", DisplayOrder = 1 },
                new Service { Id = 2, Title = "Vehicle Insurance", Description = "Casco, compulsory motor insurance, and travel insurance", IconClass = "fa-car", DisplayOrder = 2 },
                new Service { Id = 3, Title = "Life Insurance", Description = "Protection for you and your family", IconClass = "fa-heart", DisplayOrder = 3 },
                new Service { Id = 4, Title = "Property Insurance", Description = "Insurance for tangible and real estate property", IconClass = "fa-home", DisplayOrder = 4 }
            );

            modelBuilder.Entity<InsuranceProduct>().HasData(
                new InsuranceProduct { Id = 1, Name = "Casco Insurance", Description = "Comprehensive vehicle protection", Category = "Vehicle", Features = "Damage, theft, natural disasters" },
                new InsuranceProduct { Id = 2, Name = "Compulsory Motor Insurance", Description = "Required by law for all vehicles", Category = "Vehicle", Features = "Third party liability coverage" },
                new InsuranceProduct { Id = 3, Name = "Travel Insurance", Description = "Coverage during your travels", Category = "Travel", Features = "Medical, cancellation, baggage" }
            );

            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo 
                { 
                    Id = 1, 
                    CompanyName = "Meritum Biztosítási Alkusz Kft.", 
                    Address = "Szentendre, Bolgár u. 10, 2000", 
                    Phone = "+36 XX XXX XXXX", 
                    Email = "info@meritumalkusz.hu",
                    Website = "https://www.meritumalkusz.hu"
                }
            );

            modelBuilder.Entity<AboutUs>().HasData(
                new AboutUs 
                { 
                    Id = 1, 
                    Title = "About Meritum Biztosítási Alkusz", 
                    Content = "We are a professional insurance brokerage company with decades of experience.",
                    Mission = "To provide the best insurance solutions for our clients at no extra cost.",
                    History = "Operating since 1992 as a licensed insurance broker in Hungary."
                }
            );
        }
    }
}
