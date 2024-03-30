using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace wasteInventoryManagementSystem.Data
{
    public class UsersContext : IdentityDbContext<IdentityUser>
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
            
        }
    }
}
