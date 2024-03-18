using TodoList.Data.Class;

namespace TodoList.Usecases
{
    public interface IAccessTaskUsecase
    {
        void AddTask(string newTask, string category);

        List<TaskItem> GetTask(string category);

        void DoneTask(int id);
    }
}
