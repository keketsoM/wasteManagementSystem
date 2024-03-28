namespace wasteInventoryManagementSystem.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IDonationRepo Donation { get; }

        void Save();
    }
}
