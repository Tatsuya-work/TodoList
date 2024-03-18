using TodoList.Usecases;
using TodoList.Data.Class;
using System.Diagnostics;

namespace TodoList.Domains
{
    public class AccessTaskInteractor : IAccessTaskUsecase
    {
        public void AddTask(string newTask, string category)
        {
            var taskListJson = JsonExtensions.DeserializeJson();
            int categoryCount = taskListJson.Categoty.Count;

            for (int i = 0; i < categoryCount; i++)
            {
                if (category == taskListJson.Categoty[i].Name)
                {
                    var tmp = new TaskItem();
                    tmp.Name = newTask;
                    tmp.isCheck = false;
                    taskListJson.Categoty[i].Task.Add(tmp);
                }
            }

            JsonExtensions.SerializeJson(taskListJson);
            return;
        }

        public List<TaskItem> GetTask(string category)
        {
            var taskListJson = JsonExtensions.DeserializeJson();
            var taskList = new List<TaskItem>();
            int categoryCount = taskListJson.Categoty.Count;

            if(category == "All Tasks")
            {
                for (int i = 0; i < categoryCount; i++)
                {
                    var targetTaskList = taskListJson.Categoty[i].Task!;
                    int taskCount = targetTaskList.Count;

                    for (int j = 0; j < taskCount; j++)
                    {
                        var tmp = new TaskItem();
                        tmp.Name = targetTaskList[j].Name;
                        tmp.isCheck = targetTaskList[j].isCheck;
                        taskList.Add(tmp);
                    }
                }
                return taskList;
            }

            for(int i = 0; i < categoryCount; i++)
            {
                if(category == taskListJson.Categoty[i].Name)
                {
                    var targetTaskList = taskListJson.Categoty[i].Task!;
                    int taskCount = targetTaskList.Count;

                    for (int j = 0; j < taskCount; j++)
                    {
                        var tmp = new TaskItem();
                        tmp.Name = targetTaskList[j].Name;
                        tmp.isCheck = targetTaskList[j].isCheck;
                        taskList.Add(tmp);
                    }
                }
            }
            return taskList;
        }

        public void DoneTask(int id)
        {
            return;
        }
    }
}
