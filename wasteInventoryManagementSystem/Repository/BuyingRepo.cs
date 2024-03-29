using Bulky.DataAccess.Repository;
using wasteInventoryManagementSystem.Data;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Repository
{
    public class BuyingRepo : Repository<WasteBuying>, IBuyingRepo
    {
        private readonly ApplicationDbcontext _db;
        public BuyingRepo(ApplicationDbcontext db) : base(db)
        {
            _db = db;   
        }
        public void Update(WasteBuying donationList)
        {
            _db.Update(donationList);
        }
    }
}
