using TodoList.Data.Class;

namespace TodoList.Usecases
{
    public interface IAccessTaskUsecase
    {
        void AddTask(string newTask);

        List<TaskItem> GetTask(string category);

        void DoneTask(int id);
    }
}
