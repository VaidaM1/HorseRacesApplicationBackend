using HorseRaseApplicationBackend.Entities;
using HorseRaseApplicationBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HorseController : ControllerBase
    {
        private readonly HorseService _horseService;

        public HorseController(HorseService horseService)
        {
            _horseService = horseService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var hoses = await _horseService.GetAllAsync();
            return Ok(hoses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var menu = await _horseService.GetByIdAsync(id);
            return Ok(menu);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Horse horse)
        {
            var result = await _horseService.CreateAsync(horse);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Horse horse)
        {
            await _horseService.UpdateAsync(horse);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _horseService.DeleteAsync(id);

            return NoContent();
        }




    }
}
