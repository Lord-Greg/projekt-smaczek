import { ContainerType } from "@/models/enums/ContainerType";
import type { ContainerTypeDto } from "@/api/types/enums/ContainerTypeDto";

export const containerTypeMap: Record<ContainerTypeDto, ContainerType> = {
	Can: ContainerType.Can,
	Pouch: ContainerType.Pouch,
	Bag: ContainerType.Bag,
	Tray: ContainerType.Tray,
	Sachet: ContainerType.Sachet,
	Box: ContainerType.Box,
	Loose: ContainerType.Loose
}

export const mapContainerTypeDtoToViewModel = (dto: ContainerTypeDto): ContainerType => {
    return containerTypeMap[dto];
}
