using DbModel.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModel.Models
{
	public class FoodProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public FoodType FoodType { get; set; }
        public int FoodBrandId { get; set; }
        [ForeignKey(nameof(FoodBrandId))]
        public FoodBrand FoodBrand { get; set; }
		public ICollection<FoodProductItem>? Items { get; set; }
    }
}
