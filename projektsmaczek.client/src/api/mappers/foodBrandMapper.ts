import type { FoodBrandDto } from "@/api/types/FoodBrandDto";
import type { FoodBrand } from "@/models/FoodBrand";
import { mapFoodProductsDtoToViewModel } from "./foodProductMapper";

export const mapFoodBrandDtoToViewModel = (dto: FoodBrandDto | null): FoodBrand | null => {
  return dto ? {
	key: dto.id,
  	name: dto.name,
	products: mapFoodProductsDtoToViewModel(dto.products)
  } : null;
};

export const mapFoodBrandsDtoToViewModel = (dtoArray: FoodBrandDto[] | null): FoodBrand[] =>
	dtoArray ? dtoArray.map(mapFoodBrandDtoToViewModel) : [];
