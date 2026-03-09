using DbModel.Model;
using DbModel.Patterns;

namespace DbModel.Repositories.Interfaces
{
	public interface IFoodProductRepository
	{
		public Task<Result<IEnumerable<FoodProduct>>> GetAllAsync();
	}
}
