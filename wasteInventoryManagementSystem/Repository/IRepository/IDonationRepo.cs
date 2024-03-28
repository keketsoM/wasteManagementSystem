using wasteInventoryManagementSystem.Models;

namespace wasteInventoryManagementSystem.Repository.IRepository
{
    public interface IDonationRepo:IRepository<WasteDonation>
    {
        void Update(WasteDonation donationList);
        
    }
}
