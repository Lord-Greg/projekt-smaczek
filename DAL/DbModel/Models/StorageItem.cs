using DbModel.Model;
using Microsoft.EntityFrameworkCore;

namespace DbModel.Models
{
	public class StorageItem
	{
		public int Id { get; set; }
		public Storage Storage { get; set; }
		public FoodProductItem? FoodProductItem { get; set; }
		public FoodMixture? FoodMixture { get; set; }
		[Precision(4, 4)]
		public decimal Quantity { get; set; }
	}
}
