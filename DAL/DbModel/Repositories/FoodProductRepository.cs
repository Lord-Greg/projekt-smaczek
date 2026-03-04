using DbModel.Contexts;
using DbModel.Model;
using DbModel.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DbModel.Repositories
{
	internal class FoodProductRepository : IFoodProductRepository
	{
		private FoodContext _dbContext;

		public FoodProductRepository() {
			_dbContext = new FoodContext(new DbContextOptions<FoodContext>());
		}

		public async Task<IEnumerable<FoodProduct>> GetAllAsync()
		{
			return await _dbContext.FoodProducts
				.Include(fp => fp.FoodBrand)
				.Include(fp => fp.Items)
				.ToListAsync();
		}
	}
}
