import React from 'react';
import { Link } from 'react-router-dom';
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
				<h3>
					<Link to="/" >Projekt Smaczek</Link>
				</h3>
			</div>
			<Menu
				theme="dark"
				mode="inline"
				defaultSelectedKeys={['1']}
				items={[
					{
						key: '1',
						icon: <BookOutlined />,
						label: <Link to="/FoodCatalog" >Food catalog</Link>,
					},
					{
						key: '2',
						icon: <BankOutlined />,
						label: <Link to="/MyStorage">My storage</Link>,
					},
					{
						key: '3',
						icon: <HeartOutlined />,
						label: <Link to="/DietAdvisor" >Diet advisor</Link>,
					},
				]}
			/>
		</Sider>
	);
};

export default App;
