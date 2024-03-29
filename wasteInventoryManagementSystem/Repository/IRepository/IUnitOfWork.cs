namespace wasteInventoryManagementSystem.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IDonationRepo Donation { get; }
        IBuyingRepo Buying { get; }
        ISellingRepo Selling { get; }

        void Save();
    }
}
