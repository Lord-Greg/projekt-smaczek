import type { FoodProductDto } from "@/api/types/FoodProductDto";
import type { FoodProduct } from "@/models/FoodProduct";
import { mapFoodBrandDtoToViewModel } from "./foodBrandMapper";
import { mapFoodTypeDtoToViewModel } from "./foodTypeMapper";
import { mapFoodProductItemsDtoToViewModel } from "./foodProductItemMapper";

export const mapFoodProductDtoToViewModel = (dto: FoodProductDto | null): FoodProduct | null => {
	return dto ? {
		key: dto.id,
		name: dto.name,
		description: dto.description,
		foodType: mapFoodTypeDtoToViewModel(dto.foodType),
		foodBrand: mapFoodBrandDtoToViewModel(dto.foodBrand),
		items: mapFoodProductItemsDtoToViewModel(dto.items)
	} : null;
};

export const mapFoodProductsDtoToViewModel = (dtoArray: FoodProductDto[] | null): FoodProduct[] =>
	dtoArray ? dtoArray.map(mapFoodProductDtoToViewModel) : [];
