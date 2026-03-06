import type { FoodProductItemDto } from "@/api/types/FoodProductItemDto";
import type { FoodProductItem } from "@/models/FoodProductItem";
import { mapFoodProductDtoToViewModel } from "./foodProductMapper";
import { mapContainerTypeDtoToViewModel } from "./containerTypeMapper";

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
