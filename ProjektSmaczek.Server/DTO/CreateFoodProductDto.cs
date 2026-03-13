namespace ProjektSmaczek.Server.DTO
{
	public record CreateFoodProductDto(string Name, string? Description, string FoodType, int FoodBrandId);
}
