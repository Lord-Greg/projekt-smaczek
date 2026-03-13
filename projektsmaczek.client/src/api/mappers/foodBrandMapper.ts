import type { FoodBrandDto } from "@/api/types/FoodBrandDto";
import type { FoodBrand } from "@/models/FoodBrand";
import { mapFoodProductsDtoToViewModel, mapFoodProductsViewModelToDto } from "./foodProductMapper";

export const mapFoodBrandDtoToViewModel = (dto: FoodBrandDto | null): FoodBrand | null => {
  return dto ? {
	key: dto.id,
  	name: dto.name,
	products: mapFoodProductsDtoToViewModel(dto.products)
  } : null;
};

export const mapFoodBrandsDtoToViewModel = (dtoArray: FoodBrandDto[] | null): FoodBrand[] =>
	dtoArray ? dtoArray.map(mapFoodBrandDtoToViewModel) : [];

export const mapFoodBrandViewModelToDto = (viewModel: FoodBrand | null): FoodBrandDto | null => {
	return viewModel ? {
		key: viewModel.id,
		name: viewModel.name,
		products: mapFoodProductsViewModelToDto(viewModel.products)
	} : null;
};
