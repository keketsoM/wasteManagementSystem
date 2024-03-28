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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WasteDonation>().HasData(
                new WasteDonation {Id=1, BusinessName="keke shop", ContactPerson="kk",ContactNumber="0658775412" },
                 new WasteDonation { Id = 2, BusinessName = "L shop", ContactPerson = "ks", ContactNumber = "0658777862" },
                  new WasteDonation { Id = 3, BusinessName = "M shop", ContactPerson = "kl", ContactNumber = "0846775412" }
                );   
        }

    }
}
