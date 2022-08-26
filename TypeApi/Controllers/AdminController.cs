using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Types.Data.Access.Abstractions;
using Types.Data.Access.Concretes;
using Types.Entities;
using Types.Entities.Entities;

namespace TypeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService service;

        public AdminController(IAdminService service)
        {
            this.service = service;
        }

        [HttpGet("list")]
        public IActionResult GetAll()
        {
            var result = service.Get();
            if (result == null)
            {
                return BadRequest("Not found...");
            }
            return Ok(result.ToList());
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await service.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] User data)
        {
            var result = await service.AddAsync(data);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] User data)
        {
            var result = await service.UpdateAsync(id, data);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await service.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}