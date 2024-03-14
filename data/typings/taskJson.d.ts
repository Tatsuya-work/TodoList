declare module "../json/task.json" {
  interface Task {
    Name: string;
    isCheck: boolean;
  }

  interface Category {
    Name: string;
    Task: Task[];
  }

  interface RootObject {
    Category: Category[];
  }

  const tasks: RootObject;
  export default tasks;
}
