import type { FoodProductItemDto } from "@/api/types/FoodProductItemDto";
import type { FoodProductItem } from "@/models/FoodProductItem";
import { mapFoodProductDtoToViewModel, mapFoodProductViewModelToDto } from "./foodProductMapper";
import { mapContainerTypeDtoToViewModel, mapContainerTypeViewModelToDto } from "./containerTypeMapper";

export const mapFoodProductItemDtoToViewModel = (dto: FoodProductItemDto | null): FoodProductItem | null => {
	return dto ? {
		key: dto.id,
		foodProduct: mapFoodProductDtoToViewModel(dto.foodProduct),
		containerType: mapContainerTypeDtoToViewModel(dto.containerType),
		weightInGram: dto.weightInGram
	} : null;
};

export const mapFoodProductItemsDtoToViewModel = (dtoArray: FoodProductItemDto[] | null): FoodProductItem[] =>
	dtoArray ? dtoArray.map(mapFoodProductItemDtoToViewModel) : [];

export const mapFoodProductItemViewModelToDto = (viewModel: FoodProductItem | null): FoodProductItemDto | null => {
	return viewModel ? {
		key: viewModel.id,
		foodProduct: mapFoodProductViewModelToDto(viewModel.foodProduct),
		containerType: mapContainerTypeViewModelToDto(viewModel.containerType),
		weightInGram: viewModel.weightInGram
	} : null;
};

export const mapFoodProductItemsViewModelToDto = (viewModelArray: FoodProductItem[] | null): FoodProductItemDto[] =>
	viewModelArray ? viewModelArray.map(mapFoodProductItemViewModelToDto) : [];
