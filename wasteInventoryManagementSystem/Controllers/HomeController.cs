using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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

        
        public IActionResult PersonalInformation()
        {

            return View();
        }
        [HttpPost, ActionName("PersonalInformation")]
        public IActionResult PersonalInformationPost(PersonalInformationVM personalInformationVM)
        {
            if (personalInformationVM.buyingInput != null)
            {
                HttpContext.Session.SetString("PersonalInformationVM", JsonConvert.SerializeObject(personalInformationVM));
                return RedirectToAction("BuyingType");
            } else if (personalInformationVM.sellingInput != null)
            {
                HttpContext.Session.SetString("PersonalInformationVM", JsonConvert.SerializeObject(personalInformationVM));
                return RedirectToAction("SellingType");
            } else if (personalInformationVM.donationInput != null)
            {
                HttpContext.Session.SetString("PersonalInformationVM", JsonConvert.SerializeObject(personalInformationVM));
                return RedirectToAction("DonationType");
            }

            return Index();
        }

        [HttpGet]
        public IActionResult DonationType()
        {
            string serializedData = HttpContext.Session.GetString("PersonalInformationVM");
            if (!string.IsNullOrEmpty(serializedData))
            {
                var personalInformationVM = JsonConvert.DeserializeObject<PersonalInformationVM>(serializedData);
                return View(personalInformationVM);
            }
            return RedirectToAction("PersonalInformation");
        }

        [HttpPost, ActionName("DonationType")]
        public IActionResult DonationTypePost(PersonalInformationVM personalInformationVM)
        {
            if (ModelState.IsValid)
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
                _unitOfWork.Save();
                return RedirectToAction("EndMessage");
            }
            return View();
        }

        public IActionResult SellingType()
        {
            string serializedData = HttpContext.Session.GetString("PersonalInformationVM");
            if (!string.IsNullOrEmpty(serializedData))
            {
                var personalInformationVM = JsonConvert.DeserializeObject<PersonalInformationVM>(serializedData);
                return View(personalInformationVM);
            }
            return RedirectToAction("PersonalInformation");
        }
        [HttpPost,ActionName("SellingType")]
        public IActionResult SellingTypePost(PersonalInformationVM personalInformationVM) 
        {
            if (ModelState.IsValid)
            {
                var selling = new WasteSelling
                {
                    WholesaleCompany = personalInformationVM.sellingInput!.WholesaleCompany,
                    WholesaleContact = personalInformationVM.sellingInput.WholesaleContact,


                    WeightAndPrice = new WeightAndPrice
                    {
                        GlassBottlesWeight = personalInformationVM.sellingInput.GlassBottlesWeight,
                        GlassBottlesPrice = personalInformationVM.sellingInput.GlassBottlesPrice,

                        MetalsWeight = personalInformationVM.sellingInput.MetalsWeight,
                        MetalsPrice = personalInformationVM.sellingInput.MetalsPrice,

                        PlasticWeight = personalInformationVM.sellingInput.PlasticWeight,
                        PlasticPrice = personalInformationVM.sellingInput.PlasticPrice,

                        PaperWeight = personalInformationVM.sellingInput.PaperWeight,
                        PaperPrice = personalInformationVM.sellingInput.PaperPrice,

                        CardboardWeight = personalInformationVM.sellingInput.CardboardWeight,
                        CardboardPrice = personalInformationVM.sellingInput.CardboardPrice,

                        AluminumCansWeight = personalInformationVM.sellingInput.AluminumCansWeight,
                        AluminumCansPrice = personalInformationVM.sellingInput.AluminumCansPrice,

                        TotalSalePrice = personalInformationVM.sellingInput.TotalSalePrice,
                        Totalweight = personalInformationVM.sellingInput.Totalweight,

                    }
                };

                _unitOfWork.Selling.Add(selling);
                _unitOfWork.Save();
                return RedirectToAction("EndMessage");

            }
           return View();
        }
        public IActionResult BuyingType()
        {
            string serializedData = HttpContext.Session.GetString("PersonalInformationVM");
            if (!string.IsNullOrEmpty(serializedData))
            {
                var personalInformationVM = JsonConvert.DeserializeObject<PersonalInformationVM>(serializedData);
                return View(personalInformationVM);
            }
            return RedirectToAction("PersonalInformation");
        }
        [HttpPost, ActionName("BuyingType")]
        public IActionResult BuyingTypePost(PersonalInformationVM personalInformationVM)
        {
            if (ModelState.IsValid)
            {
                var buying = new WasteBuying
                {
                    Name = personalInformationVM.buyingInput.Name,
                    Surname = personalInformationVM.buyingInput.Surname,
                   

                    WeightAndPrice = new WeightAndPrice
                    {
                        GlassBottlesWeight = personalInformationVM.buyingInput.GlassBottlesWeight,
                        GlassBottlesPrice = personalInformationVM.buyingInput.GlassBottlesPrice,

                        MetalsWeight = personalInformationVM.buyingInput.MetalsWeight,
                        MetalsPrice = personalInformationVM.buyingInput.MetalsPrice,

                        PlasticWeight = personalInformationVM.buyingInput.PlasticWeight,
                        PlasticPrice = personalInformationVM.buyingInput.PlasticPrice,

                        PaperWeight = personalInformationVM.buyingInput.PaperWeight,
                        PaperPrice = personalInformationVM.buyingInput.PaperPrice,

                        CardboardWeight = personalInformationVM.buyingInput.CardboardWeight,
                        CardboardPrice = personalInformationVM.buyingInput.CardboardPrice,

                        AluminumCansWeight = personalInformationVM.buyingInput.AluminumCansWeight,
                        AluminumCansPrice = personalInformationVM.buyingInput.AluminumCansPrice,

                        TotalSalePrice = personalInformationVM.buyingInput.TotalSalePrice,
                        Totalweight = personalInformationVM.buyingInput.Totalweight,

                    }
                };

             _unitOfWork.Buying.Add(buying);
            _unitOfWork.Save();
            return RedirectToAction("EndMessage");
        }
            return View();
        }
        public IActionResult EndMessage()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
