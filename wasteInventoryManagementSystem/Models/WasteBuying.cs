using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wasteInventoryManagementSystem.Models
{
    public class WasteBuying
    {
        [Key]
        public int id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public string Name { get; set; }
        public string Surname { get; set; }


    }
}
