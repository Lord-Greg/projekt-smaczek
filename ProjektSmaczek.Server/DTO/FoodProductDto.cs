namespace ProjektSmaczek.Server.DTO
{
	public record FoodProductDto(int Id, string Name, string? Description, string FoodType, FoodBrandDto FoodBrand, List<FoodProductItemDto> Items);
}
