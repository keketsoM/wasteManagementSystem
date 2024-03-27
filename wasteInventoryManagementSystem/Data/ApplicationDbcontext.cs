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

    }
}
