using Microsoft.AspNetCore.Mvc;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Controllers
{
    public class BuyingController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public BuyingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<WasteBuying> buyingLists = _unitOfWork.Buying.GetAll(includeProperties: "WeightAndPrice").ToList();
            return View(buyingLists);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(WasteBuying buyingList)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Buying.Add(buyingList);
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
            WasteBuying buyingList = _unitOfWork.Buying.Get(w => w.id == id, includeProperties: "WeightAndPrice");
            if (buyingList == null)
            {
                NotFound();
            }
            return View(buyingList);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            WasteBuying buyingList = _unitOfWork.Buying.Get(w => w.id == id, includeProperties: "WeightAndPrice");
            if (buyingList == null)
            {
                return NotFound();
            }
            _unitOfWork.Buying.Remove(buyingList);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int? id)
        {
            WasteBuying buyingList = _unitOfWork.Buying.Get(w => w.id == id, includeProperties: "WeightAndPrice");
            if (buyingList == null)
            {
                return NotFound();
            }
            return View(buyingList);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            WasteBuying buyingList = _unitOfWork.Buying.Get(w => w.id == id, includeProperties: "WeightAndPrice");
            if (buyingList == null)
            {
                NotFound();
            }
            return View(buyingList);
        }
        [HttpPost]
        public IActionResult Edit(WasteBuying buyingList)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Buying.Update(buyingList);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
