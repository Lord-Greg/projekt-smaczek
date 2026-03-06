import type { FoodProductDto } from "./FoodProductDto";

export interface FoodBrandDto {
    id: number;
    name: string;
    products: FoodProductDto[] | null;
}
