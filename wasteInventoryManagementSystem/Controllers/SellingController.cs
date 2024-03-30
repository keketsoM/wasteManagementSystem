using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;

namespace wasteInventoryManagementSystem.Controllers
{
    [Authorize]
    public class SellingController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public SellingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<WasteSelling> sellingLists = _unitOfWork.Selling.GetAll(includeProperties: "WeightAndPrice").ToList();
            return View(sellingLists);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(WasteSelling sellingLists)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Selling.Add(sellingLists);
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
            WasteSelling sellingLists = _unitOfWork.Selling.Get(w => w.Id == id, includeProperties: "WeightAndPrice");
            if (sellingLists == null)
            {
                NotFound();
            }
            return View(sellingLists);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            WasteSelling sellingLists = _unitOfWork.Selling.Get(w => w.Id == id, includeProperties: "WeightAndPrice");
            if (sellingLists == null)
            {
                return NotFound();
            }
            _unitOfWork.Selling.Remove(sellingLists);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int? id)
        {
            WasteSelling sellingLists = _unitOfWork.Selling.Get(w => w.Id == id, includeProperties: "WeightAndPrice");
            if (sellingLists == null)
            {
                return NotFound();
            }
            return View(sellingLists);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            WasteSelling sellingLists = _unitOfWork.Selling.Get(w => w.Id == id, includeProperties: "WeightAndPrice");
            if (sellingLists == null)
            {
                NotFound();
            }
            return View(sellingLists);
        }
        [HttpPost]
        public IActionResult Edit(WasteSelling sellingLists)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Selling.Update(sellingLists);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
