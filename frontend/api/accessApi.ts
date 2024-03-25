import http from "~/api/http-common"

class AccessApi {
	async getCategory(): Promise<string[]> {
		return (await http.get("/AccessCategory/GetCategory")).data;
	}

	async addCategory(newCategory: string) {
		await http.put(`/AccessCategory/AddCategory?category=${newCategory}`);
	}
}

export default new AccessApi();