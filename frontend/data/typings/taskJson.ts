export class Task {
  name: string;
  isCheck: boolean;
  id: number;

  constructor(name: string, isCheck: boolean, id: number) {
    this.name = name;
    this.isCheck = isCheck;
    this.id = id;
  }
}

export class Category {
  name: string;
  task: Task[];

  constructor(name: string, task: Task[]) {
    this.name = name;
    this.task = task;
  }
}

export class RootObject {
  category: Category[];

  constructor(category: Category[]) {
    this.category = category;
  }
}