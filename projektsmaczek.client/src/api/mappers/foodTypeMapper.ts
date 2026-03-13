import { FoodType } from "@/models/enums/FoodType";
import type { FoodTypeDto } from "@/api/types/enums/FoodTypeDto";
import { getRecordKeyByValue } from "@/utils/get-record-key-by-value";

export const foodTypeMap: Record<FoodTypeDto, FoodType> = {
	Snacks: FoodType.Snacks,
	DryFood: FoodType.DryFood,
	WetFood: FoodType.WetFood
}

export const mapFoodTypeDtoToViewModel = (dto: FoodTypeDto): FoodType => {
    return foodTypeMap[dto];
}

export const mapFoodTypeViewModelToDto = (viewModel: FoodType): FoodTypeDto => {
	return getRecordKeyByValue(foodTypeMap, viewModel);
}
