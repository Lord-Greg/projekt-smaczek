import { useQuery } from "@tanstack/react-query";
import { httpClient } from "./httpClient";
import { mapFoodProductsDtoToViewModel } from "./mappers/foodProductMapper";
import type { FoodProductDto } from "./types/FoodProductDto";

const foodProductsKeys = {
  all: ["foodProducts-all"] as const,
};

const getAllFoodProducts = async (): Promise<FoodProductDto[]> => {
	const response = await httpClient.get<FoodProductDto[]>("/FoodProduct");
	return response.data;
};

export const useFoodProductsQuery = () => {
  return useQuery({
    queryKey: foodProductsKeys.all,
    queryFn: getAllFoodProducts,
    select: mapFoodProductsDtoToViewModel,
    staleTime: 1000 * 60,
  });
};