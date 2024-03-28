using wasteInventoryManagementSystem.Data;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbcontext _db;
        public UnitOfWork(ApplicationDbcontext db)
        {
            _db = db;
            Donation=new DonationRepo(_db);
        }
        public IDonationRepo Donation {
            get;
            set;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
