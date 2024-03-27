using Microsoft.AspNetCore.Mvc;

namespace wasteInventoryManagementSystem.Controllers
{
    public class SellingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
