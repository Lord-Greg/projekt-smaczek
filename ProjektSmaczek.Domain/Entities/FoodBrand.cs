namespace ProjektSmaczek.Domain.Entities
{
    public class FoodBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FoodProduct>? Products { get; set; }

	}
}
