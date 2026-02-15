using DbModel.Enums;
using DbModel.Model;

namespace DbModel.Models
{
	internal class FoodProductItem
	{
		public int Id { get; set; }
		public FoodProduct FoodProduct {  get; set; }
		public ContainerType ContainerType { get; set; }
		public decimal WeightInGram { get; set; }
	}
}
