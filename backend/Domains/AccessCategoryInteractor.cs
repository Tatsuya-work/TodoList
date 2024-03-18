using TodoList.Usecases;
using TodoList.Data.Class;

namespace TodoList.Domains
{
    public class AccessCategoryInteractor : IAccessCategoryUsecase
    {
        public void AddCategory(string category)
        {
            var taskListJson = JsonExtensions.DeserializeJson();
            var tmp = new Categoty
            {
                Name = category,
                Task = null
            };
            taskListJson.Category.Add(tmp);

            JsonExtensions.SerializeJson(taskListJson);
        }

        public string[] GetCategory()
        {
            var taskListJson = JsonExtensions.DeserializeJson();
            int categoryCount = taskListJson.Category.Count;

            var categorys = new List<string>();
            for(int i = 0; i < categoryCount; i++ )
            {
                categorys.Add(taskListJson.Category[i].Name);
            }

            categorys.Remove("All Tasks");
            return categorys.ToArray();
        }
    }
}