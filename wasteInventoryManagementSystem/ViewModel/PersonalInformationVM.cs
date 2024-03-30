using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Headers;
using wasteInventoryManagementSystem.Models;

namespace wasteInventoryManagementSystem.ViewModel
{
    public class PersonalInformationVM
    {
        public WasteBuying? buying { get; set; }
        public WasteDonation? donation { get; set; }

        public InputModelDonation? donationInput { get; set; }
        public WasteSelling? selling { get; set; }
        //[ValidateNever]
        //public IEnumerable<SelectListItem> TypeOFMaterialList { get; set; }
    }
}
