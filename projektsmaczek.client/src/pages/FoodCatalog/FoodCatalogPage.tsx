import { Layout, Button } from "antd";
import { Link } from 'react-router-dom';
import FoodProductsTable from "./components/FoodProductsTable";

const FoodCatalogPage: React.FC = () => {
	return (
		<>
			<Layout>
				<FoodProductsTable />
				<Link to="/FoodCatalog/AddProduct">
					<Button type="primary" className="button-normal">Add new product</Button>
				</Link>
			</Layout>
		</>
	);
}

export default FoodCatalogPage;
