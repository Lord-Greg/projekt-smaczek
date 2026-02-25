import { Form, Input, Select, Button, Flex } from "antd";
import { FoodType } from "@/models/enums/FoodType";
import { enumToArrayReversed } from "@/utils/enum-to-array";
import { useNavigate } from "react-router-dom";


const FoodProductForm: React.FC = () => {
	const navigate = useNavigate();

	return (
		<>
			<h2>New food product</h2>

			<Form
				labelCol={{ span: 7 }}
				wrapperCol={{ span: 12 }}
			>
				<Form.Item label="Brand Name" name="brandName">
					<Select
						options={[
							{ value: '2', label: 'Purina' },
							{ value: '3', label: 'Royal Canin' },
							{ value: '6', label: 'Felix' }
						]}
					/>
				</Form.Item>
				<Form.Item label="Name" name="name">
					<Input maxLength={500} />
				</Form.Item>
				<Form.Item label="Description" name="description">
					<Input maxLength={1000} />
				</Form.Item>
				<Form.Item label="Food type" name="foodType">
					<Select options={enumToArrayReversed(FoodType)} />
				</Form.Item>
				<Flex vertical={false} gap={"small"} justify="center">
					<Form.Item>
						<Button type="primary" htmlType="submit">
							Submit
						</Button>
					</Form.Item>
					<Form.Item>
						<Button type="primary" onClick={() => navigate(-1)}>
							Cancel
						</Button>
					</Form.Item>
				</Flex>
			</Form>
		</>
	);
}

export default FoodProductForm;
