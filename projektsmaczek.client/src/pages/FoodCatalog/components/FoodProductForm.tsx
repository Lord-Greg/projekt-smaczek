import { Form, Input, Select, theme } from "antd";

const FoodProductForm: React.FC = () => {
	const {
		token: { colorBgContainer, borderRadiusLG },
	} = theme.useToken();

	return (
		<>
			<Form>
				<Form.Item label="Brand Name" name="brandName">
					<Select
						style={{ width: 120 }}
						options={[
							{ value: '2', label: 'Purina' },
							{ value: '3', label: 'Royal Canin' },
							{ value: '6', label: 'Felix' }
						]}
					/>
				</Form.Item>
			</Form>
		</>
	);
}

export default FoodProductForm;
