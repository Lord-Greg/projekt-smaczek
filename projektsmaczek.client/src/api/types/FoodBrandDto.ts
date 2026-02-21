import { FoodProductDto } from "./FoodProductDto";

export interface FoodBrand {
    id: number;
    name: string;
    products: FoodProductDto[] | null;
}
