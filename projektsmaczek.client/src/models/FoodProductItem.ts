import { FoodProduct } from "./FoodProduct"
import { ContainerType } from "./enums/ContainerType"

export interface FoodProductItem {
    id: number;
    foodProduct: FoodProductDto;
    containerType: ContainerTypeDto;
    weightInGram: number;
}
