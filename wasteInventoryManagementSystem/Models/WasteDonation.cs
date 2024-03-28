using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wasteInventoryManagementSystem.Models
{
    public class WasteDonation
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }

        public string ContactNumber { get; set; }

        public int WeightAndPriceId {  get; set; }
        [ForeignKey("WeightAndPriceId")]
        public WeightAndPrice WeightAndPrice { get; set; }

    }


}
