import { Layout } from "antd";
import FoodProductsTable from "./components/FoodProductsTable";

const FoodCatalogPage: React.FC = () => {
	return (
		<>
			<Layout>
				<FoodProductsTable />
			</Layout>
		</>
	);
}

export default FoodCatalogPage;
