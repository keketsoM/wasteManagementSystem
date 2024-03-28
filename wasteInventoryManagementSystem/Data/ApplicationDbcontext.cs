using Microsoft.EntityFrameworkCore;
using wasteInventoryManagementSystem.Models;

namespace wasteInventoryManagementSystem.Data
{
    public class ApplicationDbcontext : DbContext
    {

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {



        }

        public DbSet<WasteBuying> wasteBuyings { get; set; }
        public DbSet<WasteDonation> wasteDonations { get; set; }

        public DbSet<WasteSelling> wasteSellings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<WasteDonation>().HasData(
                new WasteDonation {Id=1, BusinessName="keke shop", ContactPerson="kk",ContactNumber="0658775412", WeightAndPriceId=1 },
                 new WasteDonation { Id = 2, BusinessName = "L shop", ContactPerson = "ks", ContactNumber = "0658777862", WeightAndPriceId = 2 },
                  new WasteDonation { Id = 3, BusinessName = "M shop", ContactPerson = "kl", ContactNumber = "0846775412", WeightAndPriceId = 3 }
                );

            modelBuilder.Entity<WeightAndPrice>().HasData(
               new WeightAndPrice { Id = 1, GlassBottlesWeight =1.00, GlassBottlesPrice = 5.00, MetalsWeight=1.00, MetalsPrice=10.00, PlasticWeight=1.00, PlasticPrice=1.00, CardboardWeight=1.00, CardboardPrice=0.50, AluminumCansWeight=1.00, AluminumCansPrice=2.00,TotalSalePrice=50.00, Totalweight=50.00 },
               new WeightAndPrice { Id = 2, GlassBottlesWeight = 2.00, GlassBottlesPrice = 10.00, MetalsWeight = 2.00, MetalsPrice = 20.00, PlasticWeight = 2.00, PlasticPrice = 2.00, CardboardWeight = 2.00, CardboardPrice = 1.00, AluminumCansWeight = 2.00, AluminumCansPrice = 4.00, TotalSalePrice = 100.00, Totalweight = 100.00 },
               new WeightAndPrice { Id = 3, GlassBottlesWeight = 3.00, GlassBottlesPrice = 15.00, MetalsWeight = 3.00, MetalsPrice = 30.00, PlasticWeight = 3.00, PlasticPrice = 3.00, CardboardWeight = 3.00, CardboardPrice = 1.50, AluminumCansWeight = 3.00, AluminumCansPrice = 6.00, TotalSalePrice = 150.00, Totalweight = 150.00 }
               );
        }

    }
}


