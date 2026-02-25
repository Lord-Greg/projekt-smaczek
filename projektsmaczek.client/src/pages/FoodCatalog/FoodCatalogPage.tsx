import { Layout, Button, Flex } from "antd";
import { Link } from 'react-router-dom';
import FoodProductsTable from "./components/FoodProductsTable";

const FoodCatalogPage: React.FC = () => {
	return (
		<>
			<Layout>
				<h2>Food catalog</h2>
				<FoodProductsTable />
				<Flex vertical={false} justify="center" style={{ marginBottom: 15 }}>
					<Link to="/FoodCatalog/AddProduct">
						<Button type="primary" className="button-normal">Add new product</Button>
					</Link>
				</Flex>
			</Layout>
		</>
	);
}

export default FoodCatalogPage;
