namespace DbModel.Models
{
	internal class FoodMixture
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<FoodMixtureItem> Items { get; set; }
	}
}
