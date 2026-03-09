import React from 'react';
import { Table } from 'antd';
import type { FoodProduct } from '@/models/FoodProduct';
import type { FoodProductItem } from '@/models/FoodProductItem';
import type { TableColumnsType } from 'antd';

const expandColumns: TableColumnsType<FoodProductItem> = [
    { title: 'Key', dataIndex: 'key', key: 'key', hidden: true },
    { title: 'Container Type', dataIndex: 'containerType', key: 'containerType' },
    { title: 'Weight in Gram', dataIndex: 'weightInGram', key: 'weightInGram' },
];

const columns: TableColumnsType<FoodProduct> = [
    { title: 'Id', dataIndex: 'id', key: 'id', hidden: true },
    {
        title: 'Food Brand',
        dataIndex: 'foodBrand',
        render: brand => brand?.name
    },
    { title: 'Name', dataIndex: 'name', key: 'name' },
    { title: 'Description', dataIndex: 'description', key: 'description' },
    { title: 'Food Type', dataIndex: 'foodType', key: 'foodType' }
];

const expandedRowRender = (record: FoodProduct) => (
    <Table<FoodProductItem>
        columns={expandColumns}
        dataSource={record.items}
        pagination={false}
    />
);

type FoodProductsTableProps = {
    data: FoodProduct[];
};

function FoodProductsTable({ data }: FoodProductsTableProps): React.ReactNode {
    return (
    <>
        <Table<FoodProduct>
            columns={columns}
            expandable={{ expandedRowRender }}
            dataSource={data}
        />
    </>
)
};

export default FoodProductsTable;
