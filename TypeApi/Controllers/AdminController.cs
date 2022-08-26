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

        [HttpGet("get/{id}")]
        public IActionResult GetById(string id)
        {
            var result = service.GetByIdAsync(id).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Create([FromBody] User data)
        {
            var result = service.AddAsync(data).Result;
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] User data)
        {
            var result = service.UpdateAsync(id, data).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var result = service.DeleteAsync(id).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}