using DbModel.Contexts;
using DbModel.Model;
using DbModel.Enums;
using DbModel.Models;

namespace DbModel.Initializers
{
	public static class DbInitializer
	{
		public static void Initialize(FoodContext dbContext)
		{
			if (dbContext.FoodBrands.Any())
			{
				// No need to seed.
				return;
			}

			// Seed food brands
			var foodBrands = new List<FoodBrand>
			{
				new FoodBrand { Name = "Whiskas" },
				new FoodBrand { Name = "Purina" },
				new FoodBrand { Name = "Royal Canin" },
				new FoodBrand { Name = "Hill's Science Diet" },
				new FoodBrand { Name = "Iams" },
				new FoodBrand { Name = "Felix" },
				new FoodBrand { Name = "Sheba" },
				new FoodBrand { Name = "Monge" },
				new FoodBrand { Name = "Lily's Kitchen" },
				new FoodBrand { Name = "Applaws" },
				new FoodBrand { Name = "Tiki Cat" },
				new FoodBrand { Name = "Gourmet" }
			};

			dbContext.FoodBrands.AddRange(foodBrands);
			dbContext.SaveChanges();

			// Seed products
			var products = new List<FoodProduct>
			{
				new FoodProduct { Name = "Whiskas Adult Dry Chicken", Description = "Complete dry food for adult cats - chicken", FoodType = FoodType.DryFood, FoodBrand = foodBrands.First(b => b.Name == "Whiskas") },
				new FoodProduct { Name = "Purina One Tender Chicken", Description = "Balanced dry kibble with real chicken", FoodType = FoodType.DryFood, FoodBrand = foodBrands.First(b => b.Name == "Purina") },
				new FoodProduct { Name = "Royal Canin Indoor Wet Pouch", Description = "Wet food pouches for indoor cats", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Royal Canin") },
				new FoodProduct { Name = "Hill's Science Diet Adult", Description = "Vet-recommended dry food for adult cats", FoodType = FoodType.DryFood, FoodBrand = foodBrands.First(b => b.Name == "Hill's Science Diet") },
				new FoodProduct { Name = "Iams Adult Wet Salmon", Description = "Wet food with salmon in gravy", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Iams") },
				new FoodProduct { Name = "Felix As Good As It Looks", Description = "Tasty wet food variety in trays", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Felix") },
				new FoodProduct { Name = "Sheba Fillet in Sauce", Description = "Premium wet food fillets in sauce", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Sheba") },
				new FoodProduct { Name = "Monge Natural Dry Fish", Description = "Grain-free dry food with fish", FoodType = FoodType.DryFood, FoodBrand = foodBrands.First(b => b.Name == "Monge") },
				new FoodProduct { Name = "Lily's Kitchen Adult Chicken", Description = "Natural ingredients, no nasties", FoodType = FoodType.DryFood, FoodBrand = foodBrands.First(b => b.Name == "Lily's Kitchen") },
				new FoodProduct { Name = "Applaws Tuna Pouch", Description = "High meat content wet pouch - tuna", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Applaws") },
				new FoodProduct { Name = "Tiki Cat Ahi in Broth", Description = "High-quality ahi tuna in clear broth", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Tiki Cat") },
				new FoodProduct { Name = "Gourmet Perle Duo", Description = "Delicate wet food portioned in trays", FoodType = FoodType.WetFood, FoodBrand = foodBrands.First(b => b.Name == "Gourmet") },
				new FoodProduct { Name = "Whiskas Temptations Snacks", Description = "Crunchy cat treats - chicken flavour", FoodType = FoodType.Snacks, FoodBrand = foodBrands.First(b => b.Name == "Whiskas") },
				new FoodProduct { Name = "Purina Dental Snacks", Description = "Snacks that help clean teeth", FoodType = FoodType.Snacks, FoodBrand = foodBrands.First(b => b.Name == "Purina") },
				new FoodProduct { Name = "Applaws Crunchy Treats", Description = "Natural crunchy treats", FoodType = FoodType.Snacks, FoodBrand = foodBrands.First(b => b.Name == "Applaws") }
			};

			dbContext.FoodProducts.AddRange(products);
			dbContext.SaveChanges();

			// Seed product items (different containers / weights)
			var items = new List<FoodProductItem>
			{
				new FoodProductItem { FoodProduct = products.First(p => p.Name.Contains("Dry Chicken") || p.Name.Contains("Dry Fish") || p.Name.Contains("Adult Chicken") && p.FoodType == FoodType.DryFood), ContainerType = ContainerType.Bag, WeightInGram = 2000 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Whiskas Adult Dry Chicken"), ContainerType = ContainerType.Bag, WeightInGram = 800 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Purina One Tender Chicken"), ContainerType = ContainerType.Bag, WeightInGram = 1000 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Monge Natural Dry Fish"), ContainerType = ContainerType.Bag, WeightInGram = 400 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Hill's Science Diet Adult"), ContainerType = ContainerType.Bag, WeightInGram = 1500 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Royal Canin Indoor Wet Pouch"), ContainerType = ContainerType.Pouch, WeightInGram = 85 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Applaws Tuna Pouch"), ContainerType = ContainerType.Pouch, WeightInGram = 70 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Iams Adult Wet Salmon"), ContainerType = ContainerType.Can, WeightInGram = 400 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Felix As Good As It Looks"), ContainerType = ContainerType.Tray, WeightInGram = 100 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Sheba Fillet in Sauce"), ContainerType = ContainerType.Tray, WeightInGram = 80 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Tiki Cat Ahi in Broth"), ContainerType = ContainerType.Can, WeightInGram = 70 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Gourmet Perle Duo"), ContainerType = ContainerType.Tray, WeightInGram = 50 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Whiskas Temptations Snacks"), ContainerType = ContainerType.Box, WeightInGram = 60 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Purina Dental Snacks"), ContainerType = ContainerType.Box, WeightInGram = 70 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Applaws Crunchy Treats"), ContainerType = ContainerType.Sachet, WeightInGram = 40 },
				// additional variants
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Whiskas Adult Dry Chicken"), ContainerType = ContainerType.Bag, WeightInGram = 400 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Purina One Tender Chicken"), ContainerType = ContainerType.Bag, WeightInGram = 300 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Iams Adult Wet Salmon"), ContainerType = ContainerType.Can, WeightInGram = 85 },
				new FoodProductItem { FoodProduct = products.First(p => p.Name == "Felix As Good As It Looks"), ContainerType = ContainerType.Tray, WeightInGram = 160 }
			};

			dbContext.FoodProductItems.AddRange(items);
			dbContext.SaveChanges();
		}
	}
}
