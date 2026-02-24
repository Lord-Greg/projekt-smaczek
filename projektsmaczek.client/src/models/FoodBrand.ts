import type { FoodProduct } from "./FoodProduct"

export interface FoodBrand {
    id: number;
    name: string;
    products: FoodProduct[] | null;
}
