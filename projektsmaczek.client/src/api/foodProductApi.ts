import { useMutation, useQuery } from "@tanstack/react-query";
import { httpClient } from "./httpClient";
import { mapFoodProductsDtoToViewModel, mapFoodProductViewModelToDto } from "./mappers/foodProductMapper";
import type { FoodProductDto } from "./types/FoodProductDto";
import type { FoodProduct } from "@/models/FoodProduct";

const foodProductsKeys = {
  all: ["foodProducts-all"] as const,
};

const getAllFoodProducts = async (): Promise<FoodProductDto[]> => {
	const response = await httpClient.get<FoodProductDto[]>("/FoodProduct");
	return response.data;
};

const createFoodProduct = async (foodProduct: FoodProduct): Promise<string | null> => {
	const response = await httpClient.post<string | null>("/FoodProduct/Create", mapFoodProductViewModelToDto(foodProduct));
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

export const useCreateFoodProduct = () => {
	return useMutation({
		mutationFn: createFoodProduct
	});
};
