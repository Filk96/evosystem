using Microsoft.AspNetCore.Mvc;
using UM.Application.IService;
using UM.Domain.Model;

namespace UM.Api.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] EmployeeModel Employee)
        {

            await _employeeService.Add(Employee);
            return Ok();

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _employeeService.GetById(id);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] EmployeeModel Employee)
        {
            await _employeeService.Update(Employee);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            await _employeeService.Delete(id);
            return Ok();
        }
    }
}
