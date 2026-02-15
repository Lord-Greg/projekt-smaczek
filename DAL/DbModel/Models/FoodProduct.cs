using DbModel.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbModel.Model
{
    internal class FoodProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
        public FoodBrand FoodBrand { get; set; }
    }
}
