using Carpark.BL.Services.Impls;
using Carpark.BL.Services.Interfaces;
using Carpark.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Carpark.Web.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IAuth _auth;

        public AuthController(IAuth auth)
        {
            _auth = auth;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<string> Login(LoginRequest request)
        {
            return await _auth.Authenticate(request);
        }
    }
}
