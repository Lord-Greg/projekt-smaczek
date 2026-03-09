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
			var foodProductsResponse = await foodProductRepository.GetAllAsync();

			IEnumerable<FoodProductDto> resultFoodProducts;

			if (foodProductsResponse.IsSuccess) {
				resultFoodProducts = foodProductsResponse.Data.Select(fp => new FoodProductDto(
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
			else
			{
				resultFoodProducts = new List<FoodProductDto>();

				// TODO: Error logger.
			}

			return resultFoodProducts;
		}
	}
}
