using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Services;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetPlayerInfo(string username)
        {
            var player = await _playerService.GetPlayerInfoAsync(username);

            if (player == null)
            {
                return NotFound(new { Message = "Игрок не найден" });
            }

            return Ok(player);
        }
    }
}
