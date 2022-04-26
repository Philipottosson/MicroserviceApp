using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameService.DAL;

namespace GameService.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GameHandler _userHandler;
        public GamesController(GameHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpGet("")]
        public async Task<ActionResult<ICollection<Games>>> GetAllAsync()
        {
            return Ok(await _userHandler.GetAllGamesAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostGameAsync(string name, string publisher, string contactInfo)
        {
            await _userHandler.PostGameAsync(name, publisher, contactInfo);
            return Ok();
        }

    }
}
