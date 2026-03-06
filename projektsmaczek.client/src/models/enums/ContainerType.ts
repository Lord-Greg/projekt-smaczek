const ContainerType = {
    Can: "Can",
    Pouch: "Pouch",
    Bag: "Bag",
    Tray: "Tray",
    Sachet: "Sachet",
    Box: "Box",
    Loose: "Loose"
} as const;

type ContainerType = (typeof ContainerType)[keyof typeof ContainerType];

export { ContainerType };
