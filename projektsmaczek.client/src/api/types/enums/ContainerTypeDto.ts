const ContainerTypeDto = {
    Can: "Can",
    Pouch: "Pouch",
    Bag: "Bag",
    Tray: "Tray",
    Sachet: "Sachet",
    Box: "Box",
    Loose: "Loose"
} as const;

type ContainerTypeDto = (typeof ContainerTypeDto)[keyof typeof ContainerTypeDto];

export { ContainerTypeDto };
