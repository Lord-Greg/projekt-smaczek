using DbModel.Model;

namespace DbModel.Repositories.Interfaces
{
	public interface IFoodProductRepository
	{
		public Task<IEnumerable<FoodProduct>> GetAllAsync();
	}
}
