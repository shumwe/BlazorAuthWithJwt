using Microsoft.AspNetCore.Mvc;
using BlazorAuthWithJwt.Shared.Models;

namespace BlazorAuthWithJwt.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            string token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiTXJCcmF2aW4iLCJleHAiOjE2NjYxNzc4ODZ9.AcZ5njCKlgCsLQW0SckkRZ5EnJkty3gkm4RyIenOG_PNMkIdi6RpPSsOcX4X1qazv1kyq4CF9jqIvIkMaZ7xPg";
            return token;
        }
    }
}