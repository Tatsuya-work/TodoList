import tasksJson from "~/data/json/task.json";

export function getCategorys(): string[] {
  const categorys: string[] = [];
  for (let i = 0; i < tasksJson.Categoty.length; i++) {
    categorys.push(tasksJson.Categoty[i].Name);
  }
  return categorys;
}

export function getTasks(category: string) {
  const tasks: { name: string; isCheck: boolean }[] = [];
  if (category == "All Tasks") {
    for (let i = 0; i < tasksJson.Categoty.length; i++)
      for (let j = 0; j < tasksJson.Categoty[i].Task.length; j++) {
        tasks.push({ name: tasksJson.Categoty[i].Task[j].Name, isCheck: tasksJson.Categoty[i].Task[j].isCheck });
      }
    return tasks;
  }

  for (let i = 0; i < tasksJson.Categoty.length; i++) {
    if (tasksJson.Categoty[i].Name == category) {
      for (let j = 0; j < tasksJson.Categoty[i].Task.length; j++) {
        tasks.push({ name: tasksJson.Categoty[i].Task[j].Name, isCheck: tasksJson.Categoty[i].Task[j].isCheck });
      }
    }
    break;
  }
  return tasks;
}
