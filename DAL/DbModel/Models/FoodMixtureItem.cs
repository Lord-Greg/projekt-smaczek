namespace DbModel.Models
{
	internal class FoodMixtureItem
	{
		public int Id { get; set; }
		public FoodMixture FoodMixture { get; set; }
		public FoodProductItem FoodProductItem { get; set; }
		public decimal ItemWeightInGram { get; set; }
	}
}
