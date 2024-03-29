using wasteInventoryManagementSystem.Models;

namespace wasteInventoryManagementSystem.Repository.IRepository
{
    public interface ISellingRepo:IRepository<WasteSelling>
    {
        void Update(WasteSelling donationList);
        
    }
}
