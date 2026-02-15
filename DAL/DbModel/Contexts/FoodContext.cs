using DbModel.Model;
using DbModel.Models;
using Microsoft.EntityFrameworkCore;

namespace DbModel.Contexts
{
	public class FoodContext : DbContext
	{
		public FoodContext(DbContextOptions<FoodContext> options)
			: base(options)
		{
		}

		public DbSet<FoodBrand> FoodBrands { get; set; }
		public DbSet<FoodMixture> FoodMixtures { get; set; }
		public DbSet<FoodMixtureItem> FoodMixtureItems { get; set; }
		public DbSet<FoodProduct> FoodProducts { get; set; }
		public DbSet<FoodProductItem> FoodProductItems { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}
	}
}
