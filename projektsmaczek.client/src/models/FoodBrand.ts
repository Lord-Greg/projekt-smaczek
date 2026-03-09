import type { FoodProduct } from "./FoodProduct"

export interface FoodBrand {
    key: number;
    name: string;
    products: FoodProduct[] | null;
}
