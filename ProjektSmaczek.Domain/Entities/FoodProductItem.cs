using ProjektSmaczek.Domain.Enums;

namespace ProjektSmaczek.Domain.Entities
{
	public class FoodProductItem
	{
		public int Id { get; set; }
		public FoodProduct FoodProduct {  get; set; }
		public ContainerType ContainerType { get; set; }
		public int WeightInGram { get; set; }
	}
}
