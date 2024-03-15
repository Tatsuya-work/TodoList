using TodoList.Usecases;
using TodoList.Data.Class;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccessTaskController : ControllerBase
    {
        private readonly ILogger<AccessTaskController> _logger;
        private readonly IAccessTaskUsecase _accessTaskUsecase;

        public AccessTaskController(ILogger<AccessTaskController> logger, IAccessTaskUsecase accessTaskUsecase)
        {
            _logger = logger;
            _accessTaskUsecase = accessTaskUsecase;
        }

        [HttpPut("AddTask")]
        public void AddTask(string newTask)
        {
            _accessTaskUsecase.AddTask(newTask);
        }

        [HttpGet("GetTask")]
        public TaskList GetTask(string category)
        {
            return(_accessTaskUsecase.GetTask(category));
        }

        [HttpPut("DoneTask")]
        public void DoneTask(int id) 
        {
            _accessTaskUsecase.DoneTask(id);
        }
    }
}
