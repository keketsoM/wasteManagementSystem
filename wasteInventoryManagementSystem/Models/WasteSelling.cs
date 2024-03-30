using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wasteInventoryManagementSystem.Models
{
    public class WasteSelling
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public string WholesaleCompany { get; set; }
        public string WholesaleContact { get; set; }

        public int WeightAndPriceId { get; set; }
        [ForeignKey("WeightAndPriceId")]
        [ValidateNever]
        public WeightAndPrice WeightAndPrice { get; set; }
    }
}
