import { FoodProductDto } from "./FoodProductDto"
import { ContainerTypeDto } from "./enums/ContainerTypeDto"

export interface FoodProductItemDto {
    id: number;
    foodProduct: FoodProductDto;
    containerType: ContainerTypeDto;
    weightInGram: number;
}
