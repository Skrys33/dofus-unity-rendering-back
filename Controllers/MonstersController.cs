using System.Threading;
using dofus_unity_rendering_back.Models.Metadata.Monster;
using dofus_unity_rendering_back.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dofus_unity_rendering_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonstersController : ControllerBase
    {
        private readonly ILogger<MonstersController> _logger;
        private readonly IMonsterService _monsterService;

        public MonstersController(ILogger<MonstersController> logger, IMonsterService monsterService)
        {
            _logger = logger;
            _monsterService = monsterService;
        }

        [HttpGet("monsterId")]
        public async Task<ActionResult<Monsters>> GetMonsterByIdAsync(int monsterId)
        {
            var monster = await _monsterService.GetMonsterByIdAsync(monsterId);
            if (monster == null)
            {
                return NotFound();
            }

            return Ok(monster); 
        }
    }
}
