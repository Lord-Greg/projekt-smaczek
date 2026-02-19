import { Layout, theme } from "antd";
import SideBar from "../components/SideBar";
import { Content } from "antd/es/layout/layout";

export default function MainLayout() {
	const {
		token: { colorBgContainer, borderRadiusLG },
	} = theme.useToken();

	return (
		<>
			<Layout className="full-page">
				<SideBar />
				<Layout>
					<Content
						style={{
							margin: '24px 16px',
							padding: 24,
							minHeight: 280,
							background: colorBgContainer,
							borderRadius: borderRadiusLG,
						}}
					>
						<p>Page content</p>
					</Content>
				</Layout>
			</Layout>
		</>
	);
}