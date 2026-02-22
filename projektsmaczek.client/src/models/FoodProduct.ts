import { FoodBrand } from "./FoodBrand"
import { FoodProductItem } from "./FoodProductItem"
import { FoodType } from "./enums/FoodType"

export interface FoodProduct {
    id: number;
    name: string;
    description: string | null;
    foodType: FoodType;
    foodBrand: FoodBrand;
    items: FoodProductItem[] | null;
}
