﻿using Bulky.DataAccess.Repository;
using wasteInventoryManagementSystem.Data;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Repository
{
    public class DonationRepo : Repository<WasteDonation>, IDonationRepo
    {
        private readonly ApplicationDbcontext _db;
        public DonationRepo(ApplicationDbcontext db) : base(db)
        {
            _db = db;   
        }

       public void Update(WasteDonation donationList)
        {
            _db.Update(donationList);
        }
    }
}
