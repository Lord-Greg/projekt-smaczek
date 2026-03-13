using DbModel.Contexts;
using DbModel.Models;
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

		public async Task<Result> AddAsync(FoodProduct foodProduct, CancellationToken cancellationToken = default)
		{
			if (await _dbContext.FoodProducts.AnyAsync(el => el.Name == foodProduct.Name, cancellationToken))
			{
				return Result.Failure($"Food product with name '{foodProduct.Name}' already exists.");
			}

			await _dbContext.FoodProducts.AddAsync(foodProduct, cancellationToken);
			await _dbContext.SaveChangesAsync(cancellationToken);

			return Result.Success();
		}

		public async Task<Result<IEnumerable<FoodProduct>>> GetAllAsync(CancellationToken cancellationToken = default)
		{
			return await _dbContext.FoodProducts
				.Include(fp => fp.FoodBrand)
				.Include(fp => fp.Items)
				.ToListAsync(cancellationToken);
		}
	}
}
