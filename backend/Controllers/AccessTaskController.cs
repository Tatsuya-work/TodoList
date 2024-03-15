using TodoList.Usecases;
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

        [HttpPut]
        public void AddTask(string newTask)
        {
            // プロジェクトファイル解析
            _accessTaskUsecase.AddTask(newTask);
        }

        [HttpGet]
        public object GetTask(string category)
        {
            return(_accessTaskUsecase.GetTask(category));
        }

        [HttpPut]
        public void DoneTask(int id) 
        {
            _accessTaskUsecase.DoneTask(id);
        }
    }
}
