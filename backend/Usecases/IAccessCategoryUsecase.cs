namespace TodoList.Usecases
{
    public interface IAccessCategoryUsecase
    {
        void AddCategory(string  category);

        string[] GetCategory();
    }
}
