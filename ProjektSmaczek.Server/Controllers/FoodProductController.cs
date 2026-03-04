using DbModel.Model;
using DbModel.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjektSmaczek.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FoodProductController : ControllerBase
	{
		[HttpGet(Name = "GetAllFoodProducts")]
		public async Task<IEnumerable<FoodProduct>> GetAll(IFoodProductRepository foodProductRepository)
		{
			return await foodProductRepository.GetAllAsync();
		}
	}
}
