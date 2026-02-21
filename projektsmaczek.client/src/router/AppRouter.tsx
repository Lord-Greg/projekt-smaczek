import { Routes, Route } from "react-router-dom";
import MainLayout from "@/layouts/MainLayout";
import HomePage from "@/pages/Home/HomePage";
import FoodCatalogPage from "@/pages/FoodCatalog/FoodCatalogPage";

export const AppRouter = () => (
    <Routes>
        <Route element={<MainLayout />}>
            <Route index element={<HomePage />} />
            <Route path="FoodCatalog" element={<FoodCatalogPage />} />
            <Route path="MyStorage" element={<HomePage />} />
            <Route path="DietAdvisor" element={<HomePage />} />
        </Route>
    </Routes>
);
