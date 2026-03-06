const FoodTypeDto = {
    Snacks: "Snacks",
    DryFood: "DryFood",
    WetFood: "WetFood"
} as const;

type FoodTypeDto = (typeof FoodTypeDto)[keyof typeof FoodTypeDto];

export { FoodTypeDto };
