import type { FoodBrandDto } from "./FoodBrandDto"
import type { FoodProductItemDto } from "./FoodProductItemDto"
import { FoodTypeDto } from "./enums/FoodTypeDto"

export interface FoodProductDto {
    id: number;
    name: string;
    description: string | null;
    foodType: FoodTypeDto;
    foodBrand: FoodBrandDto;
    foodBrandId: number;
    items: FoodProductItemDto[] | null;
}
