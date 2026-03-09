import axios from "axios";

export const httpClient = axios.create({
  baseURL: "https://localhost:7087/api",
  headers: {
    "Content-Type": "application/json",
  },
});
