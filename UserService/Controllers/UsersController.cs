using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.DAL;

namespace UserService.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserHandler _userHandler;
        public UsersController(UserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Users>>> GetAllAsync()
        {
            return Ok(await _userHandler.GetAllUsersAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostUserAsync(string firstName, string lastName, string email)
        {
            await _userHandler.PostUserAsync(firstName, lastName, email);
            return Ok();
        }

    }
}
