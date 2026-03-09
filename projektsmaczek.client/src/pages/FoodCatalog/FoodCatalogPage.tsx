import { Layout, Button, Flex } from "antd";
import { Link } from 'react-router-dom';
import FoodProductsTable from "./components/FoodProductsTable";
import { useFoodProductsQuery } from "../../api/foodProductApi";

const FoodCatalogPage: React.FC = () => {
	const { isPending, error, data } = useFoodProductsQuery();

	if (isPending) return 'Loading...'

	if (error) return 'An error has occurred: ' + error.message


	return (
		<>
			<Layout>
				<h2>Food catalog</h2>
				<FoodProductsTable data={data} />
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
