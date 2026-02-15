using DbModel.Enums;
using DbModel.Models;

namespace DbModel.Model
{
	public class FoodProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
        public FoodBrand FoodBrand { get; set; }
        public ICollection<FoodProductItem> Items { get; set; }
    }
}
