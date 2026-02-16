using DbModel.Model;

namespace DbModel.Models
{
	public class StorageItem
	{
		public int Id { get; set; }
		public Storage Storage { get; set; }
		public FoodProductItem? FoodProductItem { get; set; }
		public FoodMixture? FoodMixture { get; set; }
		public decimal Quantity { get; set; }
	}
}
