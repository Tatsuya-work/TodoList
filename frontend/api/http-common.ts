import axios from "axios";

const apiClient = axios.create({
  baseURL: "https://localhost:7293"
});

export default apiClient;
