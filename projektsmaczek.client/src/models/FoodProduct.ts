import type { FoodBrand } from "./FoodBrand"
import type { FoodProductItem } from "./FoodProductItem"
import { FoodType } from "./enums/FoodType"

export interface FoodProduct {
    key: number;
    name: string;
    description: string | null;
    foodType: FoodType;
    foodBrand: FoodBrand;
    items: FoodProductItem[] | null;
}
