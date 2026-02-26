/**
 * Map given enum type to an array, containing its key and value (enum's key is returned as a label, enum's value, as a value).
 * @param enumType Enum type to map.
 * @returns Array of enum's keys and values.
 */
export function enumToArray<T extends Record<string, string>>(
	enumType: T
):
	Array<{ label: string; value: string }>
{
	return Object.keys(enumType)
		.map(key => ({ label: key, value: enumType[key] }));
}

/**
 * Map given enum type to an array, containing its key and value in reversed order (enum's value is returned as a label, enum's key, as a value).
 * @param enumType Enum type to map.
 * @returns Array of enum's keys and values.
 */
export function enumToArrayReversed<T extends Record<string, string>>(
	enumType: T
):
	Array<{ label: string; value: string }> {
	return Object.keys(enumType)
		.map(key => ({ label: enumType[key], value: key }));
}
