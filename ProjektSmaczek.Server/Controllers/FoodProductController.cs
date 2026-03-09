using DbModel.Enums;
using DbModel.Models;
using DbModel.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjektSmaczek.Server.DTO;

namespace ProjektSmaczek.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FoodProductController : ControllerBase
	{
		private readonly IFoodProductRepository _foodProductRepository;

		public FoodProductController(IFoodProductRepository foodProductRepository)
		{
			_foodProductRepository = foodProductRepository;
		}

		[HttpPost]
		public async Task<string?> Create(CreateFoodProductDto foodProduct, CancellationToken cancellationToken = default)
		{
			var newFoodProduct = new FoodProduct
			{
				Name = foodProduct.Name,
				Description = foodProduct.Description,
				FoodType = Enum.Parse<FoodType>(foodProduct.FoodType),
				FoodBrand = new FoodBrand() { Id = foodProduct.FoodBrandId }
			};

			return (await _foodProductRepository.AddAsync(newFoodProduct, cancellationToken)).ErrorMessage;
		}
		
		[HttpGet(Name = "GetAllFoodProducts")]
		public async Task<IEnumerable<FoodProductDto>> GetAll(CancellationToken cancellationToken = default)
		{
			var foodProductsResponse = await _foodProductRepository.GetAllAsync(cancellationToken);

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
