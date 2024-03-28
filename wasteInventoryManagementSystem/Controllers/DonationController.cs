using Microsoft.AspNetCore.Mvc;
using wasteInventoryManagementSystem.Data;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Controllers
{
    public class DonationController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public DonationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }
        public IActionResult Index()
        {
            List<WasteDonation> donationLists = _unitOfWork.Donation.GetAll().ToList();
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
                _unitOfWork.Donation.Add(donationList);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            WasteDonation donationList = _unitOfWork.Donation.Get(w => w.Id == id);
            if (donationList == null)
            {
                NotFound();
            }
            return View(donationList);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            WasteDonation donationList = _unitOfWork.Donation.Get(w => w.Id == id);
            if (donationList == null)
            {
                return NotFound();
            }
            _unitOfWork.Donation.Remove(donationList);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int? id)
        {
            WasteDonation donationList = _unitOfWork.Donation.Get(w => w.Id == id);
            if (donationList == null)
            {
                return NotFound();
            }
            return View(donationList);
        }
       

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            WasteDonation donationList = _unitOfWork.Donation.Get(w => w.Id == id);
            if (donationList == null)
            {
                NotFound();
            }
            return View(donationList);
        }
        [HttpPost]
        public IActionResult Edit(WasteDonation donationList)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Donation.Update(donationList);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
