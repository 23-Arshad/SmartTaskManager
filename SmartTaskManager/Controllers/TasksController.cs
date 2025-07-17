using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartTaskManager.Database;
using SmartTaskManager.Model;

namespace SmartTaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController(TaskDbContext taskDbContext) : ControllerBase
    {

    }
}
