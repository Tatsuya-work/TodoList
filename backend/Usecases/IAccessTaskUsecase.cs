using TodoList.Data.Class;

namespace TodoList.Usecases
{
    public interface IAccessTaskUsecase
    {
        void AddTask(string newTask);

        TaskList GetTask(string category);

        void DoneTask(int id);
    }
}
