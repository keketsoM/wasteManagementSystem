namespace wasteInventoryManagementSystem.Models
{
    public class InputModelDonation
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }

        public string ContactNumber { get; set; }

        public double GlassBottlesWeight { get; set; } = default;

        public double GlassBottlesPrice { get; set; } = default;

        public double MetalsWeight { get; set; } = default;

        public double MetalsPrice { get; set; } = default;


        public double PlasticWeight { get; set; } = default;

        public double PlasticPrice { get; set; } = default;


        public double PaperWeight { get; set; } = default;

        public double PaperPrice { get; set; } = default;

        public double CardboardWeight { get; set; } = default;

        public double CardboardPrice { get; set; } = default;


        public double AluminumCansWeight { get; set; } = default;

        public double AluminumCansPrice { get; set; } = default;


        public double TotalSalePrice { get; set; } = default;


        public double Totalweight { get; set; } = default;
    }
}
