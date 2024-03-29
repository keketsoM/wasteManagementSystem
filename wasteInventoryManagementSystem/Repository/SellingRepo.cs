using Bulky.DataAccess.Repository;
using wasteInventoryManagementSystem.Data;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Repository
{
    public class SellingRepo : Repository<WasteSelling>, ISellingRepo
    {
        private ApplicationDbcontext _db;
        public SellingRepo(ApplicationDbcontext db) : base(db)
        {
            _db = db;   
        }

        public void Update(WasteSelling donationList)
        {
            _db.Update(donationList);
        }
    }
}
