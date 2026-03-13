import type { FoodProductDto } from "@/api/types/FoodProductDto";
import type { FoodProduct } from "@/models/FoodProduct";
import { mapFoodBrandDtoToViewModel, mapFoodBrandViewModelToDto } from "./foodBrandMapper";
import { mapFoodTypeDtoToViewModel, mapFoodTypeViewModelToDto } from "./foodTypeMapper";
import { mapFoodProductItemsDtoToViewModel, mapFoodProductItemsViewModelToDto } from "./foodProductItemMapper";

export const mapFoodProductDtoToViewModel = (dto: FoodProductDto | null): FoodProduct | null => {
	return dto ? {
		key: dto.id,
		name: dto.name,
		description: dto.description,
		foodType: mapFoodTypeDtoToViewModel(dto.foodType),
		foodBrand: mapFoodBrandDtoToViewModel(dto.foodBrand),
		foodBrandId: dto.foodBrand.id,
		items: mapFoodProductItemsDtoToViewModel(dto.items)
	} : null;
};

export const mapFoodProductsDtoToViewModel = (dtoArray: FoodProductDto[] | null): FoodProduct[] =>
	dtoArray ? dtoArray.map(mapFoodProductDtoToViewModel) : [];

export const mapFoodProductViewModelToDto = (viewModel: FoodProduct | null): FoodProductDto | null => {
	return viewModel ? {
		key: viewModel.id,
		name: viewModel.name,
		description: viewModel.description,
		foodType: mapFoodTypeViewModelToDto(viewModel.foodType),
		foodBrand: mapFoodBrandViewModelToDto(viewModel.foodBrand),
		foodBrandId: viewModel.foodBrandId,
		items: mapFoodProductItemsViewModelToDto(viewModel.items)
	} : null;
};

export const mapFoodProductsViewModelToDto = (viewModelArray: FoodProduct[] | null): FoodProductDto[] =>
	viewModelArray ? viewModelArray.map(mapFoodProductViewModelToDto) : [];
