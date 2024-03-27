using System.ComponentModel.DataAnnotations;

namespace wasteInventoryManagementSystem.Models
{
    public class WasteSelling
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public string WholesaleCompany { get; set; }
        public string WholesaleContact { get; set; }



    }
}
