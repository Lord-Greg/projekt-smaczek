import React from 'react';
import { Table } from 'antd';
import { FoodType } from '@/models/enums/FoodType';
import { ContainerType } from '@/models/enums/ContainerType';
import type { FoodProduct } from '@/models/FoodProduct';
import type { FoodProductItem } from '@/models/FoodProductItem';
import type { TableColumnsType } from 'antd';

const expandDataSource = Array.from({ length: 3 }).map<FoodProductItem>((_, i) => ({
    key: i.toString(),
    id: i,
    containerType: ContainerType.Can,
    weightInGram: 80
}));

const dataSource = Array.from({ length: 3 }).map<FoodProduct>((_, i) => ({
    key: i.toString(),
    id: i,
    name: 'Felix As Good As It Looks',
    description: 'Tasty wet food variety in trays',
    foodType: FoodType.WetFood,
    foodBrand: { id: 1, name: 'Felix' }
}));

const expandColumns: TableColumnsType<FoodProductItem> = [
    { title: 'Id', dataIndex: 'id', key: 'id', hidden: true },
    { title: 'Container Type', dataIndex: 'containerType', key: 'containerType' },
    { title: 'Weight in Gram', dataIndex: 'weightInGram', key: 'weightInGram' },
];

const columns: TableColumnsType<FoodProduct> = [
    { title: 'Id', dataIndex: 'id', key: 'id', hidden: true },
    {
        title: 'Food Brand',
        dataIndex: 'foodBrand',
        render: brand => brand.name
    },
    { title: 'Name', dataIndex: 'name', key: 'name' },
    { title: 'Description', dataIndex: 'description', key: 'description' },
    { title: 'Food Type', dataIndex: 'foodType', key: 'foodType' }
];

const expandedRowRender = () => (
    <Table<FoodProductItem>
        columns={expandColumns}
        dataSource={expandDataSource}
        pagination={false}
    />
);

const FoodProductsTable: React.FC = () => (
    <>
        <Table<FoodProduct>
            columns={columns}
            expandable={{ expandedRowRender }}
            dataSource={dataSource}
        />
    </>
);

export default FoodProductsTable;