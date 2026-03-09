using DbModel.Models;
using DbModel.Patterns;

namespace DbModel.Repositories.Interfaces
{
	public interface IFoodProductRepository
	{
		public Task<Result> AddAsync(FoodProduct foodProduct, CancellationToken cancellationToken = default);
		public Task<Result<IEnumerable<FoodProduct>>> GetAllAsync(CancellationToken cancellationToken = default);
	}
}
