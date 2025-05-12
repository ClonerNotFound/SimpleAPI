using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Services;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {
        private readonly ServerInfoService _service;

        public ServerController(ServerInfoService service)
        {
            _service = service;
        }

        [HttpGet("{ip}")]
        public async Task<IActionResult> Get(string ip)
        {
            var server = await _service.GetAsync(ip);
            return server == null
                ? NotFound(new { message = "Сервер не найден или не в сети!" })
                : Ok(server);
        }
    }
}
