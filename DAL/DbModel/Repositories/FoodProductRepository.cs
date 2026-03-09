using DbModel.Contexts;
using DbModel.Model;
using DbModel.Patterns;
using DbModel.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DbModel.Repositories
{
	public class FoodProductRepository : IFoodProductRepository
	{
		private FoodContext _dbContext;

		public FoodProductRepository(FoodContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Result<IEnumerable<FoodProduct>>> GetAllAsync()
		{
			return await _dbContext.FoodProducts
				.Include(fp => fp.FoodBrand)
				.Include(fp => fp.Items)
				.ToListAsync();
		}
	}
}
