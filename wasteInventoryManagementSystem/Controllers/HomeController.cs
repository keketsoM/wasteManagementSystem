using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

using wasteInventoryManagementSystem.Enums;
using wasteInventoryManagementSystem.Models;
using wasteInventoryManagementSystem.Repository.IRepository;
using wasteInventoryManagementSystem.ViewModel;

namespace wasteInventoryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PersonalInformation()
        {
            var enumSelectList = new SelectList(Enum.GetValues(typeof(TypeEnum))
                                               .Cast<TypeEnum>()
                                               .Select(e => new SelectListItem
                                               {
                                                   Text = e.ToString(),
                                                   Value = e.ToString()
                                               }), "Value", "Text");

           
            return View();
        }
        [HttpPost,ActionName("PersonalInformation")]
        public IActionResult PersonalInformationPost(PersonalInformationVM personalInformationVM)
        {
            HttpContext.Session.SetString("PersonalInformationVM", JsonConvert.SerializeObject(personalInformationVM));

            return RedirectToAction("WasteType");
           
        }

        [HttpGet, ActionName("WasteType")]
        public IActionResult WasteType() 
        {
            string serializedData = HttpContext.Session.GetString("PersonalInformationVM");
            if (!string.IsNullOrEmpty(serializedData))
            {
                var personalInformationVM = JsonConvert.DeserializeObject<PersonalInformationVM>(serializedData);
                return View(personalInformationVM);
            }
            return RedirectToAction("PersonalInformation");
        }

        [HttpPost,ActionName("WasteType")]
        public IActionResult WasteTypePost(PersonalInformationVM personalInformationVM)
        {
            if (ModelState.IsValid)
            {
                if (personalInformationVM.buying != null)
                {
                    //var buying = new WasteBuying
                    //{
                    //    //Name = personalInformationVM.donationInput.Name,
                    //    //ContactPerson = personalInformationVM.donationInput.ContactPerson,
                    //    //ContactNumber = personalInformationVM.donationInput.ContactNumber,
                        
                    //    WeightAndPrice = new WeightAndPrice
                    //    {
                    //        GlassBottlesWeight = personalInformationVM.donationInput.GlassBottlesWeight,
                    //        GlassBottlesPrice = personalInformationVM.donationInput.GlassBottlesPrice,

                    //        MetalsWeight = personalInformationVM.donationInput.MetalsWeight,
                    //        MetalsPrice = personalInformationVM.donationInput.MetalsPrice,

                    //        PlasticWeight = personalInformationVM.donationInput.PlasticWeight,
                    //        PlasticPrice = personalInformationVM.donationInput.PlasticPrice,

                    //        PaperWeight = personalInformationVM.donationInput.PaperWeight,
                    //        PaperPrice = personalInformationVM.donationInput.PaperPrice,

                    //        CardboardWeight = personalInformationVM.donationInput.CardboardWeight,
                    //        CardboardPrice = personalInformationVM.donationInput.CardboardPrice,

                    //        AluminumCansWeight = personalInformationVM.donationInput.AluminumCansWeight,
                    //        AluminumCansPrice = personalInformationVM.donationInput.AluminumCansPrice,

                    //        TotalSalePrice = personalInformationVM.donationInput.TotalSalePrice,
                    //        Totalweight = personalInformationVM.donationInput.Totalweight,
                            
                    //    }
                    //}; 
                    _unitOfWork.Buying.Add(personalInformationVM.buying);
                }
                else if (personalInformationVM.selling != null)
                {
                    _unitOfWork.Selling.Add(personalInformationVM.selling);
                }
                else if (personalInformationVM.donationInput != null)
                {
                    var donation = new WasteDonation
                    {
                        BusinessName = personalInformationVM.donationInput.BusinessName,
                        ContactPerson = personalInformationVM.donationInput.ContactPerson,
                        ContactNumber = personalInformationVM.donationInput.ContactNumber,

                        WeightAndPrice = new WeightAndPrice
                        {
                            GlassBottlesWeight = personalInformationVM.donationInput.GlassBottlesWeight,
                            GlassBottlesPrice = personalInformationVM.donationInput.GlassBottlesPrice,

                            MetalsWeight = personalInformationVM.donationInput.MetalsWeight,
                            MetalsPrice = personalInformationVM.donationInput.MetalsPrice,

                            PlasticWeight = personalInformationVM.donationInput.PlasticWeight,
                            PlasticPrice = personalInformationVM.donationInput.PlasticPrice,

                            PaperWeight = personalInformationVM.donationInput.PaperWeight,
                            PaperPrice = personalInformationVM.donationInput.PaperPrice,

                            CardboardWeight = personalInformationVM.donationInput.CardboardWeight,
                            CardboardPrice = personalInformationVM.donationInput.CardboardPrice,

                            AluminumCansWeight = personalInformationVM.donationInput.AluminumCansWeight,
                            AluminumCansPrice = personalInformationVM.donationInput.AluminumCansPrice,

                            TotalSalePrice = personalInformationVM.donationInput.TotalSalePrice,
                            Totalweight = personalInformationVM.donationInput.Totalweight,

                        }
                    };
                    _unitOfWork.Donation.Add(donation);
                }

                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
