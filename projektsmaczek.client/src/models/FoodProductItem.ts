import type { FoodProduct } from "./FoodProduct"
import { ContainerType } from "./enums/ContainerType"

export interface FoodProductItem {
    key: number;
    foodProduct: FoodProduct;
    containerType: ContainerType;
    weightInGram: number;
}
