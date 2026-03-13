/**
 * Get record's key by it's (first found) value;
 * @param record Record.
 * @param recordValue Record's value to map.
 * @returns Key of first's matching record's value. Null if there's no matching value in record.
*/
export function getRecordKeyByValue<TRecordKey extends string | number | symbol, TRecordValue, TRecord extends Record<TRecordKey, TRecordValue >> (
	record: TRecord,
	recordValue: TRecordValue
): TRecordKey | null
{
	const resultKey = (Object.keys(record) as Array<TRecordKey>).find(key => record[key] === recordValue);
	return resultKey === undefined ? null : resultKey;
}
