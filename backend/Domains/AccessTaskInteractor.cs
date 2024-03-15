using TodoList.Usecases;
using TodoList.Data.Class;

namespace TodoList.Domains
{
    public class AccessTaskInteractor : IAccessTaskUsecase
    {
        public void AddTask(string newTask)
        {
            return;
        }

        public TaskList GetTask(string category)
        {
            return JsonExtensions.DeserializeJson();
        }

        public void DoneTask(int id)
        {
            return;
        }
    }
}
