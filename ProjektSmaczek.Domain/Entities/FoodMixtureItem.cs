namespace ProjektSmaczek.Domain.Entities
{
	public class FoodMixtureItem
	{
		public int Id { get; set; }
		public FoodMixture FoodMixture { get; set; }
		public FoodProductItem FoodProductItem { get; set; }
		public int ItemWeightInGram { get; set; }
	}
}
