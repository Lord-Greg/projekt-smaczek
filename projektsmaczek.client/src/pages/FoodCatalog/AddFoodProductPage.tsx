import { Layout } from "antd";
import FoodProductForm from "./components/FoodProductForm";

const FoodCatalogPage: React.FC = () => {
	return (
		<>
			<Layout>
				<FoodProductForm />
			</Layout>
		</>
	);
}

export default FoodCatalogPage;
