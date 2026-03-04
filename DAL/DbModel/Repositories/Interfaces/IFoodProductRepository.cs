using DbModel.Model;

namespace DbModel.Repositories.Interfaces
{
	internal interface IFoodProductRepository
	{
		public Task<IEnumerable<FoodProduct>> GetAllAsync();
	}
}
