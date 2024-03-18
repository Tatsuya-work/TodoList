using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TodoList.Data.Class
{
    public static class JsonExtensions
    {
        public static TaskList DeserializeJson()
        {
            string path = @"Data/task.json";
            var stream = new FileStream(path, FileMode.Open);
            var sr = new StreamReader(stream);

            var json = JsonConvert.DeserializeObject<TaskList>(sr.ReadToEnd())!;
            sr.Close();

            return json;
        }

        public static void SerializeJson(TaskList taskList)
        {
            string path = @"Data/task.json";
            var json = JsonConvert.SerializeObject(taskList, Formatting.Indented);
            File.WriteAllText(path, json);
            return;
        }
    }

    public class TaskItem
    {
        public string Name { get; set; }
        public bool isCheck { get; set; }
    }

    public class Categoty
    {
        public string Name { get; set; }
        public IList<TaskItem>? Task { get; set; }
    }

    public class TaskList
    {
        public IList<Categoty> Category { get; set; }
    }
}
