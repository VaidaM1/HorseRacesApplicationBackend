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
    public class BetterController : ControllerBase
    {
        private readonly BetterService _betterService;
        public BetterController(BetterService betterService)
        {
            _betterService = betterService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var betters = await _betterService.GetAllAsync();
            return Ok(betters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var better = await _betterService.GetByIdAsync(id);
            return Ok(better);
        }

        [HttpGet]
        [Route("BettersbyHorse/{horseId}")]
        public async Task<ActionResult> GetByHorseId(int horseId)
        {
            var betterByHorse = await _betterService.GetByHorseIdAsync(horseId);
            return Ok(betterByHorse);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Better better)
        {
            var newbetter = await _betterService.CreateAsync(better);

            return Ok(newbetter);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Better better)
        {
            await _betterService.UpdateAsync(better);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _betterService.DeleteAsync(id);

            return NoContent();
        }
    }
}
