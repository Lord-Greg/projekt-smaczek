using DbModel.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjektSmaczek.Server.DTO;

namespace ProjektSmaczek.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FoodProductController : ControllerBase
	{
		[HttpGet(Name = "GetAllFoodProducts")]
		public async Task<IEnumerable<FoodProductDto>> GetAll(IFoodProductRepository foodProductRepository)
		{
			var foodProducts = await foodProductRepository.GetAllAsync();

			return foodProducts.Select(fp => new FoodProductDto(
				fp.Id,
				fp.Name,
				fp.Description,
				fp.FoodType.ToString(),
				new FoodBrandDto(fp.FoodBrand.Id, fp.FoodBrand.Name),
				fp.Items.Select(i => new FoodProductItemDto(
					i.Id,
					i.ContainerType.ToString(),
					i.WeightInGram
				)).ToList()
			));
		}
	}
}
