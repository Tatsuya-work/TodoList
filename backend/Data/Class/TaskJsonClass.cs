using Newtonsoft.Json;

namespace TodoList.Data.Class
{
    public static class JsonExtensions
    {
        public static TaskList DeserializeJson()
        {
            string path = @"Data/task.json";
            var stream = new FileStream(path, FileMode.Open);
            var sr = new StreamReader(stream);

            return JsonConvert.DeserializeObject<TaskList>(sr.ReadToEnd());
        }
    }

    public class Task
    {
        public string Name { get; set; }
        public bool isCheck { get; set; }
    }

    public class Categoty
    {
        public string Name { get; set; }
        public IList<Task>? Task { get; set; }
    }

    public class TaskList
    {
        public IList<Categoty> Categoty { get; set; }
    }
}
