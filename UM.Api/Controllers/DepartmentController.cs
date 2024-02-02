using Microsoft.AspNetCore.Mvc;
using UM.Application.IService;
using UM.Domain.Model;

namespace UM.Api.Controllers
{
    public class DepartmentController : BaseController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] DepartmentModel department)
        {

            await _departmentService.Add(department);
            return Ok();

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _departmentService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _departmentService.GetById(id);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] DepartmentModel department)
        {
            await _departmentService.Update(department);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            await _departmentService.Delete(id);
            return Ok();
        }
    }
}
