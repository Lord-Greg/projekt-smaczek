import { FoodBrandDto } from "./FoodBrandDto"
import { FoodProductItemDto } from "./FoodProductItemDto"
import { FoodTypeDto } from "./enums/FoodTypeDto"

export interface FoodProductDto {
    id: number;
    name: string;
    description: string | null;
    foodType: FoodTypeDto;
    foodBrand: FoodBrandDto;
    items: FoodProductItemDto[] | null;
}
