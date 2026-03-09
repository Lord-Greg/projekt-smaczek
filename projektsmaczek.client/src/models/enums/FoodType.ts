const FoodType = {
    Snacks: "Snacks",
    DryFood: "Dry Food",
    WetFood: "Wet Food"
} as const;

type FoodType = (typeof FoodType)[keyof typeof FoodType];

export { FoodType };
