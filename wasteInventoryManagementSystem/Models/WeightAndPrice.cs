﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using wasteInventoryManagementSystem.Enums;

namespace wasteInventoryManagementSystem.Models
{
    public class WeightAndPrice
    {
        public WeightAndPrice() 
        {
            GlassBottlesWeight = 0;
            GlassBottlesPrice = 0;
            MetalsWeight = 0;   
            MetalsPrice = 0;    
            PlasticWeight = 0;
            PlasticPrice = 0;
            PaperWeight = 0;
            PaperPrice = 0;
            CardboardWeight = 0;    
            CardboardPrice = 0; 
            AluminumCansWeight = 0; 
            AluminumCansPrice = 0;  
            Totalweight = 0;
            TotalSalePrice = 0; 
        
        }
        
        [Key]
        public int Id { get; set; }

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
