using wasteInventoryManagementSystem.Models;

namespace wasteInventoryManagementSystem.Repository.IRepository
{
    public interface IBuyingRepo:IRepository<WasteBuying>
    {
        void Update(WasteBuying donationList);
        
    }
}
