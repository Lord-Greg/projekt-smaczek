using Microsoft.EntityFrameworkCore;
using ProjektSmaczek.Domain.Entities;

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
		public DbSet<Storage> Storages { get; set; }
		public DbSet<StorageItem> StorageItems { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}
	}
}
