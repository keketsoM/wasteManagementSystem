using Microsoft.AspNetCore.Mvc;
using wasteInventoryManagementSystem.Data;
using wasteInventoryManagementSystem.Models;

namespace wasteInventoryManagementSystem.Controllers
{
    public class DonationController : Controller
    {
        public readonly ApplicationDbcontext _db;

        public DonationController(ApplicationDbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<WasteDonation> donationLists = _db.wasteDonations.ToList();
            return View(donationLists);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(WasteDonation donationList)
        {
            if (ModelState.IsValid)
            {
                _db.Add(donationList);
                _db.SaveChanges();
                return View("Index");
            }
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(WasteDonation donationList)
        {

            return View();
        }
    }
}
