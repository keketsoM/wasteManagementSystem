using System.ComponentModel.DataAnnotations;

namespace wasteInventoryManagementSystem.Models
{
    public class WeightAndPrice
    {
        
        [Key]
        public int Id { get; set; }

        public double GlassBottlesWeight { get; set; }

        public double GlassBottlesPrice { get; set; }
        public double MetalsWeight { get; set; }
        public double MetalsPrice { get; set; }

        public double PlasticWeight { get; set; }
        public double PlasticPrice { get; set; }

        public double PaperWeight { get; set; }
        public double PaperPrice { get; set; }
        public double CardboardWeight { get; set; }
        public double CardboardPrice { get; set; }

        public double AluminumCansWeight { get; set; }
        public double AluminumCansPrice { get; set; }

        public double TotalSalePrice { get; set; }

        public double Totalweight { get; set; }
    }
}
