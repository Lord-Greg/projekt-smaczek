import { FoodType } from "@/models/enums/FoodType";
import type { FoodTypeDto } from "@/api/types/enums/FoodTypeDto";

export const foodTypeMap: Record<FoodTypeDto, FoodType> = {
	Snacks: FoodType.Snacks,
	DryFood: FoodType.DryFood,
	WetFood: FoodType.WetFood
}

export const mapFoodTypeDtoToViewModel = (dto: FoodTypeDto): FoodType => {
    return foodTypeMap[dto];
}
