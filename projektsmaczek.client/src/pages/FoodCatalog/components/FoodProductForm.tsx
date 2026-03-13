import { Form, Input, Select, Button, Flex, message } from "antd";
import { FoodType } from "@/models/enums/FoodType";
import { useNavigate } from "react-router-dom";
import type { FoodProduct } from "@/models/FoodProduct";
import { useCreateFoodProduct } from "@/api/foodProductApi";


const FoodProductForm: React.FC = () => {
	const navigate = useNavigate();
	const [form] = Form.useForm<FoodProduct>();
	const createFoodProduct = useCreateFoodProduct();

	const onFinish = (values: FoodProduct) => {
		createFoodProduct.mutate(values, {
			onSuccess: (errorMessage: string) => {
				if (errorMessage) {
					message.error(errorMessage);
				}
				else {
					message.success("Product added succesfully.");
					form.resetFields();
				}
			},
			onError: () => {
				message.error("An error occured while saving your product.");
			},
		});
	};

	const foodTypes = Object.values(FoodType).map(el => ({ value: el, label: el }));

	return (
		<>
			<h2>New food product</h2>

			<Form
				form={form}
				onFinish={onFinish}
				labelCol={{ span: 7 }}
				wrapperCol={{ span: 12 }}
			>
				<Form.Item label="Brand Name" name="foodBrandId">
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
					<Select options={foodTypes} />
				</Form.Item>
				<Flex vertical={false} gap={"small"} justify="center">
					<Form.Item>
						<Button type="primary" htmlType="submit" loading={createFoodProduct.isPending}>
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
