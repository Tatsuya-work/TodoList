import http from "~/api/http-common"
import { Task } from "~/data/typings/taskJson"

class AccessApi {
	async getCategory(): Promise<string[]> {
		return (await http.get("/AccessCategory/GetCategory")).data;
	}

	async addCategory(newCategory: string) {
		await http.put(`/AccessCategory/AddCategory?category=${newCategory}`);
	}

	async getTask(category: string): Promise<Task[]> {
		return (await http.get(`/AccessTask/GetTask?category=${category}`)).data;
	}

	async addTask(newTask: string, category: string) {
		await http.put(`/AccessTask/AddTask?newTask=${newTask}&category=${category}`);
	}

	async doneTask(id: number) {
		await http.put(`/AccessTask/DoneTask?id=${id}`);
	}
}

export default new AccessApi();