using DbModel.Enums;
using DbModel.Model;

namespace DbModel.Models
{
	public class FoodProductItem
	{
		public int Id { get; set; }
		public FoodProduct FoodProduct {  get; set; }
		public ContainerType ContainerType { get; set; }
		public decimal WeightInGram { get; set; }
	}
}
