using TodoList.Usecases;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccessCategoryController : ControllerBase
    {
        private readonly ILogger<AccessTaskController> _logger;
        private readonly IAccessCategoryUsecase _accessCategoryUsecase;

        public AccessCategoryController(ILogger<AccessTaskController> logger, IAccessCategoryUsecase accessCategoryUsecase)
        {
            _logger = logger;
            _accessCategoryUsecase = accessCategoryUsecase;
        }

        [HttpPut("AddCategory")]
        public void AddCategory(string category)
        {
            _accessCategoryUsecase.AddCategory(category);
        }

        [HttpGet("GetCategory")]
        public string[] GetCategory()
        {
            return _accessCategoryUsecase.GetCategory();
        }
    }
}
