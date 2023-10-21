using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzureAdWebApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Employee
            {
                EmpId = index,
                Name = "Employee" + index,
                Salary = 10000,
                Summary = "test azure ad"
            }).ToArray();
        }
    }
}