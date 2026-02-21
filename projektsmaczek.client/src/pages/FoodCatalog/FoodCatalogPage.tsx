import { Layout, theme } from "antd";
import FoodProductForm from "./components/FoodProductForm";

const FoodCatalogPage: React.FC = () => {
	const {
		token: { colorBgContainer, borderRadiusLG },
	} = theme.useToken();

	return (
		<>
			<Layout>
				<FoodProductForm />
			</Layout>
		</>
	);
}

export default FoodCatalogPage;
