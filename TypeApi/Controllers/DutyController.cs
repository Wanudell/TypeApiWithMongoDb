using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Types.Data.Access.Abstractions;
using Types.Entities.Entities;

namespace TypeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DutyController : ControllerBase
    {
        private readonly IDutyService service;

        public DutyController(IDutyService service)
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
        public IActionResult Create([FromBody] Duty data)
        {
            var result = service.AddAsync(data).Result;
            return Ok(result);
        }

        //[HttpPut("{id}")]
        //public IActionResult Update(string id, [FromBody] Duty data)
        //{
        //    var result = service.UpdateAsync(id, data).Result;
        //    if (result == null)
        //    {
        //        return BadRequest("Not found");
        //    }

        //    return NoContent();
        //}

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