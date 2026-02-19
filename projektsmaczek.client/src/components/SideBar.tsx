import React from 'react';
import {
	HeartOutlined,
	BookOutlined,
	BankOutlined,
} from '@ant-design/icons';
import { Layout, Menu } from 'antd';

const { Sider } = Layout;

const App: React.FC = () => {
	return (
		<Sider trigger={null} >
			<div >
				<h3>Projekt Smaczek</h3>
			</div>
			<Menu
				theme="dark"
				mode="inline"
				defaultSelectedKeys={['1']}
				items={[
					{
						key: '1',
						icon: <BookOutlined />,
						label: 'Food catalog',
					},
					{
						key: '2',
						icon: <BankOutlined />,
						label: 'My storage',
					},
					{
						key: '3',
						icon: <HeartOutlined />,
						label: 'Diet advisor',
					},
				]}
			/>
		</Sider>
	);
};

export default App;
