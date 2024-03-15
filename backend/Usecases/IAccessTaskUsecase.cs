using TodoList.Domains;

namespace TodoList.Usecases
{
    public interface IAccessTaskUsecase
    {
        void AddTask(string newTask);

        object GetTask(string category);

        void DoneTask(int id);
    }
}
