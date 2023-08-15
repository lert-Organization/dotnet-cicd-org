using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace github_action_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("Login")]
        public string Login()
        {
            return "Login Success";
        }
    }
}
